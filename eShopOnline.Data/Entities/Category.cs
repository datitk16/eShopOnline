using eShopOnline.Data.Entities;
using eShopOnline.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnline.Data.EF
{
   public class Category
    {

        // category relationship with product is many to many 
        // category relatioship with language is many to many
        public int Id { get; set; }
        public int SortOrder { get; set; }

        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }

        public List<ProductInCategory> ProductInCategories { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
