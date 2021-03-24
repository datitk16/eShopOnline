using eShopOnline.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnline.Data.EF
{
   public class Promotion
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool ApplyForAll { get; set; }
        public int? DiscountPercent { get; set; }
        public decimal? DiscountAmount { get; set; }
        public string ProductCategoryIds { get; set; }

        public Status Status { get; set; }
        public string Name { get; set; }

    }
}
