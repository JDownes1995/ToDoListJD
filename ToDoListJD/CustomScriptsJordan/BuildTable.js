// Populating tableDiv in "Index.cshtml" using AJAX Allows for page update without refreshing
$(document).ready(function () {
    $.ajax({
        url: '/ToDoes/BuildToDoTable',
        success: function (result) {
            $('#tableDiv').html(result);
        }
    }
    );
});