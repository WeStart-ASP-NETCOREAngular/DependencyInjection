using System;


namespace InterfaceExample
{
    internal class Program
    {

        // Builder
      
        // RUN
        static void Main(string[] args)
        {

            INotificationService consoleNotifcation = new ConsoleNotifcation();
            //WebNotification webNotification = new WebNotification();
            //ConsoleNotifcation cNOt = new ConsoleNotifcation();
           
            var user = new User("Wasim", consoleNotifcation);
            user.ChangeUsername("Ahmad");

        }

        // Interfaces
        // DP Dependancy Injection
    }




}
