using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace signalrTestApp
{
    public class TestHub : Hub
    {
        public async Task Send(string input)
        {
            await Clients.All.SendAsync("Receive", input);
        }

        public async Task SendColor(bool isActive)
        {
            await Clients.All.SendAsync("ReceiveColor", isActive);
        }

        public async Task SendDelete(object inputs)
        {
            await Clients.All.SendAsync("ReceiveDelete", inputs);
        }
    }
}
