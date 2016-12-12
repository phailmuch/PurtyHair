using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    public class Ware
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public bool Unsellable { get; set; }


        public Ware(int id, int price, int quantity, string description, bool unsellable)
        {
            Id = id;
            Price = price;
            Quantity = quantity;
            Description = description;
            Unsellable = unsellable;
        }

    }

    
}
