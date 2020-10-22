using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectASPCore.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCardItemId { get; set; }
        public Book Book { get; set; }
        public int Amount { get; set; }
        public String ShoppingCartSessionId { get; set; }

    }
}
