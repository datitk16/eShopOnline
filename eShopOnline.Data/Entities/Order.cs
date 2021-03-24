using eShopOnline.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnline.Data.EF
{
   public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipEmail { get; set; }
        public string ShipPhoneNumber { get; set; }

        public OrderStatus Status { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
