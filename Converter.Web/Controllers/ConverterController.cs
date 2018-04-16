using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Converter.Business.Class;
using Converter.Web.Models;

namespace Converter.Web.Controllers
{
    public class ConverterController : Controller
    {
        // GET: Converters
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: Liters / Gallons
        public ActionResult LitersToGallons()
        {
            LitGalViewModel model = new LitGalViewModel();

            return View(model);
        }

        // GET: Pounds / Kilograms
        public ActionResult PoundsToKilograms()
        {
            LbsKilViewModel model = new LbsKilViewModel();

            return View(model);
        }

        // GET: Farenheit / Celsius
        public ActionResult FarenheitToCelsius()
        {
            FarCelViewModel model = new FarCelViewModel();

            return View(model);
        }

        //GET: Error

        public ActionResult Error()
        {

            return View();
        }

        // POST: Display Farenheit / Celsius Result

        [HttpPost]
        public ViewResult FarenheitToCelsius(FarCelViewModel model)
        {
            try
            {
                Farenheit2Celsius temperature = new Farenheit2Celsius();
                model.Result = temperature.Convert(model.Choice, model.Temperature);
                ModelState.Clear();

                return View(model);
            }
            catch (InvalidCastException ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Converter", "Error"));
            }
            //This catch block will catch other types of unhandled exceptions
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Converter", "Error"));
            }

            //return View();  //Calls view=ActionMethod name by default
            //return View("myViewName"); //Calls "MyViewName" regardless
            //return View("myViewName", MyViewModel);  //Calls another view
            //return View(myViewModel); //Calls view=ActionMethod with another model 
        }

        // POST: Display Liters / Gallons Result

        [HttpPost]
        public ViewResult LitersToGallons(LitGalViewModel model)
        {
            try
            {
                Liters2Gallons measurement = new Liters2Gallons();
                model.Result = measurement.Convert(model.Choice, model.Measurement);
                ModelState.Clear();

                return View(model);
            }
            catch (InvalidCastException ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Converter", "Error"));
            }
            //This catch block will catch other types of unhandled exceptions
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Converter", "Error"));
            }
        }

        // POST: Display Pounds / Kilograms Result

        [HttpPost]
        public ViewResult PoundsToKilograms(LbsKilViewModel model)
        {
            try
            {
                Pounds2Kilograms measurement = new Pounds2Kilograms();
                model.Result = measurement.Convert(model.Choice, model.Measurement);
                ModelState.Clear();

                return View(model);
            }
            catch (InvalidCastException ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Converter", "Error"));
            }
            //This catch block will catch other types of unhandled exceptions
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Converter", "Error"));
            }
        }
    }
}