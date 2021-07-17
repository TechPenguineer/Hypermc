using System;
using System.Windows.Forms;

namespace Hypermc.Controls
{
    public class ModDownloadEventArgs : EventArgs
    {
        public Mod Mod { get; init; }
        public ModDownloadEventArgs(Mod mod) => Mod = mod;
    }

    /// <summary>
    /// Control prompting the user to download a mod
    /// </summary>
    public partial class ModDownloadListing : UserControl
    {
        private Mod _mod { get; set; }
        public Mod Mod
        {
            get => _mod;
            set
            {
                if (value is null)
                    throw new ArgumentNullException(nameof(value));

                _mod = value;
                lblModName.Text = _mod.Name;
            }
        }

        public delegate void ModDownloadEventHandler(object sender, ModDownloadEventArgs e);
        public event ModDownloadEventHandler DownloadRequested;

        public ModDownloadListing()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e) => DownloadRequested?.Invoke(this, new(Mod));
    }
}
