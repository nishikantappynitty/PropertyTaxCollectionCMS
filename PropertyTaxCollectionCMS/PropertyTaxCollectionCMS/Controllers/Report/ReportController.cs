﻿using PropertyTaxCollectionCMS.Bll.Repository.Repository;
using PropertyTaxCollectionCMS.Models.SessionHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PropertyTaxCollectionCMS.Controllers.Report
{
    public class ReportController : Controller
    {
        IRepository Repository;
        public ReportController()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                Repository = new Repository();
            }
            else
                Redirect("/Account/Login");
        }

        // GET: Report
        public ActionResult AttendenceReport()
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
        public JsonResult getAttendenceReport(string fromDate, string toDate)
        {
            var griddata = Repository.getAttendenceReport(fromDate, toDate);
            return Json(new { data = griddata }, JsonRequestBehavior.AllowGet);
        }



        public ActionResult TaxReceiptReport()
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
        public JsonResult getTaxReceiptReport(string fromDate, string toDate, int q = -1)
        {
            int AppId = SessionHandler.Current.AppId;
            var griddata = Repository.getTaxReceiptReport(q, fromDate, toDate, AppId);
            return Json(new { data = griddata }, JsonRequestBehavior.AllowGet);
        }


        public ActionResult TaxPaymentReport()
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
        public JsonResult getTaxPaymentReport(string fromDate, string toDate, int q = -1)
        {
            var griddata = Repository.getTaxPaymentReport(q, fromDate, toDate);
            return Json(new { data = griddata }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TaxReminderReport()
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
        public JsonResult getTaxReminderReport(string fromDate, string toDate, int q = -1)
        {
            var griddata = Repository.getTaxReminderReport(q, fromDate, toDate);
            return Json(new { data = griddata }, JsonRequestBehavior.AllowGet);
        }
    }
}