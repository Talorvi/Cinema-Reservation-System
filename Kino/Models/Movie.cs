using LinqToDB.Mapping;

namespace Kino.Models
{
    /*
     * Constructor created automatically by LinqToDB
     * Creating custom constructor generates an error
     * when fetching data from DB
     */
    [Table(Name = "movies")]
    public class Movie
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "name"), NotNull]
        public string Name { get; set; }
        
        [Column(Name = "length"), NotNull]
        public double Length { get; set; }
    }
}