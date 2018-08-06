$(document).ready(function () {

    $.ajax({
        url: '/Tasks/BuildTaskTable',
        success: function (result) {
            $('#tableDiv').html(result);
        }
    })
})