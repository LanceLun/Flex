﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCoreService.Models.EFModels
{
    public partial class Branches
    {
        public Branches()
        {
            OneToOneReservations = new HashSet<OneToOneReservations>();
            Speakers = new HashSet<Speakers>();
        }

        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }

        public virtual ICollection<OneToOneReservations> OneToOneReservations { get; set; }
        public virtual ICollection<Speakers> Speakers { get; set; }
    }
}