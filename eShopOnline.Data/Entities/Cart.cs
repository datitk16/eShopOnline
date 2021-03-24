using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnline.Data.EF
{
   public class Cart
    {

        // cart relationship to product is one to many
        // cart relationship to user is one to many

        public int Id { get;set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public DateTime DateCreated { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
