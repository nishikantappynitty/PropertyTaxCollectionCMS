$(document).ready(function () {

    $('#datatable').DataTable({
        "pageLength": 10,
        "ajax": {
            "url": "/Report/getAttendenceReport/",
            "tye": "GET",
            "datatype": "json",
        },

        "columns": [
                { "data": "Employee" },
                { "data": "StartDate" },
                { "data": "StartTime" },
                { "data": "EndTime" },
                //{ "data": "Lat" },
                //{ "data": "Long" },
                //{ "render": function (data, type, full, meta) { return '<a  href="javascript:void(0)" onclick="Edit(' + full["UserID"] + ')" >Edit</a>'; }, "width": "10%" },
        ]
    });

});

//function Edit(ID) {
//    window.location.href = "/Master/Employee?q=" + ID;
//}

