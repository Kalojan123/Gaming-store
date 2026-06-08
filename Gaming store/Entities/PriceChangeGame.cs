using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_store.Entities
{
    public class PriceChangeGame
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public bool IsDiscounted
        {
            get
            {
                return NewPrice < OldPrice;
            }
        }
    }
}
