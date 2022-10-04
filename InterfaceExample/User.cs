namespace InterfaceExample
{
    public class User
    {
        public string _userName;
        private INotificationService _notifcationService;
        public User(string username, INotificationService notificationService)
        {
            _userName = username;
            //_notifcationService = new ConsoleNotifcation();
            _notifcationService = notificationService;
        }

        public void ChangeUsername(string newUserName)
        {
            _userName = newUserName;
            _notifcationService.NotifyChangedUserName(this);

        }


    }
}