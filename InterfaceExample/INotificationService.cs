﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface INotificationService
    {
        void NotifyChangedUserName(User user);
    }
}
