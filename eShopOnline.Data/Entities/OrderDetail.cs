using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnline.Data.EF
{
   public class OrderDetail
    {

        // order detail relationship with order is one to many
        // order detail relationship with product is one to many
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }


    }
}
