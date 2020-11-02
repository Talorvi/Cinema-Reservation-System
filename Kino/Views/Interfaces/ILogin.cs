using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface ILogin
    {
        public Func<string, string, bool> IsLoginValid { get; set; }
        public Func<bool> IsWorker { get; set; }
    }
}
