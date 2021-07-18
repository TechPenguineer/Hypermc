using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using LibGit2Sharp;
using System.Linq;
using System.IO;
using System.Enviroment;
namespace Paths
{
    public static String AppData = Enviroment.GetFolderPath(Enviroment.SpecialFolder.ApplicationData);

    public class getDataFolders()
    {
        static string mods,versions;
        public minecraft(string loc)
        {
            mods=AppData+"\\.minecraft\\mods",
            versions=AppData+"\\.minecraft\\versions"
        }
    }
}