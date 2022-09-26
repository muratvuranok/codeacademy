using Microsoft.AspNetCore.Mvc;

namespace StateManagement.Cookie_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private const string COOKIE_SURVEY_KEY = "survey";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var cookie = Request.Cookies[COOKIE_SURVEY_KEY];
            return View(viewName: nameof(Index), model: cookie);
        }




        [HttpPost]
        public IActionResult Index(string survey)
        {

            //CookieOptions options = new CookieOptions();
            //options.Expires = DateTime.Now.AddMilliseconds(30);
            //Response.Cookies.Append(COOKIE_SURVEY_KEY, survey, options);


            Response.Cookies.Append(COOKIE_SURVEY_KEY, survey, new CookieOptions
            {
                Expires = DateTime.Now.AddYears(30)
            });

            //return RedirectToAction(nameof(Index));
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Clear()
        {
            Response.Cookies.Append(COOKIE_SURVEY_KEY, "", new CookieOptions
            {
                Expires = DateTime.Now.AddSeconds(-1)
            });
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(string id)
        {
            // id = COOKIE_SURVEY_KEY


            Response.Cookies.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}