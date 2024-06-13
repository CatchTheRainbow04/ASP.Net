using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TdtdLesson08CF.Models
{
    public class TdtdBook
    {
        public int TdtdBookId { get; set; }
        public string TdtdBookTitle { get; set; }
        public string TdtdAuthor { get; set; }
        public string TdtdYear { get; set; }
        public string TdtdPulisher { get; set; }
        public string TdtdPicture { get; set; }
        public int TdtdCategoryId { get; set; }

        //thuoc tinh quan he
        public virtual TdtdCategory TdtdCategory { get; set; }
    }
}