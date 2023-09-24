
using DAL.Helper;
using WebApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace WebApplication2.DAL
{
    public class KhachHangRepository
    {
        private readonly IConfiguration _configuration;

        public KhachHangRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool AddCustomers(string KhachHangID, string HoTenKH, string DiaChiKH, string EmailKH, string SdtKH)
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string sql = "INSERT INTO KhachHang (KhachHangID, HoTenKH, DiaChiKH, EmailKH, SdtKH) VALUES (@KhachHangID, @HoTenKH, @DiaChiKH, @EmailKH, @SdtKH)";

                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@KhachHangID", KhachHangID);
                command.Parameters.AddWithValue("@HoTenKH", HoTenKH);
                command.Parameters.AddWithValue("@DiaChiKH", DiaChiKH);
                command.Parameters.AddWithValue("@EmailKH", EmailKH);
                command.Parameters.AddWithValue("@SdtKH", SdtKH);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true; // Thêm thành công
                }
                else
                {
                    return false; // Không có hàng nào được thêm
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi ở đây, ví dụ: ghi log hoặc trả về thông báo lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false; // Không thêm được do có lỗi
            }
        }

    }
}
