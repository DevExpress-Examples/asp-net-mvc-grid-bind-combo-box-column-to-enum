using ComboBoxColumnBoundToEnum.Models;
using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComboBoxColumnBoundToEnum.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            return PartialView("_GridViewPartial", OrderHelper.GetOrders());
        }
    }
}