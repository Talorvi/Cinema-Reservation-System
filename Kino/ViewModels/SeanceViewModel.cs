using System;
using System.Linq;
using Kino.Utilities;
using Kino.Validators;
using Kino.Views.Interfaces;

namespace Kino.ViewModels
{
    class SeanceViewModel
    {
        private ISeance view;
        public SeanceViewModel(ISeance view)
        {
            this.view = view;
            view.GetDate += GetDate;
            view.GetHall += GetHall;
            view.GetMovie += GetMovie;
            view.SaveSeance += SaveSeance;
            view.SetDate += SetDate;
            view.SetHall += SetHall;
            view.SetMovie += SetMovie;
            view.GetHallsArray += GetHallsArray;
            view.GetMoviesArray += GetMoviesArray;
        }

        private string[] GetMoviesArray()
        {
            return MovieValidator.GetAllMovies().Select(x => x.Name).ToArray();
        }

        private string[] GetHallsArray()
        {
            return HallValidator.GetAllHalls().Select(x => x.Name).ToArray();
        }

        private void SetMovie(string name)
        {
            Cache.Seance.Movie.Name = name;
        }

        private void SetHall(string name)
        {
            Cache.Seance.Hall.Name = name;
        }

        private void SetDate(DateTime time)
        {
            Cache.Seance.Time = time;
        }

        private void SaveSeance()
        {
            if (Cache.Seance.Id != 0)
            {
                SeanceValidator.SeanceUpdateValidation(
                    Cache.Seance.Id, 
                    MovieValidator.GetMovieByName(Cache.Seance.Movie.Name).Id,
                    HallValidator.GetHallByName(Cache.Seance.Hall.Name).Id, 
                    Cache.Seance.Time
                    );
            }
            else
            {
                SeanceValidator.SeanceAddValidation(
                    Cache.Seance.MovieId,
                    Cache.Seance.HallId,
                    Cache.Seance.Time
                    );
            }
        }

        private string GetMovie()
        {
            return Cache.Seance.Movie.Name;
        }

        private string GetHall()
        {
            return Cache.Seance.Hall.Name;
        }

        private DateTime GetDate()
        {
            return Cache.Seance.Time;
        }
    }
}