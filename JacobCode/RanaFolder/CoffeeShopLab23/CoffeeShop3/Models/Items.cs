using System;
using System.Collections.Generic;

namespace CoffeeShopLab23.Models
{
    public partial class Items
    {
        public Items()
        {
            UserItem = new HashSet<UserItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public virtual ICollection<UserItem> UserItem { get; set; }
    }
}
