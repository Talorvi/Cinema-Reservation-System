using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface IAccount
    {
        public Func<string,bool> CheckOldPassword { get; set; }
        public Action<string> SetNewPassword { get; set; }
        public Action SaveAccount { get; set; }
    }
}
