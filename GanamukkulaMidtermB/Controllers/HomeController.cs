using GanamukkulaMidtermB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

//Raja Rajeshwari Ganamukkula
//700763633
namespace GanamukkulaMidtermB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }//end Index()

        [HttpPost]
        public IActionResult Index(ProjectModel model)
        {
            //check validation
            if(ModelState.IsValid)
            {
                //storing name and id in ViewBag
                ViewBag.Name = "Raja Rajeshwari Ganamukkula";
                ViewBag.Id = "700-76-3633";
                //calling the ProjectCostBreakdownCalculate() 
                model.ProjectCostBreakdownCalculate();
                return View("ProjectCostDetails", model);
            }
            return View(model);
        }//end Index(ProjectModel model)
    }//end HomeController
}//end namespace
