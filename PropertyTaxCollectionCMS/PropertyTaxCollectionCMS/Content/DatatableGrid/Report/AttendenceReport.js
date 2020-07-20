$(document).ready(function () {

    var fdate = $('#txt_fdate').val();
    var tdate = $('#txt_tdate').val();

    $('#datatable').DataTable({
        "pageLength": 10,
        "ajax": {
            "url": "/Report/getAttendenceReport/",
            "data": {
                "fromDate": fdate,
                "toDate": tdate
            },
            "tye": "GET",
            "datatype": "json",
        },

        "columns": [
                { "data": "UserName" },
                { "data": "StartDate" },
                { "data": "StartTime" },
                { "data": "EndDate" },
                { "data": "EndTime" },
                //{ "data": "Lat" },
                //{ "data": "Long" },
                //{ "render": function (data, type, full, meta) { return '<a  href="javascript:void(0)" onclick="Edit(' + full["UserID"] + ')" >Edit</a>'; }, "width": "10%" },
        ]
    });

});

function Datatable() {

    $("#datatable").dataTable().fnDestroy();
    var fdate = $('#txt_fdate').val();
    var tdate = $('#txt_tdate').val();
    

    $('#datatable').DataTable({
        "pageLength": 10,
        "ajax": {
            "url": "/Report/getAttendenceReport/",
            "data": {
                "fromDate": fdate,
                "toDate": tdate
            },
            "tye": "GET",
            "datatype": "json",
        },

        "columns": [
                { "data": "UserName" },
                { "data": "StartDate" },
                { "data": "StartTime" },
                { "data": "EndDate" },
                { "data": "EndTime" },
                //{ "data": "Lat" },
                //{ "data": "Long" },
                //{ "render": function (data, type, full, meta) { return '<a  href="javascript:void(0)" onclick="Edit(' + full["UserID"] + ')" >Edit</a>'; }, "width": "10%" },
        ]
    });

}
function Search() {
    Datatable();
}
