using LinqToDB.Mapping;

namespace Kino.Models
{
/*
     * Constructor created automatically by LinqToDB
     * Creating custom constructor generates an error
     * when fetching data from DB
     */
    [Table(Name = "halls")]
    public class Hall
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "name"), NotNull]
        public string Name { get; set; }
    }
}