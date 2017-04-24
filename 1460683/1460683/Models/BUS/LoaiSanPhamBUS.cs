using FashionShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1460683.Models.BUS
{
    public class LoaiSanPhamBUS
    {
        public static IEnumerable<LoaiSanPham> DanhSach()
        {
            var db = new FashionShopConnectionDB();
            return db.Query<LoaiSanPham>("Select * from LoaiSanPham where TinhTrang = 1");
        }
        public static IEnumerable<SanPham> ChiTiet(String id)
        {
            var db = new FashionShopConnectionDB();
            return db.Query<SanPham>("Select * from SanPham where MaLoaiSanPham = '" + id+"'");
        }
    }
}