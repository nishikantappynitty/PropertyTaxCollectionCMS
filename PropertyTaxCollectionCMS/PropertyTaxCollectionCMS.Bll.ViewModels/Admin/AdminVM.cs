﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PropertyTaxCollectionCMS.Bll.ViewModels.Admin
{
    public class AdminVM
    {

    }

    public class ClientVM : CommonVM
    {
        public int AppId { get; set; }
        public string AppName { get; set; }
        public string AppName_mar { get; set; }
        public int State { get; set; }
        public string StateName { get; set; }
        public int Tehsil { get; set; }
        public string TehsilName { get; set; }
        public int District { get; set; }
        public string DistrictName { get; set; }
        public string EmailId { get; set; }
        public string website { get; set; }
        public string Android_GCM_pushNotification_Key { get; set; }
        public string baseImageUrlCMS { get; set; }
        public string baseImageUrl { get; set; }
        public string basePath { get; set; }
        public string Latitude { get; set; }
        public string Logitude { get; set; }
        public string AppVersion { get; set; }
        public bool ForceUpdate { get; set; }
        public bool IsActive { get; set; }
        public int LanguageId { get; set; }
        public string QrCode { get; set; }
        public string ReferenceID { get; set; }
        //public List<SelectListItem> LanguageList { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
