using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FashionShopConnection;

namespace _1460683.Models.BUS
{
    public class ShopBUS
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new FashionShopConnectionDB();
            return db.Query<SanPham>("Select * from SanPham where TinhTrang = 1");
        }
        public static SanPham ChiTiet(String a)
        {
            var db = new FashionShopConnectionDB();
            return db.SingleOrDefault<SanPham>("Select * from SanPham where MaSanPham=@0",a);
        }
    }
}