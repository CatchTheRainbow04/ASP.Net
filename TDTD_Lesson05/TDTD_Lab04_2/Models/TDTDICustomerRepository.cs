using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDTD_Lab04_2.Models
{
    internal interface TDTDICustomerRepository
    {
        //khai báo phương thức lấy danh sách khách hàng
        IList<TDTDCustomer> GetCustomers();
        //khai báo phương thức lấy khách hàng
        TDTDCustomer GetCustomer(string customerId);
        //khai báo phương thức thêm khách hàng
        void AddCustomer(TDTDCustomer cus);
        //khai báo phương thức cập nhật khách hàng
        void UpdateCustomer(TDTDCustomer cus);
        //khai báo phương thức tìm kiếm khách hàng
        IList<TDTDCustomer> SearchCustomer(string name);
        //khai báo phương thức xóa khách hàng
        void DeleteCustomer(TDTDCustomer cus);
    }
}
