using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_store.Enums
{
    public enum Genres
    {        
            Action = 1,
            Adventure = 2,
            RolePlaying = 3,
            Simulation = 4,
            Strategy = 5,
            Sports = 6,
            Puzzle = 7,
            Horror = 8,
            Racing = 9,
            Fighting = 10        
    }
    public class GenreHelper
    {
        public static Genres GetGenresFromEnumName(string name)
        {
            return (Genres)Enum.Parse(typeof(Genres), name);
        }
    }
}
