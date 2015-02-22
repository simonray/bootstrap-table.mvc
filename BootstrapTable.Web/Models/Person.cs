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
        [Display(Order=1, Name = "First")] //<--- set custom title
        public string FirstName { get; set; }
        [Display(Order=2, Name = "Last")]
        public string LastName { get; set; }
        [Display(Order = 0)] //<--- specify order
        public int Id { get; set; }
        public string Email { get; set; }
        [Display(AutoGenerateField = false)]
        public DateTime BirthDate { get; set; }
        public string DateOfBirth { get { return BirthDate.ToShortDateString(); } } //<--- title split camel-case
        public string Location { get; set; }

        [HiddenInput(DisplayValue = false)] //<--- ignore field (method 1)
        public string HiddenField1 { get; set; }
        [Display(AutoGenerateField = false)] //<--- ignore field (method 2)
        public string HiddenField2 { get; set; }
    }
}