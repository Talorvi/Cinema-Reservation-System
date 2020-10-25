using LinqToDB;

namespace Kino.Models
{
    /*
     * Model that allows connecting to DB and operating on it
     */
    public class DbCinema : LinqToDB.Data.DataConnection
    {
        public DbCinema() : base("Cinema") { }
        public ITable<Movie> Movies => GetTable<Movie>();
        public ITable<Hall> Halls => GetTable<Hall>();
    }
}