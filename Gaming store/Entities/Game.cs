using Gaming_store.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_store.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genres Genre { get; set; }
        public decimal Price { get; set; }
        public byte[] image { get; set; }
        public DateTime ReleaseDate { get; set; }        
        public ICollection<WishlistGame> WishlistsGames { get; set; } = new List<WishlistGame>();
        public ICollection<CartGame> CartsGames { get; set; } = new List<CartGame>();        
        public ICollection<LibraryGame> LibrariesGames { get; set; } = new List<LibraryGame>();
    }
}
