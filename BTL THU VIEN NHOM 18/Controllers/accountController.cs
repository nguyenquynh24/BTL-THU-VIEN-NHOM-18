using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BTL_THU_VIEN_NHOM_18.Models;
namespace BTL_THU_VIEN_NHOM_18.Controllers
{
        public class AccountController : Controller
        {
            DBConnect db = new DBConnect();
            // GET: Account
            public ActionResult Index()
            {
                return View();
            }
            public ActionResult Create()
            {
                //ViewBag.listRole = db.Roles.ToList();
                return View();
            }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(TAIKHOAN acc)
        {
            if (ModelState.IsValid)
            {
                var check = db.tAIKHOANs.FirstOrDefault(s => s.Email == acc.Email);
                if (check == null)
                { //mã hóa mật khẩu trước khi lưu vào db
                    acc.Password = GetMDS(acc.Password);               
                    db.tAIKHOANs.Add(acc);
                    db.SaveChanges();
                    return RedirectToAction("login", "Account");
                }
                else
                {
                    ViewBag.error = "Email already exists";
                    return View();
                }
            }
            return View(acc);
        }
        private string GetMDS(string password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public ActionResult Logout()
            {
                FormsAuthentication.SignOut();
                Session["idUser"] = null;
                return RedirectToAction("login", "Account");
            }
            [AllowAnonymous]
            public ActionResult Login(String returnUrl)
            {
                if (CheckSession() == 1)
                {
                    return RedirectToAction("Index", "Home", new { Areas = "Admins" });
                }
                else if (CheckSession() == 2)
                {
                    return RedirectToAction("Index", "Home", new { Areas = "Lectures" });
                }
                ViewBag.ReturnUrl = returnUrl;
                return View();
            }
            [AllowAnonymous]
            [HttpPost]
            public ActionResult Login(TAIKHOAN acc, string returnUrl)
            {
           
                try
                {   //check du lieu trong model, thoa man cac yeu cau rang buoc thif no moi thuc hien cac buoc tiep theo
                    if (!string.IsNullOrEmpty(acc.Email) && !string.IsNullOrEmpty(acc.Password))
                    
                    {
                        using (var db = new DBConnect())
                        {
                            var passToMD5 = GetMDS(acc.Password);
                            //so sanh du lieu acc nhap vao vs du lieu trong database
                            var user = db.tAIKHOANs.Where(m => m.Email==acc.Email && m.Password==passToMD5).FirstOrDefault();
                            if (user!=null)
                            {
                                FormsAuthentication.SetAuthCookie(acc.Email, false);
                                Session["idUser"] = user.taikhoan;
                                Session["roleUser"] = acc.roleID;
                                Response.Cookies.Add(new HttpCookie("userCookie", acc.Email));
                                Response.Cookies.Add(new HttpCookie("roleCookie", acc.roleID));
                                return RedirectToLocal(returnUrl);
                            }
                            ModelState.AddModelError("", "Thông tin đăng nhập chưa chính xác");
                        }
                    }
                    ModelState.AddModelError("", "Username and password is required.");
                }
                catch(Exception e)
                {

                    ModelState.AddModelError("", e.Message+e.StackTrace);
                }
                return View(acc);
            }
            private ActionResult RedirectToLocal(string returnUrl)
            {
                if (string.IsNullOrEmpty(returnUrl) || returnUrl == "/")
                    if (CheckSession() == 1)
                    {
                        return RedirectToAction("Index", "Home", new { Areas = "Admins" });
                    }
                    else if (CheckSession() == 2)
                    {
                        return RedirectToAction("Index", "Home", new { Areas = "Lectures" });
                    }
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            private int CheckSession()
            {
                using (var db = new DBConnect())
                {
                    var user = HttpContext.Session["iduser"];
                    if (user != null)
                    {
                        var Role = db.tAIKHOANs.Where(t=>t.taikhoan==(int)user).FirstOrDefault().roleID;
                        if (Role != null)
                        {
                            if (Role.ToString() == "Admin")
                            {
                                return 1;
                            }
                            else if (Role.ToString() == "Lecture")
                            {
                                return 2;
                            }
                        }
                    }
                }
                return 0;
            }
        }
    }