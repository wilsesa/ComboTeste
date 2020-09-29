$(document).ready(function () {
    $('#select').on('change', function () {
        var selectvalor = '#' + $(this).val();

        $('#pai').children('div').hide();
        $('#pai').children( selectvalor).show();
    })
});