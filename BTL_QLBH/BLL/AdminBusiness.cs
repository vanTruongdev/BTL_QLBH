using System;
using System.Collections.Generic;
using System.Text;
using BTL_QLBH.Models;
namespace BTL_QLBH.BLL
{

    public class AdminBusiness : IAdminBusiness
    {
        private IAdminBusiness _res;
        public AdminBusiness(IAdminBusiness res)
        {
             _res = res;
        }
        public bool AddAmin(AdminModel model)
        {
            return _res.AddAmin(model);
        }

        public bool UpdateAdmin(AdminModel model)
        {
            return _res.UpdateAdmin(model);
        }

        public AdminModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }

        public bool DeleteAdmin(string id)
        {
            return _res.DeleteAdmin(id);
        }

    }

}
