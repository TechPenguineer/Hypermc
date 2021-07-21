using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hypermc;

namespace Hypermc
{
	public class ModDownloadEventArgs : EventArgs
	{
		public Mod Mod { get; }

		public ModDownloadEventArgs(Mod mod)
		{
			Mod = mod;
		}
	}
}