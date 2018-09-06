
$(function () {


    $("#top-menu a.dropdown-toggle").on("click", function (e) {
        e.stopPropagation();
        e.preventDefault();

        var isOpen = $(this).closest("li.dropdown").hasClass("open");

        if (isOpen) {
            $(this).closest("li.dropdown").removeClass("open");
            $(this).blur();
        } else {
            $("#top-menu").find(".open").removeClass("open");
            $(this).parents("li.dropdown").addClass("open");
        }

        return;
    });


    //$(".dropdown-submenu > a").on("click", function (e) {
    //    e.stopPropagation();
    //    e.preventDefault();

    //    var isOpen = $(this).closest("li.dropdown").hasClass("open");
    //    if (isOpen) {
    //        $(this).closest("li.dropdown").removeClass("open");
    //        $(this).blur();
    //    } else {
    //        $(this).closest("ul.dropdown-menu").find("li.dropdown").removeClass("open");
    //        $(this).parents("li.dropdown").addClass("open");
    //    }
    //});

});