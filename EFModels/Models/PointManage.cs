﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFModels.Models
{
    public partial class PointManage
    {
        public int PointManageId { get; set; }
        public bool GetOrDeduct { get; set; }
        public int Amount { get; set; }
        public int fk_TypeId { get; set; }
        public int? TypeProductId { get; set; }
        public DateTime? PointExpirationDate { get; set; }

        public virtual Type fk_Type { get; set; }
    }
}