﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models.EFModels
{
    public partial class orders
    {
        public orders()
        {
            PointHistories = new HashSet<PointHistories>();
            PointTradeIn = new HashSet<PointTradeIn>();
            orderItems = new HashSet<orderItems>();
        }

        public int Id { get; set; }
        public DateTime ordertime { get; set; }
        public int fk_member_Id { get; set; }
        public int total_quantity { get; set; }
        public int logistics_company_Id { get; set; }
        public int order_status_Id { get; set; }
        public int pay_method_Id { get; set; }
        public int pay_status_Id { get; set; }
        public string coupon_name { get; set; }
        public int? coupon_discount { get; set; }
        public int? freight { get; set; }
        public string cellphone { get; set; }
        public string receipt { get; set; }
        public string receiver { get; set; }
        public string recipient_address { get; set; }
        public string order_description { get; set; }
        public int total_price { get; set; }
        public bool? close { get; set; }
        public DateTime? close_time { get; set; }
        public int? fk_typeId { get; set; }

        public virtual Members fk_member { get; set; }
        public virtual Type fk_type { get; set; }
        public virtual logistics_companies logistics_company { get; set; }
        public virtual order_statuses order_status { get; set; }
        public virtual pay_methods pay_method { get; set; }
        public virtual pay_statuses pay_status { get; set; }
        public virtual ICollection<PointHistories> PointHistories { get; set; }
        public virtual ICollection<PointTradeIn> PointTradeIn { get; set; }
        public virtual ICollection<orderItems> orderItems { get; set; }
    }
}