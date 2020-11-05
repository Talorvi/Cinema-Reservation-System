using LinqToDB.Mapping;

namespace Kino.Models
{
    /*
     * Constructor created automatically by LinqToDB
     * Creating custom constructor generates an error
     * when fetching data from DB
     */
    [Table(Name = "reservations")]
    public class Reservation
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "user_id"), NotNull]
        public int UserId { get; set; }
        
        [Column(Name = "seance_id"), NotNull]
        public int SeanceId { get; set; }
        
        [Column(Name = "seat"), NotNull]
        public int Seat { get; set; }
        
        [Column(Name = "is_confirmed"), NotNull]
        public bool IsConfirmed { get; set; }
        
        public User User { get; set; }
        
        public Seance Seance { get; set; }

        /*
         * Builder for reservation, used while fetching
         * the user from different table
         */
        public static Reservation Build(Reservation reservation, User user, Seance seance)
        {
            if (reservation != null)
            {
                reservation.User = user;
                reservation.Seance = seance;
            }
            return reservation;
        }

        public static Reservation Build(Reservation reservation, Seance seance)
        {
            if (reservation != null)
            {
                reservation.Seance = seance;
            }
            return reservation;
        }
    }
}