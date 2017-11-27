using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator;

namespace CalculatorWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Calculator()
        {
            ViewBag.Message = "Electronic Color Code Calculator";
            ColorCodes colorCodes = new ColorCodes();

            Models.CalculatorViewModel viewModel = new Models.CalculatorViewModel();
            viewModel.ColorCodes = colorCodes.getColorCodes().Values;

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Calculator(Models.CalculatorViewModel viewModel)
        {

            ViewBag.Message = "Electronic Color Code Calculator";
            ColorCodes colorCodes = new ColorCodes();
            viewModel.ColorCodes = colorCodes.getColorCodes().Values;

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            else
            {
                IOhmValueCalculator calculator = new OhmValueCalcuator(new ColorCodes());
                OhmRange range = calculator.CalculateOhmValueRange(viewModel.SelectedAColor, viewModel.SelectedBColor, viewModel.SelectedCColor, viewModel.SelectedDColor);

                viewModel.OhmValueMin = range.MinValue;
                viewModel.OhmValueMax = range.MaxValue;

                return View(viewModel);
            }
        }
    }
}