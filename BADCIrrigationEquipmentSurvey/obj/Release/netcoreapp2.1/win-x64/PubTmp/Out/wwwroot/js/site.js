

$(function () {

    $.ajaxSetup({
        beforeSend: function () {
            $("#busy-indicator").show(0);
        },
        complete: function () {
            $("#busy-indicator").hide(0);
        }
    });


    $("body").css("padding-top", parseFloat($("#header-content").outerHeight()));

    $(window)
        .on("resize",
            function (evt) {
                setFuncDebounce(setHeaderSlide(evt), timeOutTime);
                $("body").css("padding-top", parseFloat($("#header-content").outerHeight()));
            })
        .on("scroll",
            function (evt) {
                if (timeOutId)
                    clearTimeout(timeOutId);
                var waitTime = ($(window).scrollTop() < 200 && isScrollTop) ? 0 : timeOutTime;
                timeOutId = setTimeout(setHeaderSlide, waitTime, evt);
            });


    if ($.ui.autocomplete.prototype) {

        if ($.ui.autocomplete.prototype._renderMenu) {
            $.ui.autocomplete.prototype._renderMenu = function (ul, items) {
                var that = this;

                if (that.term && that.term.length > 0 && items.length > 1) {
                    var term = that.term.toLowerCase();
                    items = items.sort(function (ia, ib) {
                        return ia.label.toLowerCase().indexOf(term) - ib.label.toLowerCase().indexOf(term);
                    });
                }

                $.each(items,
                    function (index, item) {
                        that._renderItemData(ul, item);
                    });

                $(ul).find("li:odd").addClass("odd");
            };
        }

        if ($.ui.autocomplete.prototype._renderItem) {
            $.ui.autocomplete.prototype._renderItem = function (ul, item) {
                var term = $.ui.autocomplete.escapeRegex
                    ? $.ui.autocomplete.escapeRegex(this.term.toLowerCase())
                    : "(" + this.term.toLowerCase() + ")",
                    rexp = new RegExp(term, "i"),
                    hcls = (this.options.highlight && typeof this.options.highlight == "string")
                        ? this.options.highlight
                        : "ui-autocomplete-highlight",
                    htxt = this.options.highlight
                        ? item.label.replace(rexp, "<strong class='" + hcls + "'>$&</strong>")
                        : item.label;

                return $("<li></li>")
                    .data("item.autocomplete", item)
                    .append("<div>" + htxt + "</div>")
                    .appendTo(ul);
            };
        }

    }

    //console.log($.validator);

    if ($.validator) {

        $.validator.addMethod("date",
            function (value, element) {
                if (this.optional(element)) {
                    return true;
                };

                if (value.match(/\-/g).length < 2 &&
                    value.match(/\./g).length < 2 &&
                    value.match(/\//g).length < 2)
                    return false;

                var regExpDate =
                    new RegExp(/^(0?[1-9]|[12][0-9]|3[01])[\/\-\.](0?[1-9]|1[012])[\/\-\.](\d{4})$/);
                var match = regExpDate.exec(value);
                if (match == null)
                    return false;

                var year = parseInt(match[3], 10),
                    month = parseInt(match[2], 10),
                    day = parseInt(match[1], 10),
                    date = new Date(year, month - 1, day);

                return (date.getFullYear() == year && date.getMonth() == (month - 1) && date.getDate() == day);
            },
            " Invalid date !! must be DD-MM-YYYY or DD.MM.YYYY format."
        );

    }

});




var timeOutId = null,
    timeOutTime = 50,
    isScrollTop = true,
    setHeaderSlide = function (evt) {

        isScrollTop = (evt && evt.type === "resize") ? !isScrollTop : isScrollTop;

        if ($(window).scrollTop() < 200) {
            if (isScrollTop) {
                var paddingTop = parseFloat($(window).scrollTop()) * 0.375,
                    scTime = Math.abs(parseFloat($("#header-content").css("padding-top"))) - paddingTop;

                paddingTop = (paddingTop > 70) ? parseFloat($(".header-banner").outerHeight()) : paddingTop;

                $("#header-content")
                    .stop()
                    .animate({ "top": -paddingTop }, scTime * 7.25);

                if ($(window).scrollTop() < 15) {
                    $("body").css("padding-top", parseFloat($("#header-content").outerHeight()));
                }
            } else if (!isScrollTop && parseInt($("#header-content").css("top")) < 0) {

                $(".navbar-collapse .sub-title").hide(200);
                $(".logo-collapse > img")
                    .stop()
                    .animate({ "height": 0, "margin": 0 }, 200, function () {
                        $("#header-content")
                            .stop()
                            .animate({ "top": "25px" }, 230, "linear", function () {
                                $(".navbar-header .navbar-toggle").css({ "margin-top": "-36px" });
                                $("body").css("padding-top", parseFloat($("#header-content").outerHeight()));
                                $(this)
                                    .stop()
                                    .animate({ "top": 0 }, 200, function () {
                                        $(".logo-collapse").css({ "height": 0, "display": "none" });
                                        $(".logo-collapse > img").css({ "height": 0, "margin": 0, "display": "none" });

                                        if ($(window).scrollTop() < 200) {
                                            $("html, body").animate({ scrollTop: 0 }, $(window).scrollTop() * 2.25, "swing", function () {
                                                isScrollTop = true;
                                            });
                                        } else {
                                            isScrollTop = true;
                                        }
                                    });
                            });
                    });
            }
        } else if (isScrollTop || parseInt($("#header-content").css("top")) > -5) {
            isScrollTop = false;
            $(".navbar-collapse .sub-title").show(200);
            $("#header-content")
                .stop()
                .animate({ "top": -parseFloat($(".header-banner").outerHeight()) - 70 }, 250, function () {
                    $(this)
                        .stop()
                        .animate({ "top": -parseFloat($(".header-banner").outerHeight()) }, 200);
                    $(".logo-collapse").css({ "height": "auto", "display": "" });
                    $(".logo-collapse img")
                        .stop()
                        .css({ "height": 0, "margin": 0, "display": "inline-block" })
                        .animate({ "height": "70px", "margin": "2px 5px" }, 200, function () {
                            $(".navbar-header .navbar-toggle").css({ "margin-top": "7px" });
                        });
                });

        }
    },
    setFuncDebounce = function (func, wait, immediate) {
        var timeout;
        return function () {
            var context = this, args = arguments;
            var later = function () {
                timeout = null;
                if (!immediate) func.apply(context, args);
            };
            var callNow = immediate && !timeout;
            if (!timeout) timeout = setTimeout(later, wait);
            if (callNow) func.apply(context, args);
        };
    },
    callHeaderSlide = function (evt) {
        setFuncDebounce(setHeaderSlide(evt), timeOutTime);
    };


var draggable_modal = function (title, content, modal_bg, kbIsActive) {

    $("body").on("mousedown", "#" + title, function (evt) {
        $("#" + content).addClass("draggable");
        var offsetY = evt.clientY - $(".draggable").offset().top;
        var offsetX = evt.clientX - $(".draggable").offset().left;
        $("body").on("mousemove",
            function (e) {
                $(".draggable").offset({
                    top: e.clientY - offsetY,
                    left: e.clientX - offsetX
                }).on("mouseup",
                    function () {
                        $("#" + content).removeClass("draggable");
                    });
                e.preventDefault();
            });
    }).on("mouseup",
        function () {
            $(".draggable").removeClass("draggable");
        });

    if (kbIsActive) {
        $("body").on("keyup",
            function (e) {
                if (e.which === 27 || e.which === 13)
                    $("#" + modal_bg).hide();
            });
    }
};


var
    modal_open = function (content, top) {
        top = top || 0;

        $("#" + content + "_content").css({ top: "-50%", left: 0, opacity: 0 });
        $("#" + content + "_bg").fadeIn(430,
            function () {
                $("#" + content + "_content").animate({ top: top, opacity: 1 }, 500);
            });
    },
    modal_close = function (content) {
        $("#" + content + "_content").animate({ top: "-50%", opacity: 0 },
            500,
            function () {
                $("#" + content + "_bg").fadeOut(430);
            });
    };



//***===My Message===***//
//  msg = array("type"=>"error", "title"=>"Error... . . !", "msg"=>"Invalid MFI Information !");
//  msg_opt.type, title, msg, autoOpen
function MyMessage() {
    //var msg = function () {
    this.init = function (msg_opt, title, msg, autoOpen) {
        if (typeof (msg_opt) === "undefined")
            return;
        if (msg_opt.constructor !== String || typeof msg_opt !== "string") {
            title = msg_opt["title"];
            msg = msg_opt["msg"];
            autoOpen = msg_opt["autoOpen"];
            msg_opt = msg_opt["type"];
        }
        var typeIsOk = (msg_opt && msg_opt.replace(/\s/g, "").length > 0);

        $("#msg-title-txt").removeClass("msg-title-txt").addClass("msg-title-txt msg-information");
        $("#msg-title-txt").text(title);

        if (typeIsOk)
            $("#msg-body-bg").removeClass().addClass("msg-body-bg msg-" + msg_opt);
        $("#msg-body-msg").text(msg);

        if (typeof (autoOpen) !== "undefined" && !autoOpen)
            return;

        this.open();
        return;
    };

    this.open = function () {
        var msgBg = $("#msg-modal-bg");
        var msgModal = $("#msg-content");
        var openSpeed = 480;

        msgBg.css({ visibility: "hidden", display: "block" });
        msgModal.css({ visibility: "hidden", display: "block", height: "auto" });
        var msgHeight = msgModal.height();
        var msgWidth = msgModal.width();
        msgBg.css({ visibility: "", display: "none" });
        msgModal.css({ visibility: "" });

        var msgTop = ($(window).innerHeight() - msgHeight) / 2 + 50;
        var msgLeft = ($(window).innerWidth() - msgWidth) / 2 - 5;
        msgModal.css({ opacity: 0, height: 0, top: msgTop + "px", left: msgLeft + "px", display: "block" });
        try {
            msgBg.fadeIn(openSpeed / 4, function () {
                msgModal.animate({ opacity: 1, height: msgHeight, top: msgTop - msgHeight / 2 + "px" }, openSpeed, function () {
                    msgBg.css({ opacity: 1 });
                    msgModal.css({ display: "block", opacity: 1, height: "auto", overflow: "visible" });
                });
            });
        } catch (ex) {
            msgBg.animate({ opacity: 1 }, function () {
                msgModal.css({ display: "block", opacity: 1, height: msgHeight, overflow: "visible" });
            });
        }

        draggable_modal("msg-title", "msg-content", "msg-modal-bg");
        return;
    };

    this.close = function () {
        var msgBg = $("#msg-modal-bg");
        var msgModal = $("#msg-content");
        var closeSpeed = 430;
        var msgTop = msgModal.offset().top + msgModal.outerHeight() / 2 - $(window).scrollTop();

        msgModal.animate({ opacity: 0, height: 0, top: msgTop + "px" }, closeSpeed, function () {
            msgModal.css({ opacity: 0, display: "none", height: 0 });
            msgBg.fadeOut(closeSpeed / 2);
        });
        return false;
    };

    this.closeBg = function () {
        var msgBg = $("#msg-modal-bg");
        var msgModal = $("#msg-content");
        var closeSpeed = 430;

        if (msgModal.css("display") === "none" || msgModal.css("display") !== "block") {
            msgModal.animate({ opacity: 0 }, closeSpeed, function () {
                msgModal.css({ opacity: 0, height: 0, display: "none" });
                msgBg.fadeOut(closeSpeed / 2);
            });
        }
        return false;
    };
};
var msg = new MyMessage();

//***===My Modal===***//
function MyModal() {
    //var modal = function () {
    this.init = function (title, contentId, autoOpen) {
        $("#modal-title-txt").text(title);
        if (contentId && $("#" + contentId))
            $("#modal-body-content").empty().append($("#" + contentId).html());

        if (typeof (autoOpen) !== "undefined" && !autoOpen)
            return false;

        this.open();
        return false;
    };

    this.open = function () {
        $("#modal-content").css({ top: "-350px", left: 0, opacity: 0 });
        $("#modal-bg").fadeIn(350, function () {
            $("#modal-content").animate({ top: "0", opacity: 1 }, 500);
        });

        draggable_modal("modal-title", "modal-content", "modal-bg");
        return false;
    };

    this.close = function () {
        $("#modal-content").animate({ top: "-350px", opacity: 0 }, 500, function () {
            $("#modal-bg").fadeOut(350);
        });
        return false;
    };
};

var modal = new MyModal();

