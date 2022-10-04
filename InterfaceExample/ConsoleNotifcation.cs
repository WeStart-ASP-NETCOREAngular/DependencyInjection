using System;

namespace InterfaceExample
{
    public class ConsoleNotifcation : INotificationService
    {
        public void NotifyChangedUserName(User user)
        {
            Console.WriteLine($"Username has been changed to :{user._userName}");
        }
    }
}