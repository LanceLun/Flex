﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models.EFModels
{
    public partial class ProductCategories
    {
        public ProductCategories()
        {
            ProductSubCategories = new HashSet<ProductSubCategories>();
        }

        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public int fk_SalesCategoryId { get; set; }
        public string CategoryPath { get; set; }

        public virtual SalesCategories fk_SalesCategory { get; set; }
        public virtual ICollection<ProductSubCategories> ProductSubCategories { get; set; }
    }
}