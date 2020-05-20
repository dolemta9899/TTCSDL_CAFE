using Models.Dao;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTCSDL_CAFE.Areas.Admin.Models;
using TTCSDL_CAFE.Common;

namespace TTCSDL_CAFE.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login(LoginModels loginModel)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(loginModel.UserName, loginModel.PassWord);
                if (result)
                {
                    var user = dao.GetbyID(loginModel.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UsernameTK;
                    userSession.UserID = user.MaTK;
                    
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "HomeAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Login fail");
                }
            }
            return View("Index");
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(TaiKhoan user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                string id = dao.Insert(user);
                if (id != null)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            else
            {
                ModelState.AddModelError("", "Add succsessfull");
            }
            return View("Index");
        }
    }
}