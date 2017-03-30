using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace SimpleChat.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<SimpleChat.Client.Models.Settings> _settings;

        public HomeController(IOptions<SimpleChat.Client.Models.Settings> settings)
        {
            _settings = settings;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["MessagesApiUrl"] = _settings.Value.MessagesApiUrl;
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
