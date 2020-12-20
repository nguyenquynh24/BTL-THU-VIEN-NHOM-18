using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using BTL_THU_VIEN_NHOM_18.Models;
using BTL_THU_VIEN_NHOM_18.Models.viewmodel;
using PagedList;

namespace BTL_THU_VIEN_NHOM_18.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private DBConnect _db = new DBConnect();
        // GET: Home
        public ActionResult Index(string Are)
        {
            if (Session["idUser"] != null)
            {
                if (checksession() == 1)
                {
                    ViewBag.role = "admin";
                    return View();
                }
                else if (checksession() == 2)
                {
                    ViewBag.role = "lectures";
                    return View();
                }
                // ViewBag.returnUrl = returnUrl;
                TempData["role"] = Are;
                return View();
            }
            else
            {
                return Redirect("/account/login");
            }
        }

        private int checksession()
        {
            using (var db = new DBConnect())
            {
                var userId = (int)HttpContext.Session["idUser"];
                var user = db.tAIKHOANs.Where(u => u.taikhoan == userId).FirstOrDefault(); return user.taikhoan;
            }
        }
        private DBConnect db = new DBConnect();
        public ActionResult DemoLinQ()
        {
            List<userviewmodel> query = (from sach in db.lOAISACHes
                                         join masach in db.sAChes
                                         on sach.maloaisach equals masach.maloaisach
                                         select new userviewmodel
                                         {
                                             tensach = masach.tensach,
                                             maloaisach = masach.maloaisach,
                                         }).ToList<userviewmodel>();
            return View(query);

        }
        public ActionResult DemoLinQ2()
        {
            List <docgiamuonsachviewmodel> query = (from dg in db.dOCGIAs
                                                   join sp in db.mUONSACHes
                                                   on dg.msdocgia equals sp.msdocgia
                                                   select new docgiamuonsachviewmodel
                                                   {
                                                       msdocgia = sp.msdocgia,
                                                       sophieumuon = sp.sophieumuon,
                                                   }).ToList<docgiamuonsachviewmodel>();
            return View(query);
        }
        public ViewResult PageList(int? page)

        {
            var pagesize = 10;
            var model = db.dOCGIAs.ToList();
            int pageNumber = page ?? 1;
            return View(model.ToPagedList(pageNumber,pagesize));
        }


    }
}
