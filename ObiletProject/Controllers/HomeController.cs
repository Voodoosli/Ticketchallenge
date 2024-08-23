using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ObiletProject.Attiributes;
using ObiletProject.Extension.Helper;
using ObiletProject.Model.Enums;
using ObiletProject.Model.Models.BusLocations;
using ObiletProject.Model.Models.GetJourneys;
using ObiletProject.Model.Services;
using ObiletProject.Models;
using System.Diagnostics;

namespace ObiletProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IObiletApi _obiletApi;
        public HomeController(ILogger<HomeController> logger, IObiletApi obiletApi)
        {
            _obiletApi = obiletApi;
            _logger = logger;
        }
        [Auth]
        public IActionResult Index()
        {
            string originid;
            string destinationid;
            string date;
            if (Request.Cookies.TryGetValue("originid", out originid))
            {
                ViewBag.originid  = originid;
            }
            if (Request.Cookies.TryGetValue("destinationid", out destinationid))
            {
                ViewBag.destinationid = destinationid;
            }
            if (Request.Cookies.TryGetValue("date", out date))
            {
                ViewBag.date = date;
            }
             

            return View();
        }


        [Auth]
        [HttpGet("/journey")]
        public async Task<IActionResult> journey([FromQuery] string originid, [FromQuery] string destinationid, [FromQuery] string date)
        {
            var arr = Convert.ToDateTime(date);

            var cookieOptions = new CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddMinutes(30),
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict
            };

        



            if (originid == destinationid)
            {
                TempData["error"] = "Kalkış ve Varış Noktası aynı Olamaz";
                return RedirectToAction("Index");
            }

            if (string.IsNullOrEmpty(originid) || string.IsNullOrEmpty(destinationid) || string.IsNullOrEmpty(date))
            {
                TempData["error"] = "Formu Eksiksiz doldurunuz";
                return RedirectToAction("Index");
            }

            if (arr < DateTime.Now.Date)
            {
                TempData["error"] = "Geçmiş tarihe bilet alınamaz";
                return RedirectToAction("Index");
            }


            ViewBag.date = arr;
            UserSession userSession = new UserSession();
            var user = userSession.Get(HttpContext);
            var req = new JourneysRequest
            {
                devicesession = new Model.Models.GetJourneys.DeviceSession
                {
                    deviceid = user.data.deviceid,
                    sessionid = user.data.sessionid
                },
                language = "tr-TR",
                data = new JourneysReqData
                {
                    originid = Convert.ToInt32(originid),
                    destinationid = Convert.ToInt32(destinationid),
                    departuredate = arr
                }
            };


            var result = await _obiletApi.GetJourneys(req);
            if (result.Status == Status.Success)
            {
                ViewBag.origin = result.Data.data.FirstOrDefault().originlocation;
                ViewBag.destination = result.Data.data.FirstOrDefault().destinationlocation;


                Response.Cookies.Append("originid", originid+"-"+ result.Data.data.FirstOrDefault().originlocation, cookieOptions);
                Response.Cookies.Append("destinationid", destinationid+ "-"+ result.Data.data.FirstOrDefault().destinationlocation, cookieOptions);
                Response.Cookies.Append("date", date, cookieOptions);


                var sortedJourneys = result.Data.data.Select(j => j.journey)
                                    .OrderBy(j => j.departure.Hour )
                                    .ToList();

                return View(sortedJourneys);
            }
            else
            {
                TempData["error"] = "Kayıt bulunamadı";
                return RedirectToAction("Index");
            }


        }




        [HttpGet]
        public async Task<IActionResult> BusLocations([FromQuery]  string data)
        {
            UserSession userSession = new UserSession();
            var user = userSession.Get(HttpContext);
            var req = new BusLocationsRequest
            {
                data = data,
                date = DateTime.Now,
                language = "tr-TR",
                devicesession = new Model.Models.BusLocations.DeviceSession
                {
                    deviceid = user.data.deviceid,
                    sessionid = user.data.sessionid
                },
            };
            var result = await _obiletApi.GetBusLocations(req);
            if (result.Status == Status.Success)
            {
                return Json(result.Data.data);
            }
            return BadRequest();
        }



    }
}