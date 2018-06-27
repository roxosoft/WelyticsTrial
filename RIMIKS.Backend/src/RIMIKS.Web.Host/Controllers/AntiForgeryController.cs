using Microsoft.AspNetCore.Antiforgery;
using RIMIKS.Controllers;

namespace RIMIKS.Web.Host.Controllers
{
    public class AntiForgeryController : RIMIKSControllerBase
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
