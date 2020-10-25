using LinqToDB.Mapping;

namespace Kino.Models
{
    /*
     * Constructor created automatically by LinqToDB
     * Creating custom constructor generates an error when fetching data from DB
     */
    [Table(Name = "users")]
    public class User
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "login"), NotNull]
        public string Login { get; set; }
        
        [Column(Name = "password"), NotNull]
        public string Password { get; set; }
        
        [Column(Name = "role"), NotNull]
        public int Role { get; set; }
    }
}