﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCoreService.Models.EFModels
{
    public partial class SpeakerFields
    {
        public SpeakerFields()
        {
            Speakers = new HashSet<Speakers>();
        }

        public int FieldId { get; set; }
        public string FieldName { get; set; }

        public virtual ICollection<Speakers> Speakers { get; set; }
    }
}