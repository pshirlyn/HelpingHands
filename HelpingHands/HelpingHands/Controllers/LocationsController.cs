using AlCoApp.Helpers;
using AlCoApp.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AlCoApp.Controllers
{
    public class LocationsController : Controller
    {
        //
        // GET: /Locations/
        //public ActionResult MediCal()
        //{
        //    //return View();
        //    CommonHelper.MediCalRESTService loc = new CommonHelper.MediCalRESTService();
        //    return View(loc.GetLoctionssAsync());
        //}
        public ActionResult MediCal(string CityName)
        {
            CommonHelper.MediCalRESTService loc = new CommonHelper.MediCalRESTService();
            if (!string.IsNullOrEmpty(CityName))
                return View(loc.GetLoctionssAsync().FindAll(x => x.City.Equals(CityName)));
            else
                return View(loc.GetLoctionssAsync());
        }

        public ActionResult SSAOffice()
        {
            //return View();
            CommonHelper.SSAOfficeRESTService loc = new CommonHelper.SSAOfficeRESTService();
            return View(loc.GetLoctionssAsync());
        }

        public JsonResult GetSSAOffice()
        {
            return Json((new CommonHelper.SSAOfficeRESTService()).GetLoctionssAsync().ToArray());
        }
    }
}