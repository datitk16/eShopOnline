using eShopOnline.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnline.Data.Entities
{
   public class ProductTranslation
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public string Details { get; set; }

        public string LanguageId { get; set; }

        public string SeoDescription { set; get; }

        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Language Language { get; set; }
    }
}
