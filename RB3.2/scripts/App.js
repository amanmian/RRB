$(function () {
    $("#jqGrid").jqGrid({
        url: "/Home/GetStudents",
        datatype: 'json',
        mtype: 'Get',
        colNames: ['ID', 'First Name', 'Last Name', 'Class', 'PermanentAddress', 'CurrentAddress', 'Phone'],
        colModel: [
            { key: true, hidden: true, name: 'Id', index: 'Id', editable: true },
            { key: false, name: 'Fname', index: 'Fname', editable: true },
            { key: false, name: 'LName', index: 'LName', editable: true },
            { key: false, name: 'Class', index: 'Class', editable: true },
            { key: false, name: 'PermanentAddress', index: 'PermanentAddress', editable: true },
            { key: false, name: 'CurrentAddress', index: 'CurrentAddress', editable: true },
            { key: false, name: 'Phone', index: 'Phone', editable: true },
            
        ],
        pager: jQuery('#jqControls'),
        rowNum: 10,
        rowList: [10, 20, 30, 40, 50],
        height: '100%',
        viewrecords: true,
        caption: 'Students Records',
        emptyrecords: 'No Students Records are Available to Display',
        jsonReader: {
            root: "rows",
            page: "page",
            total: "total",
            records: "records",
            repeatitems: false,
            Id: "0"
        },
        autowidth: true,
        multiselect: false
    }).navGrid('#jqControls', { edit: true, add: true, del: true, search: false, refresh: true },
        {
            zIndex: 100,
            url: '/Home/Edit',
            closeOnEscape: true,
            closeAfterEdit: true,
            recreateForm: true,
            afterComplete: function (response) {
                if (response.responseText) {
                    alert(response.responseText);
                }
            }
        },
        {
            zIndex: 100,
            url: "/Home/Create",
            closeOnEscape: true,
            closeAfterAdd: true,
            afterComplete: function (response) {
                if (response.responseText) {
                    alert(response.responseText);
                }
            }
        },
        {
            zIndex: 100,
            url: "/Home/Delete",
            closeOnEscape: true,
            closeAfterDelete: true,
            recreateForm: true,
            msg: "Are you sure you want to delete Student... ? ",
            afterComplete: function (response) {
                if (response.responseText) {
                    alert(response.responseText);
                }
            }
        });
});