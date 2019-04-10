$(function() {
    $(document).on("click",
        ".ajaxbutton",
        function (e) {
            e.preventDefault();
            var form = $(document).find("form[name='" + $(this).attr("form")+"']") ;
            $.ajax({
                url: form.attr("action"),
                method: form.attr("method"),
                data: form.serialize(),
                dataType: form.attr("enctype")
            });
        });
});