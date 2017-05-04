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
        public static IEnumerable<NhaSanXuat> DanhSachAdmin()
        {
            var db = new FashionShopConnectionDB();
            return db.Query<NhaSanXuat>("Select * from NhaSanXuat");
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
        public static NhaSanXuat ChiTietAdmin(String a)
        {
            var db = new FashionShopConnectionDB();
            return db.SingleOrDefault<NhaSanXuat>("Select * from NhaSanXuat where MaNSX = '" + a + "'");
        }
        public static void UpdateNSX(String id,NhaSanXuat nsx)
        {
            var db = new FashionShopConnectionDB();
            string asd = "'" + id + "'";
            db.Update<NhaSanXuat>("set MaNSX=@0, TenNSX=@1, TinhTrang=@2 WHERE MaNSX=@3", nsx.MaNSX, nsx.TenNSX,nsx.TinhTrang,id);
        }
        public static void XoaTTNSX(String id, NhaSanXuat nsx)
        {
            var db = new FashionShopConnectionDB();
            db.Update<NhaSanXuat>("set TinhTrang=0 WHERE MaNSX=@0",id);
        }
    }
}