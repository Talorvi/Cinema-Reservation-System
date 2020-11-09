using Kino.Models;
using Kino.Utilities;
using Kino.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.ViewModels
{
    class MenuViewModel
    {
        public MenuViewModel(ILoggedWindow view) 
        {
            view.Logout += Logout;
        }

        private void Logout()
        {
            Cache.WsClient.Disconnect();
            Cache.User = null;
        }
    }
}
