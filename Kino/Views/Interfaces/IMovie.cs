using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface IMovie
    {
        public Action<string> SetMovieTitle { get; set; }
        public Action SaveMovie { get; set; }
    }
}
