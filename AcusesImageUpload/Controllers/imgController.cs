using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcusesImageUpload.Controllers
{
    public class imgController : Controller
    {
        // GET: img
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}