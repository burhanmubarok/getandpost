// Write your Javascript code.
$(function() {
    $('#btnGet').on('click', function () {
        var uriGet = "http://localhost:10502/Form/SubmitGet?formId=123&FormField=Testing&FormFieldOther=Tadaaaa";
        $.ajax(
        {
            url: uriGet
        });
    });

    $('#btnPost').on('click', function () {
        var uriPost = 'http://localhost:10502/Form/SubmitPost';
        var param = {};
        param.FormId = $(this).attr("FormId");
        param.FormField = $(this).attr("FormField");
        param.FormFieldOther = $(this).attr("FormFieldOther");

        $.ajax(
        {
            url: uriPost,
            type: "post",
            dataType: "json",
            data: param
        });
    });
});