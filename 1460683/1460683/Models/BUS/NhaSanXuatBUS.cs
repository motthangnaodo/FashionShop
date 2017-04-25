using FashionShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1460683.Models.BUS
{
    public class NhaSanXuatBUS
    {
        public static IEnumerable<NhaSanXuat> DanhSach()
        {
            var db = new FashionShopConnectionDB();
            return db.Query<NhaSanXuat>("Select * from NhaSanXuat where TinhTrang = 1");
        }
        public static IEnumerable<SanPham> ChiTiet(String id)
        {
            var db = new FashionShopConnectionDB();
            return db.Query<SanPham>("Select * from SanPham where MaNSX = '"+id+"'");
        }
        public static void ThemNSX(NhaSanXuat a)
        {
            var db =new FashionShopConnectionDB();
            db.Insert(a);
        }
    }
}