using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_Hotel;
using DTO_Hotel;

namespace BUS_Hotel
{
    public class BUS_DangKi
    {
        DAL_DangKi dalHotel = new DAL_DangKi();
        public bool themDangKi(DTO_DangKi dk)
        {
            return dalHotel.themDangKi(dk);
        }

        public bool DangNhap(DTO_DangKi dn)
        {
            return dalHotel.DangNhap(dn);
        }
    }
}
