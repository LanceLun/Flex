﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models.EFModels
{
    public partial class ColorCategories
    {
        public ColorCategories()
        {
            ProductGroups = new HashSet<ProductGroups>();
            ProductImgs = new HashSet<ProductImgs>();
        }

        public int ColorId { get; set; }
        public string ColorName { get; set; }

        public virtual ICollection<ProductGroups> ProductGroups { get; set; }
        public virtual ICollection<ProductImgs> ProductImgs { get; set; }
    }
}