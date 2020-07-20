$(document).ready(function () {

    var fdate = $('#txt_fdate').val();
    var tdate = $('#txt_tdate').val();

    $('#datatable').DataTable({
        "pageLength": 10,
        "order": [[0, "desc"]],
        "ajax": {
            "url": "/Report/getTaxReminderReport",
            "data": {
                "fromDate": fdate,
                "toDate": tdate,
                "q": 3
            },
            "tye": "GET",
            "datatype": "json",
        },

        "columns": [
                { "data": "TC_ID" },
                //{ "data": "TCAT_ID" },
                { "data": "RECEIPT_NO" },
                { "data": "RECEIVER_NAME" },
                { "data": "TOTAL_AMOUNT" },
                { "data": "RECEIVED_AMOUNT" },
                { "data": "REMAINING_AMOUNT" },
                 { "data": "PAYMENT_DATE" },
                //{ "data": "RECEIVER_SIGNATURE" },
        ]

    });

});


function Datatable() {

    $("#datatable").dataTable().fnDestroy();

    var fdate = $('#txt_fdate').val();
    var tdate = $('#txt_tdate').val();

    $('#datatable').DataTable({
        "pageLength": 10,
        "order": [[0, "desc"]],
        "ajax": {
            "url": "/Report/getTaxReminderReport",
            "data": {
                "fromDate": fdate,
                "toDate": tdate,
                "q": 3
            },
            "tye": "GET",
            "datatype": "json",
        },

        "columns": [
                { "data": "TC_ID" },
                //{ "data": "TCAT_ID" },
                { "data": "RECEIPT_NO" },
                { "data": "RECEIVER_NAME" },
                { "data": "TOTAL_AMOUNT" },
                { "data": "RECEIVED_AMOUNT" },
                { "data": "REMAINING_AMOUNT" },
                { "data": "PAYMENT_DATE" },
                //{ "data": "RECEIVER_SIGNATURE" },
        ]
    });

}

function Search() {
    Datatable();
}