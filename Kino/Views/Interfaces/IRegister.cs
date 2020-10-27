using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface IRegister
    {
        public Func<string,string,bool> IsRegistrationValid { get; set; }
    }
}
