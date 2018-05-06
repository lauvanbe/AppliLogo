using System.Web.Mvc;
using AppliLogo.Models;

namespace AppliLogo.Controllers
{
    public class LogopedeController : Controller
    {
        // GET: Logopede
        public ActionResult VueLogo()
        {
            var logo = new Logopede() { NomLogo = "AngeGardien", PrenomLogo = "Josephine" };

            return View(logo);
        }
    }
}