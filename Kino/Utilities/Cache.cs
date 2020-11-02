using Kino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Utilities
{
    public static class Cache
    {
        public static User User { get; set; }
        public static List<Reservation> Reservations { get; set; }
        public static Reservation Reservation { get; set; }
        public static List<Seance> Seances { get; set; }
        public static Seance Seance { get; set; }
        public static List<Hall> Halls { get; set; }
        public static Hall Hall { get; set; }
        public static List<Movie> Movies { get; set; }
        public static Movie Movie { get; set; }
        public static List<User> Workers { get; set; }
        public static User Worker { get; set; }
    }
}
