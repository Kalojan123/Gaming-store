using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_store.Entities
{
    public class WishlistGame
    {        
        public int Id { get; set; }
        public int WishlistId { get; set; }
        public Wishlist Wishlist { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
