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
        public static IEnumerable<SanPham> Top6New()
        {
            var db = new FashionShopConnectionDB();
            return db.Query<SanPham>("Select * from SanPham ORDER BY Ngay desc OFFSET 0 ROWS FETCH NEXT 3 ROWS ONLY");
        }
        public static IEnumerable<SanPham> Top3Hot()
        {
            var db = new FashionShopConnectionDB();
            return db.Query<SanPham>("Select * from SanPham ORDER BY SoLuongXem desc OFFSET 0 ROWS FETCH NEXT 3 ROWS ONLY");
        }
        ///// ADMIN
        public static IEnumerable<SanPham> DanhSachAdmin()
        {
            var db = new FashionShopConnectionDB();
            return db.Query<SanPham>("Select * from SanPham");
        }
        public static void CreateSP(SanPham sp)
        {
            var db = new FashionShopConnectionDB();
            db.Insert(sp);
        }
    }
}