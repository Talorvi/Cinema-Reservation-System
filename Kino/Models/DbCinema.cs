using LinqToDB;

namespace Kino.Models
{
    public class DbCinema : LinqToDB.Data.DataConnection
    {
        public DbCinema() : base("Cinema") { }
        public ITable<Movie> Movies => GetTable<Movie>();
    }
}