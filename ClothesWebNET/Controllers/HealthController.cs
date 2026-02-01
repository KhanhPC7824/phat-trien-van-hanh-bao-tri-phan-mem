using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClothesWebNET.Models;

namespace ClothesWebNET.Controllers
{
    public class HealthController : Controller
    {
        private CLOTHESEntities db = new CLOTHESEntities();

        // GET: Health
        public ActionResult Index()
        {
            try
            {
                // Check Database Connection
                var count = db.Products.Count();
                return Content($"UP. Connected to DB. Products count: {count}");
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Content($"DOWN. Error: {ex.Message}");
            }
        }
    }
}
