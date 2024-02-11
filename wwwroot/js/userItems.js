function showTable(tableName) {
    $.ajax({
        url: '/UserItems/Details?tableName=' + tableName,
        type: 'GET',
        success: function (data) {
            $('#tableContent').html(data);
            $('.save-btn').show();
        },
        error: function () {
            alert('Error loading table data.');
        }
    });
}

window.onload = function () {
    $('.save-btn').hide(); 

    $('#tableList a').click(function () {
        $('.save-btn').show(); 
    });
};
