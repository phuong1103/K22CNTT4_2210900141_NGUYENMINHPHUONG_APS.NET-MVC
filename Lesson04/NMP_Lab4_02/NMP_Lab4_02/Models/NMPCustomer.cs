﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NMP_Lab4_02.Models
{
    public class NMPCustomer
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Balance { get; set; }
    }
}