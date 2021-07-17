using Hypermc;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hypermc.Controls
{
    public partial class ModDownloadList : UserControl, IList<Mod>
    {
        private List<Mod> mods = new();

        public ModDownloadList()
        {
            InitializeComponent();
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = table.BackColor = value;
        }

        #region IList<> implementation
        public Mod this[int index]
        {
            get => mods[index];
            set
            {
                if (value is null)
                    throw new ArgumentNullException(nameof(value));

                mods[index] = value;

                (table.GetControlFromPosition(0, index) as ModDownloadListing).Mod = value;
            }
        }

        public int Count => mods.Count;

        public bool IsReadOnly => false;

        public void Add(Mod item)
        {
            if (item is null)
                throw new ArgumentNullException(nameof(item));

            mods.Add(item);

            table.RowCount++;
            table.RowStyles.Add(GetRowStyle());
            table.Controls.Add(new ModDownloadListing() { Mod = item }, 0, table.RowCount - 1);
        }
        public void Clear()
        {
            mods.Clear();

            table.RowCount = 0;
            table.RowStyles.Clear();
            table.Controls.Clear();
        }
        public bool Contains(Mod item) => mods.Contains(item);
        public void CopyTo(Mod[] array, int arrayIndex) => mods.CopyTo(array, arrayIndex);
        public IEnumerator<Mod> GetEnumerator() => mods.GetEnumerator();
        public int IndexOf(Mod item) => mods.IndexOf(item);
        public void Insert(int index, Mod item)
        {
            if (item is null)
                throw new ArgumentNullException(nameof(item));

            mods.Insert(index, item);

            // TODO: Insert row and add create listing
        }
        public bool Remove(Mod item) => throw new NotImplementedException();
        public void RemoveAt(int index) => throw new NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => mods.GetEnumerator();
        #endregion

        /// <summary>
        /// Generates a RowStyle object to add to the row styles of <see cref="table"/>.
        /// </summary>
        private RowStyle GetRowStyle() => new(SizeType.Percent, 100f / table.RowCount);
    }
}
