using DAL.Helper;
using BTL_QLBH.DAL.Interfaces;
using BTL_QLBH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BTL_QLBH.DAL
{
    public class AdminRepository : IAdminRepository
    {
        private IDatabaseHelper _dbHelper;

        public AdminRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public bool AddAdmin(AdminModel model)
        {
            // Triển khai logic thêm admin vào cơ sở dữ liệu ở đây
            return true; // Hoặc trả về giá trị tùy thuộc vào kết quả của phương thức
        }

        public bool UpdateAdmin(AdminModel model)
        {
            // Triển khai logic cập nhật thông tin admin ở đây
            return true; // Hoặc trả về giá trị tùy thuộc vào kết quả của phương thức
        }

        public AdminModel GetDatabyID(string id)
        {
            // Triển khai logic lấy thông tin admin theo ID ở đây
            return new AdminModel(); // Hoặc trả về đối tượng AdminModel tùy thuộc vào kết quả của phương thức
        }

        public bool DeleteAdmin(string id)
        {
            // Triển khai logic xóa admin ở đây
            return true; // Hoặc trả về giá trị tùy thuộc vào kết quả của phương thức
        }

        //public List<AdminModel> SearchAdmin(int pageIndex, int pageSize, out long total, string hoten, string diachi)
        //{
        //    // Triển khai logic tìm kiếm admin ở đây
        //    total = 0; // Cập nhật giá trị total
        //    return new List<AdminModel>(); // Hoặc trả về danh sách AdminModel tùy thuộc vào kết quả của phương thức
        //}
    }
}
