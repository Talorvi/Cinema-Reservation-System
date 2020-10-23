using LinqToDB;
using LinqToDB.Mapping;

namespace Kino.Models
{
    [Table(Name = "movies")]
    public class Movie
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "name"), NotNull]
        public string Name { get; set; }
    }
    
    public class DbCinema : LinqToDB.Data.DataConnection
    {
        public DbCinema() : base("Cinema") { }
        public ITable<Movie> Movies { get { return GetTable<Movie>(); } }
    }
}