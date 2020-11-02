using Kino.Utilities;
using Kino.Validators;
using Kino.Views.Interfaces;

namespace Kino.ViewModels
{
    class MovieViewModel
    {
        private IMovie view;
        public MovieViewModel(IMovie view)
        {
            this.view = view;
            view.SaveMovie += SaveMovie;
            view.GetMovieTitle += GetMovieTitle;
            view.SetMovieTitle += SetMovieTitle;
        }

        private void SetMovieTitle(string name)
        {
            Cache.Movie.Name = name;
        }

        private string GetMovieTitle()
        {
            return Cache.Movie.Name;
        }

        private void SaveMovie()
        {
            if (Cache.Movie.Id != 0)
            {
                MovieValidator.MovieUpdateValidation(Cache.Movie.Id, Cache.Movie.Name, Cache.Movie.Length);
            }
            else
            {
                MovieValidator.MovieAddValidation(Cache.Movie.Name, Cache.Movie.Length);
            }
        }
    }
}