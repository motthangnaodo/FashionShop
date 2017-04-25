using _1460683.Models.BUS;
using FashionShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1460683.Areas.Admin.Controllers
{
    public class SPController : Controller
    {
        // GET: Admin/SanPham
        public ActionResult Index()
        {
            
            return View(ShopBUS.DanhSachAdmin());
        }

        // GET: Admin/SanPham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/SanPham/Create
        public ActionResult Create()
        {
            ViewBag.MaNSX = new SelectList(NhaSanXuatBUS.DanhSach(), "MaNSX", "TenNSX");
            return View();
        }

        // POST: Admin/SanPham/Create
        [HttpPost]
        public ActionResult Create(SanPham sp)
        {
            try
            {
                // TODO: Add insert logic here
                var hpf = HttpContext.Request.Files[0];
                if(hpf.ContentLength>0)
                {
                    string filename = sp.HinhChinh;
                    string fullPathWithFileName = "~/Asset/img/" + filename + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.HinhChinh = sp.TenSanPham + ".jpg";
                }

                ShopBUS.CreateSP(sp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/SanPham/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/SanPham/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/SanPham/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/SanPham/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
