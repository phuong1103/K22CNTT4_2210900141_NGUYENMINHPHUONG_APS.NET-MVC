using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NmpLesson06CF.Models
{
    public class NmpBook
    {
        public int NmpId { get; set; }
        public string NmopTitle { get; set; }
        public string NmpAuthor { get; set;  }
        public string NmpYear { get; set; }
        public string NmpPulisher { get; set; }
        public string NmpPicture { get; set; }
        public string NmpCategoryId { get; set; }
        // Thuộc tính quan hệ 
        public virtual NmpCategory NmpCategory { get; set; }    
    }
}