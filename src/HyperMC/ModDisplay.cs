using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperMC
{
    public partial class ModDisplay : UserControl
    {
        public ModDisplay(string name, string thubmnailUrl, Func<string, Task> onClick)
        {
            InitializeComponent();
            btnDownload.Click += (s, e) => onClick(name);
            lblName.Text = name;
            modImage.LoadAsync(thubmnailUrl);
        }
    }
}
