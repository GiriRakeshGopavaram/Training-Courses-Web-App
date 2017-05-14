using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTCData;

namespace PTC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TrainingProductViewModel viewModel = new TrainingProductViewModel();
            
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(TrainingProductViewModel viewModel)
        {
            viewModel.IsValid = ModelState.IsValid;
            viewModel.HandleEvent();
            if (viewModel.IsValid)
            {
                ModelState.Clear();
            }
            return View(viewModel);


        }
    }
}