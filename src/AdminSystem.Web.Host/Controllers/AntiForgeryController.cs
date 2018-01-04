using Microsoft.AspNetCore.Antiforgery;
using AdminSystem.Controllers;

namespace AdminSystem.Web.Host.Controllers
{
    public class AntiForgeryController : AdminSystemControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
