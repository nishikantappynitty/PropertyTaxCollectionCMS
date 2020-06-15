$(document).ready(function () {

    $('#datatable').DataTable({
        "pageLength": 10,
        "ajax": {
            "url": "/Admin/getClientDetails/",
            "tye": "GET",
            "datatype": "json",
        },

        //"columnDefs":
        //[{
        //    "targets": [0],
        //    "visible": false,
        //    "searchable": false
        //}],

        "columns": [
                { "data": "AppId" },
                { "data": "AppName" },
                { "data": "StateName" },
                { "data": "TehsilName" },
                { "data": "DistrictName" },
                { "data": "AppVersion" },
                { "data": "ForceUpdate" },
                { "data": "IsActive" },
                { "render": function (data, type, full, meta) { return '<a  href="javascript:void(0)" onclick="Edit(' + full["AppId"] + ')" >Edit</a>'; }, "width": "10%" },
        ]
    });

});



function Edit(ID) {
    window.location.href = "/Admin/Client?q=" + ID;
}

