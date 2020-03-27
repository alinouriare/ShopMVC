using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyShop.Models;
using CaptchaMvc.HtmlHelpers;
using System.Web.Security;
using System.Web.Mvc;
using MyEshop.Classes;

namespace MyShop.Controllers
{
    public class AccountController : Controller
    {
        MyEshopEntities database = new MyEshopEntities();
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                if (this.IsCaptchaValid("کد تصویر امنیتی وارد شده اشتباه است"))
                {
                    Users user = new Users()
                    {

                        UserName = register.username.Trim().ToLower(),
                        Password = register.pass,
                        Email = register.email.Trim().ToLower(),
                        RoleID = 2,
                        CreateDate = DateTime.Now,
                        ActiveCode = Guid.NewGuid().ToString().Replace("-", ""),
                        IsActive = false


                    };
                    database.Users.Add(user);
                    try
                    {
                        string body = PartialToStringClass.RenderPartialView("EmailSend", "ActiveUser", user);
                        SendEmailGmail.Send(user.Email, "لینک فعال سازی", body);
                    }
                    catch 
                    {

                        
                    }

                    database.SaveChanges();
                    return View("RegisterSuccess");
                }
                else
                {
                    ModelState.AddModelError("CaptchaInputText", "کد تصویر امنیتی وارد شده اشتباه است");
                    return View(register);
                }
              
            }

            return View(register);
        }


        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel login ,string ReturnUrl = "" )
        {
            if (ModelState.IsValid)
            {
                var Qlogin = database.Users.FirstOrDefault(u => u.UserName == login.username.Trim().ToLower() && u.Password == login.password);
                if (Qlogin!=null)
                {
                    if (Qlogin.IsActive)
                    {

                        FormsAuthentication.SetAuthCookie(login.username, login.Rememeber);
                        if (ReturnUrl != "")
                        {
                            return Redirect(ReturnUrl);
                        }
                       return  Redirect("/");
                    }
                    else
                    {
                        ModelState.AddModelError("username", "حساب کابری فوق غیر فعال است");
                    }
                }

                else
                {
                    ModelState.AddModelError("username", "کابر یافت نشد");
                }
            }

            return View();
        }

        public ActionResult SingOut()
        {


            FormsAuthentication.SignOut();
            return Redirect("/");
        }

        public ActionResult ActiveUser(string Active_Code)
        {
            var user = database.Users.FirstOrDefault(u => u.ActiveCode == Active_Code);
            if (user != null)
            {
                user.IsActive = true;
                user.ActiveCode = Guid.NewGuid().ToString().Replace(".", "");
                database.SaveChanges();
                ViewBag.Ok = true;
            }
            else
            {

                ViewBag.Ok = false;
            }
            return View();

        }
    }
}