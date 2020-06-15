﻿using PropertyTaxCollectionCMS.Bll.ViewModels;
using PropertyTaxCollectionCMS.Bll.ViewModels.Admin;
using PropertyTaxCollectionCMS.Bll.ViewModels.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PropertyTaxCollectionCMS.Bll.Repository.Repository
{
    public interface IRepository
    {
        #region Common
        DashBoardVM DashBoardDetails();
        List<SelectListItem> GetStateList();
        List<SelectListItem> GetTehsilList();
        List<SelectListItem> GetDistrictList();
        //List<SelectListItem> GetLanguageList();
        #endregion
        List<EmployeeVM> getEmployeeDetails();
        Result EmployeeSave(EmployeeVM _Employee);
        EmployeeVM getEmployeeDetailsByID(int q);
        Result ClientSave(ClientVM _client);
        List<ClientVM> getClientDetails();
        ClientVM getClientDetailsByID(int q);
        List<DashBoardVM> getAttendenceDetailsOnMap();
        List<AttendanceDetailsVM> getAttendenceDetails();
        List<TaxReceiptDetailsVM> getTaxReceiptDetails(int q);
        EmployeeVM Login(EmployeeVM _userinfo);
        AppDetailsVM GetApplicationDetails(int AppId);
    }
}