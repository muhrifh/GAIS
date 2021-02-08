﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using GAIS.Models;

namespace GAIS.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string npk, string password)
        {
            if (ModelState.IsValid)
            {
                if (npk.Equals("sa") && password.Equals("1234"))
                {
                    this.Session["NPK"] = "0120210000";
                    this.Session["NamaUser"] = "SA";
                    this.Session["Role"] = "Administrator";
                    this.Session["isLogged"] = true;

                    return RedirectToAction("Admin", "Dashboard");
                }
                else
                {
                    using (GAISEntities entities = new GAISEntities())
                    {
                        var obj = entities.Karyawans.Where(x => x.Password == password && x.NPK == npk).FirstOrDefault();
                        if (obj == null)
                        {
                            ViewBag.Type = "danger";
                            ViewBag.Validasi = "Username or password is wrong";
                            return View();
                        }
                        else
                        {
                            this.Session["NPK"] = obj.NPK;
                            this.Session["NamaUser"] = obj.NamaKaryawan;
                            this.Session["Role"] = obj.Role.NamaRole;
                            this.Session["isLogged"] = true;

                            return RedirectToAction("User", "Dashboard");

                            // disini di cek rolenya buat pindah2 halaman
                        }
                    }
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult Vendor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Vendor(int id, string password)
        {
            if (ModelState.IsValid)
            {
                using (GAISEntities entities = new GAISEntities())
                {
                    var obj = entities.Vendors.Where(x => x.ID == id && x.Email == password).FirstOrDefault();
                    if (obj == null)
                    {
                        ViewBag.Type = "danger";
                        ViewBag.Validasi = "Username or password is wrong";
                        return View();
                    }
                    else
                    {
                        this.Session["ID_Vendor"] = obj.ID;
                        this.Session["Nama_Vendor"] = obj.NamaVendor;
                        this.Session["Email_Vendor"] = obj.Email;
                        this.Session["isLogged"] = true;

                        return RedirectToAction("Pemesanan", "Pengajuan");

                        // disini di cek rolenya buat pindah2 halaman
                    }
                }
            }

            return View();
        }

        public ActionResult Logout()
        {
            this.Session["NPK"] = null;
            this.Session["NamaUser"] = null;
            this.Session["Role"] = null;
            this.Session["isLogged"] = null;

            ViewBag.Type = "success";
            ViewBag.Validasi = "You have been logged out!";

            return View("Index");
        }
    }
}