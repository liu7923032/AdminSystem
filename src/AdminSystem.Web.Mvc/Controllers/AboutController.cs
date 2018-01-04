using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AdminSystem.Controllers;

namespace AdminSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AdminSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
