﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFModels.Models
{
    public partial class logistics_company
    {
        public logistics_company()
        {
            orders = new HashSet<order>();
        }

        public int Id { get; set; }
        public string name { get; set; }
        public string tel { get; set; }
        public string logistics_description { get; set; }

        public virtual ICollection<order> orders { get; set; }
    }
}