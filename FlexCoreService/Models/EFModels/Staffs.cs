﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCoreService.Models.EFModels
{
    public partial class Staffs
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public byte? Age { get; set; }
        public bool? Gender { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public DateTime? DueDate { get; set; }
        public int fk_PermissionsId { get; set; }
        public int fk_TitleId { get; set; }
        public int fk_DepartmentId { get; set; }
        public string ConfirmCode { get; set; }

        public virtual Departments fk_Department { get; set; }
        public virtual StaffPermissions fk_Permissions { get; set; }
        public virtual JobTitles fk_Title { get; set; }
    }
}