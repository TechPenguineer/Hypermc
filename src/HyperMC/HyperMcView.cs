using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hypermc.Data;
using Hypermc.Services;
using Hypermc.Settings;
using Hypermc.UI.Dialogs;
using Hypermc.UI.UserControls;
using Hypermc.UI.Views;
using Hypermc.Utility;
using HyperMC.CurseForge;
using Microsoft.Extensions.DependencyInjection;

namespace Hypermc
{
    public partial class HyperMcView : Form, IViewHost
    {

        private readonly IForgeClient _forgeClient;
        private readonly IServiceProvider _provider;
        private readonly IFileManager _fileManager;
        private readonly IUserSettings _settings;

        public HyperMcView(IForgeClient forgeClient, IServiceProvider provider, IFileManager fileManager, IUserSettings settings)
        {
            InitializeComponent();

            _forgeClient = forgeClient;
            _provider = provider;
            _fileManager = fileManager;
            _settings = settings;
            _modpacks = new();
            _modpacks.CollectionChanged += ModpacksUpdated;
        }

        private async void HyperMcView_Load(object sender, EventArgs e)
        {
            SetView(new ControlView(pnl_MainArea));
            var mods = await _fileManager.ReadFile<ModpackData[]>($@"{_settings.ModPacksPath}\packs.json");
            if (mods != null)
            {
                foreach (var mod in mods)
                {
                    _modpacks.Add(mod);
                }
            }
        }

        #region Default View

        #region Create Modpack Button

        private void Hbtn_CreateModpack_Click(object sender, EventArgs e)
        {
            CreateModpackDialog dialog = new(_forgeClient);
            DialogResult result = dialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                _modpacks.Add(dialog.Data);
            }
        }

        #endregion Create Modpack Button

        #region Modpack List

        private ObservableCollection<ModpackData> _modpacks;

        private async void ModpacksUpdated(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        foreach (ModpackData item in e.NewItems)
                        {
                            flpnl_Modpacks.Controls.Add(CreateModpackBox(item));
                        }

                        break;
                    }

                case NotifyCollectionChangedAction.Remove:
                    {
                        foreach (ModpackData item in e.OldItems)
                        {
                            flpnl_Modpacks.Controls.RemoveByKey(item.Name);
                        }

                        break;
                    }

                case NotifyCollectionChangedAction.Replace:
                    {
                        foreach (ModpackData item in e.NewItems)
                        {
                            flpnl_Modpacks.Controls.Add(CreateModpackBox(item));
                        }
                        foreach (ModpackData item in e.OldItems)
                        {
                            flpnl_Modpacks.Controls.RemoveByKey(item.Name);
                        }

                        break;
                    }

                case NotifyCollectionChangedAction.Reset:
                    {
                        flpnl_Modpacks.Controls.Clear();
                        foreach (ModpackData item in _modpacks)
                        {
                            flpnl_Modpacks.Controls.Add(CreateModpackBox(item));
                        }

                        break;
                    }
            }

            SortModpacks();
            await _fileManager.WriteToFile(_modpacks.ToArray(), $@"{_settings.ModPacksPath}\packs.json");
        }

        private ModpackBox CreateModpackBox(ModpackData data)
        {
            Image thumbnail;
            if (string.IsNullOrWhiteSpace(data.Thumbnail))
            {
                thumbnail = Properties.Resources.DefaultModpackImage;
            }
            else
            {
                // May need to be changed depending on how the image will be set
                thumbnail = Image.FromStream(_forgeClient.GetImageFromURL(data.Thumbnail).GetAwaiter().GetResult());
            }

            return new()
            {
                Thumbnail = thumbnail,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Name = data.Name,
                Tag = data.Path
            };
        }

        private void SortModpacks()
        {
            // Questionable
            lock (flpnl_Modpacks.Controls)
            {
                Control[] controls = Utils.PopChildControls(flpnl_Modpacks);
                flpnl_Modpacks.Controls.AddRange(controls.OrderBy(x => x.Name).ToArray());
            }
        }

        #endregion Modpack List

        #endregion Default View

        #region Top Panel

        #region Buttons

        #region Close Button

        private void Hbtn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Close Button

        #region Maximize Button

        private void Hbtn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                hbtn_Maximize.Text = "\u25A2"; // ▢
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                hbtn_Maximize.Text = "\u25F1"; // ◱
            }
        }

        #endregion Maximize Button

        #region Minimize Button

        private void Hbtn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion Minimize Button

        #region Options Button

        private void Hbtn_Options_Click(object sender, EventArgs e)
        {
            //Utils.NotImplAlert("Options Menu");
            SetView(_provider.GetRequiredService<SettingView>());
        }

        #endregion Minimize Button

        #endregion Buttons

        #endregion Top Panel

        #region View Hosting

        private IView? _view;
        private IView? _viewPrev;

        public void SetView(IView view, object? data = null)
        {
            if (_view is not null)
            {
                if (_view.GetType() != view.GetType())
                {
                    _view.HideView(Utils.PopChildControls(pnl_MainArea));
                    _view.OnMessage -= View_OnMessage;
                    _viewPrev = _view;
                }
            }

            view.OnMessage += View_OnMessage;

            _view = view;
            Control[] controls = view.ShowView(data);
            pnl_MainArea.Controls.AddRange(controls);
        }

        private void View_OnMessage(IView view, int message)
        {
            if (message == IView.MSG_GO_BACK && _viewPrev is not null)
            {
                SetView(_viewPrev, null);
            }
        }

        #endregion View Hosting
    }
}
