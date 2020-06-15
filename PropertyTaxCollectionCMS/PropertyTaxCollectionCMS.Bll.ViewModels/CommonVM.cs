using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PropertyTaxCollectionCMS.Bll.ViewModels
{
    public class CommonVM
    {
        public List<SelectListItem> StateList { get; set; }
        public List<SelectListItem> TehsilList { get; set; }
        public List<SelectListItem> DistrictList { get; set; }
        public List<SelectListItem> LanguageList { get; set; }
    }
}
