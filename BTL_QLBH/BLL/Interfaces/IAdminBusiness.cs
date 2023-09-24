using System;
using System.Collections.Generic;
using System.Text;
using BTL_QLBH.Models;

namespace BTL_QLBH.BLL
{

    public partial interface IAdminBusiness
    {
        bool AddAmin(AdminModel model);
        bool UpdateAdmin(AdminModel model);
        AdminModel GetDatabyID(string id);
        bool DeleteAdmin(string id);
        //List<AdminModel> Search(int pageIndex, int pageSize, out long total, string hoten, string diachi);
    }
}
