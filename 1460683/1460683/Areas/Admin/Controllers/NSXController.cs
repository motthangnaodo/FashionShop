using _1460683.Models.BUS;
using FashionShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1460683.Areas.Admin.Controllers
{
    public class NSXController : Controller
    {
        [Authorize(Roles = "Admin")]
        // GET: Admin/NSX
        public ActionResult Index()
        {
            var ds = NhaSanXuatBUS.DanhSachAdmin();
            return View(ds);
        }

        // GET: Admin/NSX/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/NSX/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/NSX/Create
        [HttpPost]
        public ActionResult Create(NhaSanXuat a)
        {
            try
            {
                // TODO: Add insert logic here
                NhaSanXuatBUS.ThemNSX(a);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/NSX/Edit/5
        public ActionResult Edit( string id)
        {
            var db = NhaSanXuatBUS.ChiTietAdmin(id);
            return View(db);
        }

        // POST: Admin/NSX/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, NhaSanXuat nsx)
        {
            //try
            //{
                // TODO: Add update logic here
                NhaSanXuatBUS.UpdateNSX(id, nsx);
                return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: Admin/NSX/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        public ActionResult XoaTamThoi(String id)
        {
            return View(NhaSanXuatBUS.ChiTietAdmin(id));
        }

        // POST: Admin/NSX/Delete/5
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

        [HttpPost]
        public ActionResult XoaTamThoi(String id, NhaSanXuat nsx)
        {
                // TODO: Add delete logic here
                NhaSanXuatBUS.XoaTTNSX(id, nsx);
                return RedirectToAction("Index");

        }
    }
}
