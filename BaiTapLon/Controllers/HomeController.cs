using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTapLon.Models;

namespace BaiTapLon.Controllers
{
    public class HomeController : Controller
    {
        Data db = new Data();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string Email, string Password)
        {
            if (ModelState.IsValid)
            {
                var user = db.tblUsers.Where(u => u.Email.Equals(Email) && u.Password.Equals(Password)).ToList();
                if (user.Count() > 0)
                {
                    //sử dụng Session: add Session
                    Session["HoTen"] = user.FirstOrDefault().Name;
                    Session["Email"] = user.FirstOrDefault().Email;
                    Session["idUser"] = user.FirstOrDefault().Userid;

                    bool status = user.FirstOrDefault().Status;

                    if (status == true)
                    {
                        return RedirectToAction("Index", "Home");
                    }    
                    else
                    {
                        return RedirectToAction("Index", "Home");

                    }
                }
                else
                {
                    ViewBag.error = "Đăng nhập không thành công!";
                }
            }
            return View();
        }

    }
}