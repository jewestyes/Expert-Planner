function showTable(tableName) {
    $.ajax({
        url: '/UserItems/Details?tableName=' + tableName,
        type: 'GET',
        success: function (data) {
            $('#tableContent').html(data);
            $('.save-btn').show(); // Показать кнопку после успешной загрузки данных
        },
        error: function () {
            alert('Error loading table data.');
        }
    });
}

window.onload = function () {
    $('.save-btn').hide(); // Скрыть кнопку при загрузке страницы

    $('#tableList a').click(function () {
        // Обработчик клика на ссылку в списке таблиц
        $('.save-btn').show(); // Показать кнопку при клике на ссылку
    });
};