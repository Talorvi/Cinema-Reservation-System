using Kino.Utilities;
using Kino.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.ViewModels
{
    class MoviesViewModel
    {
        public MoviesViewModel(IMoviesWorkerList view)
        {
            view.EditMovieOnIndex += EditMovie;
            view.GetMoviesListCount += GetCount;
            view.GetMovieTitle += GetMovieTitle;
            view.LoadMoviesList += LoadList;
            view.MakeNewMovieObject += MakeNew;
            view.ReadMovieOnIndex += ReadMovie;
            view.RemoveMovieOnIndex += RemoveMovie;
        }

        private void ReadMovie(int id)
        {
            Cache.Movie = Cache.Movies[id];
        }

        private void RemoveMovie(int id)
        {
            Validators.MovieValidator.MovieDeleteValidation(Cache.Movies[id].Id);
        }

        private void MakeNew()
        {
            Cache.Movie = new Models.Movie();
        }

        private void LoadList()
        {
            Cache.Movies = Validators.MovieValidator.GetAllMovies();
        }

        private string GetMovieTitle()
        {
            return Cache.Movie.Name;
        }

        private int GetCount()
        {
            return Cache.Movies.Count();
        }

        private void EditMovie(int id)
        {
            Cache.Movie = Cache.Movies[id];
        }
    }
}
