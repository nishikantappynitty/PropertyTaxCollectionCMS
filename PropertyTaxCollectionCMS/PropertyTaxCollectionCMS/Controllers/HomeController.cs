using PropertyTaxCollectionCMS.Bll.Repository.Repository;
using PropertyTaxCollectionCMS.Bll.ViewModels;
using PropertyTaxCollectionCMS.Models.SessionHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PropertyTaxCollectionCMS.Controllers
{
    public class HomeController : Controller
    {

        IRepository Repository;
        public HomeController()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                Repository = new Repository();
            }
            else
                Redirect("/Account/Login");
        }
        public ActionResult Index()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                DashBoardVM _DashBoardVM = new DashBoardVM();
                _DashBoardVM = Repository.DashBoardDetails();
                return View(_DashBoardVM);
            }
            else
            {
                return Redirect("/Account/Login");
            }
        }

        public ActionResult UserLocationList()
        {
            if (SessionHandler.Current.AppId != 0)
            {
                List<DashBoardVM> _DashBoardVM = new List<DashBoardVM>();
                _DashBoardVM = Repository.getAttendenceDetailsOnMap();
                //return View(_DashBoardVM);
                var jsonResult = Json(_DashBoardVM, JsonRequestBehavior.AllowGet);
                jsonResult.MaxJsonLength = int.MaxValue;
                return jsonResult;
            }
            else
            {
                return Redirect("/Account/Login");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
              
    }
}