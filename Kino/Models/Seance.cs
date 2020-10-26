using System;
using LinqToDB.Mapping;

namespace Kino.Models
{
    /*
     * Constructor created automatically by LinqToDB
     * Creating custom constructor generates an error
     * when fetching data from DB
     */
    [Table(Name = "seances")]
    public class Seance
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "movie_id"), NotNull]
        public int MovieId { get; set; }
        
        [Column(Name = "hall_id"), NotNull]
        public int HallId { get; set; }
        
        [Column(Name = "time"), NotNull]
        public DateTime Time { get; set; }
        
        public Movie Movie { get; set; }
        
        public Hall Hall { get; set; }

        /*
         * Builder for seance, used while fetching
         * the movie and hall from different table
         */
        public static Seance Build(Seance seance, Movie movie, Hall hall)
        {
            if (seance != null)
            {
                seance.Movie = movie;
                seance.Hall = hall;
            }
            return seance;
        }
    }
}