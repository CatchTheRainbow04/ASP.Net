using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson06_1.Models
{
    public class TDTDSong
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Enter Song Name !")]
        [DisplayName("Tiêu đề")]
        public string TDTDTitle { get; set; }

        [Required(ErrorMessage ="Enter Author Name !")]
        [DisplayName("Nghệ sĩ")]
        public string TDTDAuthor { get; set; }

        [Required(ErrorMessage ="Enter Artist Name !")]
        [StringLength(100,MinimumLength = 2,ErrorMessage = "The artist's name must be more than 2 characters and less than 100 characters !")]
        [DisplayName("Tác giả")]

        public string TDTDArtist { get; set; }

        [Required(ErrorMessage ="Enter Year Release")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage = "The year release must include 4 digits !")]
        [Range(1900,2024,ErrorMessage = "The year release must be in the years [1900-2024]")]
        [DisplayName("Năm ra mắt")]
        public int TDTDYearRelease { get; set; }
    }
}