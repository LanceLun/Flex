﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCoreService.Models.EFModels
{
    public partial class orderItems
    {
        public int Id { get; set; }
        public int order_Id { get; set; }
        public string product_name { get; set; }
        public int fk_typeId { get; set; }
        public int? per_price { get; set; }
        public int? quantity { get; set; }
        public string discount_name { get; set; }
        public int? subtotal { get; set; }
        public int? discount_subtotal { get; set; }
        public string Items_description { get; set; }

        public virtual Type fk_type { get; set; }
        public virtual orders order { get; set; }
    }
}