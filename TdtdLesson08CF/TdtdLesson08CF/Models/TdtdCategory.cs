using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TdtdLesson08CF.Models
{
    public class TdtdCategory
    {
        [Key]
        public int TdtdCategoryId { get; set; }
        public string TdtdCategoryName { get; set; }

        //tao moi quan he
        public virtual ICollection<TdtdBook> Books { get; set; }

    }
}