﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models.EFModels
{
    public partial class MembershipLevels
    {
        public MembershipLevels()
        {
            Members = new HashSet<Members>();
            fk_Privilege = new HashSet<Privileges>();
        }

        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public string MinSpending { get; set; }
        public int? Discount { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Members> Members { get; set; }

        public virtual ICollection<Privileges> fk_Privilege { get; set; }
    }
}