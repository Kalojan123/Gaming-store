using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_store.Entities
{
    public class LibraryGame
    {
        public int LibraryId { get; set; }
        public Library Library { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
