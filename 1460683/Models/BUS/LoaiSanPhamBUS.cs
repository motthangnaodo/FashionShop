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
        //Admin -------------
        public static IEnumerable<LoaiSanPham> DanhSachAdmin()
        {
            var db = new FashionShopConnectionDB();
            return db.Query<LoaiSanPham>("Select * from LoaiSanPham");
        }

        public static void CreateLSP(LoaiSanPham lsp)
        {
            var db = new FashionShopConnectionDB();
            db.Insert(lsp);
        }
        public static LoaiSanPham ChiTietAdmin(String a)
        {
            var db = new FashionShopConnectionDB();
            return db.SingleOrDefault<LoaiSanPham>("Select * from LoaiSanPham where MaLSP = '" + a + "'");
        }
        public static void UpdateLSP(String id, LoaiSanPham lsp)
        {
            var db = new FashionShopConnectionDB();
            string asd = "'" + id + "'";
            db.Update<LoaiSanPham>("set MaLSP=@0, TenLSP=@1, TinhTrang=@2 WHERE MaLSP=@3", lsp.MaLSP, lsp.TenLSP, lsp.TinhTrang, id);
        }
        public static void XoaTTLSP(String id, LoaiSanPham lsp)
        {
            var db = new FashionShopConnectionDB();
            db.Update<LoaiSanPham>("set TinhTrang=0 WHERE MaLSP=@0", id);
        }
    }
}