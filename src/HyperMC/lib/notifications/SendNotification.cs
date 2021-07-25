using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;
using DesktopToast;
using DesktopNotifications;
namespace HyperMCLIB
{
    public class SendNotification
    {
        public void send(String title, String body)
        {
            ToastContentBuilder content = new ToastContentBuilder()
                 .AddText(title)
                 .AddText(body);
        }
    }
}
