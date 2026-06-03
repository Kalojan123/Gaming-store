using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_store.Entities
{
    public class CartGame
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
