using System.Web.Mvc;

namespace BTL_THU_VIEN_NHOM_18.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new [] { " BTL_THU_VIEN_NHOM_18.Areas.admin.Controllers " }
            );
        }
    }
}