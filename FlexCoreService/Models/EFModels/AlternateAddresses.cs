﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCoreService.Models.EFModels
{
    public partial class AlternateAddresses
    {
        public int AddressId { get; set; }
        public string AlternateAddress1 { get; set; }
        public string AlternateAddress2 { get; set; }
        public int? fk_MemberId { get; set; }

        public virtual Members fk_Member { get; set; }
    }
}