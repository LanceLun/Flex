﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models.EFModels
{
    public partial class ShoesCategories
    {
        public ShoesCategories()
        {
            CustomizedShoesPo = new HashSet<CustomizedShoesPo>();
        }

        public int ShoesCategoryId { get; set; }
        public string ShoesCategoryName { get; set; }

        public virtual ICollection<CustomizedShoesPo> CustomizedShoesPo { get; set; }
    }
}