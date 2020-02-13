using System;
using System.Collections.Generic;

namespace CoffeeShopLab23.Models
{
    public partial class Users
    {
        public Users()
        {
            UserItem = new HashSet<UserItem>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Counrty { get; set; }
        public double Funds { get; set; }

        public virtual ICollection<UserItem> UserItem { get; set; }
    }
}
