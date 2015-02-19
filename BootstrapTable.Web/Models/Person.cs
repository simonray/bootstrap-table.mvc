using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapTable.Web.Models
{
    [DebuggerDisplayAttribute("{Id}-{FirstName}")]
    public class Person
    {
        public int Id { get; set; }
        [Display(Name = "First")]
        public string FirstName { get; set; }
        [Display(Name = "Last")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string HiddenField1 { get; set; }
        [Display(AutoGenerateField = false)]
        public string HiddenField2 { get; set; }
    }
}