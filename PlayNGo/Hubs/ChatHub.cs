﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace PlayNGo.Hubs
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void Send(string message)
        {
            Clients.All.addNewMessageToPage(message);
        }
    }
}