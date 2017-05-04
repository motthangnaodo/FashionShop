using _1460683.Models.BUS;
using FashionShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1460683.Areas.Admin.Controllers
{
    public class LSPController : Controller
    {
        [Authorize(Roles ="Admin")]
        // GET: Admin/LoaiSanPham
        public ActionResult Index()
        {
            var db = LoaiSanPhamBUS.DanhSachAdmin();
            return View(db);
        }

        // GET: Admin/LoaiSanPham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/LoaiSanPham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiSanPham/Create
        [HttpPost]
        public ActionResult Create(LoaiSanPham lsp)
        {
            try
            {
                // TODO: Add insert logic here
                LoaiSanPhamBUS.CreateLSP(lsp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/LoaiSanPham/Edit/5
        public ActionResult Edit(String id)
        {
            var db = LoaiSanPhamBUS.ChiTietAdmin(id);
            return View(db);
        }

        // POST: Admin/LoaiSanPham/Edit/5
        [HttpPost]
        public ActionResult Edit(String id, LoaiSanPham lsp)
        {
            try
            {
                // TODO: Add update logic here
                LoaiSanPhamBUS.UpdateLSP(id, lsp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/LoaiSanPham/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        public ActionResult XoaTamThoi(String id)
        {
            return View(LoaiSanPhamBUS.ChiTietAdmin(id));
        }

        // POST: Admin/LoaiSanPham/Delete/5
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
        public ActionResult XoaTamThoi(String id, LoaiSanPham lsp)
        {
            // TODO: Add delete logic here
            LoaiSanPhamBUS.XoaTTLSP(id, lsp);
            return RedirectToAction("Index");

        }
    }
}
