using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace TDTD_Lesson07_1.Models
{
    public class TDTDStudent
    {
        [Key]
        [Required(ErrorMessage = "TDTD : Mã sinh viên không hợp lệ !")]
        [DisplayName("TDTD : Mã sinh viên")]
        public int TdtdId { get; set; }
        //
        [Required(ErrorMessage = "TDTD : Họ và tên là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Họ và tên không được dài quá 100 ký tự.")]
        [DisplayName("TDTD : Tên sinh viên ")]
        public string TdtdFullname { get; set; }
        //
        [Required(ErrorMessage = "TDTD : Email là bắt buộc.")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ.")]
        [DisplayName("TDTD : Email")]
        public string TdtdEmail { get; set; }
        //
        [Required(ErrorMessage = "TDTD : Mật khẩu là bắt buộc.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Mật khẩu phải có độ dài từ 6 đến 100 ký tự.")]
        [DisplayName("TDTD : Mật khẩu")]
        public string TdtdPassword { get; set; }
        //
        [Required(ErrorMessage = "TDTD : Số điện thoại là bắt buộc.")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
        [DisplayName("TDTD : Số điện thoại")]
        public string TdtdPhone { get; set; }
        //
        [Required(ErrorMessage = "TDTD : Năm sinh là bắt buộc.")]
        [Range(1900, 2100, ErrorMessage = "Năm sinh phải nằm trong khoảng từ 1900 đến 2100.")]
        [DisplayName("TDTD : Năm sinh")]
        public int TdtdYearOfBirth { get; set; }
    }
}