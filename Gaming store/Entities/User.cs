using Gaming_store.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_store.Entities
{
    public class User
    {
        public int Id { get; set; }       
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }       
        public decimal Balance { get; set; }
        public Roles Role { get; set; }
        public int WishlistId { get; set; }
        public Wishlist Wishlist { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }        
        public int LibraryId { get; set; }
        public Library Library { get; set; }
        public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
