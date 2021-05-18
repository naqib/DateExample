using Microsoft.AspNetCore.Mvc;
using QM.Business.Repository.Interface;
using QM.UI.Mapper;
using QM.UI.Models;

namespace QM.UI.Controllers
{
    public class HomeController : Controller
    {
        protected readonly IDateRepository dateRepository;

        public HomeController(IDateRepository DateRepository)
        {
            dateRepository = DateRepository;
        }

        /// <summary>
        /// Represents the input form for Date1 and Date2
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post(DateDto dateDto) {
                if (ModelState.IsValid)
                {
                    var dateBo = DtoToBoHelper.DateDtoToBo(dateDto); // Converts Dto to Bo
                    var dateResult = dateRepository.GetDifference(dateBo.FirstDate, dateBo.SecondDate); // Strategy pattern calculates time diff
                    ViewBag.Result = $"The difference is ({dateResult}) day/s";
                }           

            return View("Index", dateDto);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
