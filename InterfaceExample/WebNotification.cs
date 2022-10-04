using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class WebNotification : INotificationService
    {
        public void NotifyChangedUserName(User user)
        {
            Console.WriteLine($"[WEB] Username has been changed to :{user._userName}");
        }
    }
}
