using PropertyTaxCollectionCMS.Bll.Repository.Repository;
using PropertyTaxCollectionCMS.Bll.ViewModels;
using PropertyTaxCollectionCMS.Models.SessionHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PropertyTaxCollectionCMS.Controllers.Dashboard
{
    public class DashboardController : Controller
    {

        IRepository Repository;
        public DashboardController()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                Repository = new Repository();
            }
            else
                Redirect("/Account/Login");
        }
        // GET: Dashboard
        [HttpGet]
        public ActionResult AttendenceDetailsList()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                return View();
            }
            else
            {
                return Redirect("/Account/Login");
            }
        }

        [HttpGet]
        public JsonResult getAttendenceDetails()
        {
            var griddata = Repository.getAttendenceDetails();
            return Json(new { data = griddata }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TaxReceiptDetailsList()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                return View();
            }
            else
            {
                return Redirect("/Account/Login");
            }
        }

        public ActionResult TaxPaymentDetailsList()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                return View();
            }
            else
            {
                return Redirect("/Account/Login");
            }
        }

        public ActionResult TaxReminderDetailsList()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                return View();
            }
            else
            {
                return Redirect("/Account/Login");
            }
        }

        [HttpGet]
        public JsonResult getTaxReceiptDetails(int q = -1)
        {
            var griddata = Repository.getTaxReceiptDetails(q);
            return Json(new { data = griddata }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getTaxPaymentDetails(int q = -1)
        {
            var griddata = Repository.getTaxReceiptDetails(q);
            return Json(new { data = griddata }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getTaxReminderDetails(int q = -1)
        {
            var griddata = Repository.getTaxReminderDetails(q);
            return Json(new { data = griddata }, JsonRequestBehavior.AllowGet);
        }
    }
}