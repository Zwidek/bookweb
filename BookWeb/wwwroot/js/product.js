var dataTable;

$(document).ready(function () {
    loadDataTable();
    alert("hi");
});

function loadDataTable() {
   dataTable= $('#tblData').DataTable({
        "ajax": {
            "url":"/Admin/Product/GetAll"
        },
        "columns": [
            { "data": "title", "width": "15%" },
            { "data": "isbn", "width": "15%" },
            { "data": "price", "width": "15%" },
            { "data": "author", "width": "15%" }
        ]
    });
}
