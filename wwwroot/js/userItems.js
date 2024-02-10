function showTable(tableName) {
    $.ajax({
        url: '/UserItems/Details?tableName=' + tableName,
        type: 'GET',
        success: function (data) {
            $('#tableContent').html(data);
        },
        error: function () {
            alert('Error loading table data.');
        }
    });
}

