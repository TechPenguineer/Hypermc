using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypermc.UI.Views
{
	public interface IViewHost
	{
		public void SetView(IView view, object? data = null);
	}
}
