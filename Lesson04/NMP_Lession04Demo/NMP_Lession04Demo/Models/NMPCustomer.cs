using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NMP_Lession04Demo.Models
{
    public class NMPCustomer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string YearOfBirth { get; set; }
    }
}