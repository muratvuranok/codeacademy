using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace StateManagement.Session_.Controllers
{
    public class SessionController : Controller
    {

        private readonly static string SESSION_KEY_NAME = "code";
        public SessionController() { }

        public IActionResult Index()
        {

            if (string.IsNullOrEmpty(HttpContext.Session.GetString(SESSION_KEY_NAME)))
            {
                HttpContext.Session.SetString(SESSION_KEY_NAME, "Session Value");
            }


            return Ok(new
            {
                Result = "Session'a Data Eklendi",
                StatusCode = HttpStatusCode.OK
            });
        }


        public IActionResult GetSessionData()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString(SESSION_KEY_NAME)))
            {
                var data = HttpContext.Session.GetString(SESSION_KEY_NAME);
                return Ok(new
                {
                    Result = data,
                    StatusCode = HttpStatusCode.OK,
                    SessionId = HttpContext.Session.Id
                });
            }
            return View(nameof(Index));
        }
    }
}
