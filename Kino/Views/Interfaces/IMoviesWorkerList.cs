using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface IMoviesWorkerList
    {
        public Action LoadMoviesList { get; set; }
        public Func<int> GetMoviesListCount { get; set; }
        public Action<int> ReadMovieOnIndex { get; set; }
        public Func<string> GetMovieTitle { get; set; }
        public Action<int> RemoveMovieOnIndex { get; set; }
        public Action<int> EditMovieOnIndex { get; set; }
        public Action MakeNewMovieObject { get; set; }
    }
}
