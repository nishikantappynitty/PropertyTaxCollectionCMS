﻿$(document).ready(function () {

    $('#datatable').DataTable({
        "pageLength": 10,
        "ajax": {
            "url": "/Master/getTehsilDetails/",
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
                { "data": "Tehsil_ID" },
                { "data": "Name" },
                { "data": "State" },
                { "data": "District" },
                { "render": function (data, type, full, meta) { return '<a  href="javascript:void(0)" onclick="Edit(' + full["Tehsil_ID"] + ')" >Edit</a>'; }, "width": "10%" },
        ]
    });

});



function Edit(ID) {
    window.location.href = "/Master/Tehsil?q=" + ID;
}

