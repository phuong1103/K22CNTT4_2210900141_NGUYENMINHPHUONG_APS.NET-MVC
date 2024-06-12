using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NmpLesson06CF.Models
{
    public class NmpCategory
    {
        public int NmpId { get; set; }
        public string NmpCategoryName { get; set; }

        //Thuộc tính quan hệ 
        public virtual ICollection<NmpBook> NmpBooks { get; set; } 
    }
}