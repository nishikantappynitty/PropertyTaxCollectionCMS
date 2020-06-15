using PropertyTaxCollectionCMS.Bll.Repository.Repository;
using PropertyTaxCollectionCMS.Bll.ViewModels.Admin;
using PropertyTaxCollectionCMS.Bll.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PropertyTaxCollectionCMS.Models.SessionHandler;

namespace PropertyTaxCollectionCMS.Controllers.Admin
{
    public class AdminController : Controller
    {

        IRepository Repository;

        public AdminController()
        {
            //if (SessionHandler.Current.AppId != 0)
            {
                Repository = new Repository();
            }
            //else
            //    Redirect("/Account/Login");
        }

        // GET: Admin
        [HttpGet]
        public ActionResult Client(int q=-1)
        {
            if (SessionHandler.Current.AppId != 0)
            {
                var viewModel = new ClientVM();
                viewModel = Repository.getClientDetailsByID(q);

                viewModel.StateList = Repository.GetStateList();
                viewModel.DistrictList = Repository.GetDistrictList();
                viewModel.TehsilList = Repository.GetTehsilList();
                
                //var language = new List<SelectListItem>();
                //SelectListItem itemLanguage = new SelectListItem() { Text = "Select Language", Value = "0" };
                //language = dbMain.LanguageInfoes.ToList()
                //    .Select(x => new SelectListItem
                //    {
                //        Text = x.Language,
                //        Value = x.Id.ToString()
                //    }).OrderBy(t => t.Text).ToList();
                //language.Insert(0, itemLanguage);
                //viewModel.LanguageList = language;

                ViewBag.ReferenceID = DateTime.Now.ToString("yyyyddmmhhmmss");

                return View(viewModel);
            }
            else
            {
                return Redirect("/Account/Login");
            }
        }

        [HttpPost]
        public ActionResult Client(ClientVM client)
        {
            if (SessionHandler.Current.AppId != 0)
            {
                Result Result = new Result();
                Result = Repository.ClientSave(client);
                ViewBag.Message = Result.message;

                return Redirect("/Admin/ClientList");
            }
            else
            {
                return Redirect("/Account/Login");
            }
        }

        public ActionResult ClientList()
        {
            return View();
        }


        [HttpGet]
        public JsonResult getClientDetails()
        {
            var griddata = Repository.getClientDetails();
            return Json(new { data = griddata }, JsonRequestBehavior.AllowGet);
        }

    }
}