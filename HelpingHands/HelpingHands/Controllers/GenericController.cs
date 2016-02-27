using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlCoApp.Controllers
{
    public class GenericController : Controller
    {
        //
        // GET: /Food/
        public ActionResult Index()
        {
            // Populate revisions
            string html = "<ul>";

            
                html += "<li>" + "Do you need food today? Call:"
                            + "<br/>(800) 870-FOOD (3663) or"
                            + "<br/>(510) 635-3663"
                            + "<br/>Hours of operation: Monday – Friday, 9 a.m. – 4 p.m. (Alameda County only)" + "</li>";
            

            html += "</ul>";

            return Content(html, "text/html");
            //return Content("Do you need food today? Call:"
            //                + "<br/>(800) 870-FOOD (3663) or"
            //                + "<br/>(510) 635-3663"
            //                + "<br/>Hours of operation: Monday – Friday, 9 a.m. – 4 p.m. (Alameda County only)");
            //return View();
        }
        public ActionResult Under()
        {
            // Populate revisions
            string html = "<ul>";


            html += "<li>" + "This fucntionality:"
                        + "<br/>is under construction."
                        + "<br/>More information, please call us at (510) 635-3663"
                        + "<br/>Hours of operation: Monday – Friday, 9 a.m. – 4 p.m. (Alameda County only)" + "</li>";


            html += "</ul>";

            return Content(html, "text/html");
            //return Content("Do you need food today? Call:"
            //                + "<br/>(800) 870-FOOD (3663) or"
            //                + "<br/>(510) 635-3663"
            //                + "<br/>Hours of operation: Monday – Friday, 9 a.m. – 4 p.m. (Alameda County only)");
            //return View();
        }
    }
}