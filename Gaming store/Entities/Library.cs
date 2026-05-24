using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_store.Entities
{
    public class Library
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<LibraryGame> LibrariesGames { get; set; } = new List<LibraryGame>();
    }
}
