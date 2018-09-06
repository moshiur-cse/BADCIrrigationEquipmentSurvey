
(function ($) {

    $.fn.numeric = function (config, callback) {
        config = config || {};

        if (typeof config === "boolean") {
            config = { decimal: config };
        }

        config.decimal = (typeof config.decimal !== "undefined" && config.decimal) ? "." : false;
        config.negative = (typeof config.negative !== "undefined" && config.negative) ? "-" : false;

        config.localize = (typeof config.localize !== "undefined" && config.localize);
        config.fract_digits = !config.decimal ? 0 : (typeof config.fract_digits !== "undefined" && $.isNumeric(config.fract_digits))
            ? config.fract_digits : (config.fract_digits ? 0 : 2);

        this.data("numeric.decimal", config.decimal).data("numeric.negative", config.negative)
            .data("numeric.localize", config.localize).data("numeric.fract_digits", config.fract_digits);

        return this.keypress($.fn.numeric.keypress).keyup($.fn.numeric.keyup).blur($.fn.numeric.blur);
    };

    $.fn.numeric.keypress = function (e) {
        var key = e.charCode ? e.charCode : (e.keyCode ? e.keyCode : (e.which ? e.which : 0));
        if (key === 13 && this.nodeName.toLowerCase() === "input")
            return true;
        else if (key === 13)
            return false;
        //if ((e.shiftKey && key === 45) || (e.ctrlKey && (key === 45 || key === 65 ||
        if ((e.shiftKey && (key === 45 || key === 37 || key === 39)) ||
            (e.ctrlKey && (key === 45 || key === 65 || key === 67 ||
                key === 86 || key === 88 || key === 90 || key === 97 ||
                key === 99 || key === 118 || key === 120 || key === 122)))
            return true;
        if (e.ctrlKey || e.shiftKey || e.altKey)
            return false;
        //Left:37 Right:39  Up:38 Down:40
        if (key === 8 || key === 9 || key === 13 || (34 < key && key < 41))// || key === 46
            return true;
        //NumericDigit: 48 to 57
        if (47 < key && key < 58)
            return true;

        var decimal = $.data(this, "numeric.decimal"),
            negative = $.data(this, "numeric.negative");
        if (key === 46) {
            if (String.fromCharCode(e.charCode) !== ".") {
                return true;
            }
            if (decimal && String.fromCharCode(key) === decimal) {
                if (this.value.indexOf(decimal) === -1) {
                    if ($.fn.getSelectionStart(this) === 0 && this.value.indexOf(negative) !== 0) {
                        this.value = "0" + this.value;
                        $.fn.setCursorPosition(this, 1);
                    } else if ($.fn.getSelectionStart(this) < 2 && this.value.indexOf(negative) === 0) {
                        this.value = "-0" + this.value.substring(1);
                        $.fn.setCursorPosition(this, 2);
                    }
                    this.focus();
                    return true;
                }
            }
            return false;
        }
        if (key === 45) {
            if (negative && String.fromCharCode(key) === negative) {
                if (this.value.length === 0) {
                    return true;
                }

                var curPos;
                if (this.value.indexOf(negative) === -1) {
                    if ($.fn.getSelectionStart(this) === 0) {
                        if (this.value.indexOf(decimal) === 0) {
                            this.value = "0" + this.value;
                            $.fn.setCursorPosition(this, 2);
                            this.focus();
                        }
                        return true;
                    } else {
                        curPos = $.fn.getSelectionStart(this);
                        if ((this.value.indexOf(decimal) === 0)) {
                            this.value = "-0" + this.value;
                            curPos += 2;
                        } else {
                            this.value = "-" + this.value;
                            curPos += 1;
                        }
                        $.fn.setCursorPosition(this, curPos);
                        this.focus();
                        return false;
                    }
                } else {
                    curPos = ($.fn.getSelectionStart(this) > 1) ? $.fn.getSelectionStart(this) - 1 : 0;
                    this.value = this.value.replace(/-/g, "");
                    $.fn.setCursorPosition(this, curPos);
                    this.focus();
                    return false;
                }
                return false;
            }
            return false;
        }
        return false;
    };

    $.fn.numeric.keyup = function (e) {
        var key = e.charCode ? e.charCode : (e.keyCode ? e.keyCode : (e.which ? e.which : 0));
        if ((e.shiftKey && (key === 45 || key === 37 || key === 39)) ||
            (e.ctrlKey && (key === 45 || key === 65 || key === 67 ||
                key === 86 || key === 88 || key === 90 || key === 97 ||
                key === 99 || key === 118 || key === 120 || key === 122)))
            return true;
        if (e.ctrlKey || e.shiftKey || e.altKey)
            return false;

        //NumericDigit: 48 to 57 ## .&,  || key === 45 || key === 46 || key === 109 || key === 110 
        if (this.value.length > 1 && (key === 8 || key === 9 || key === 13 || (44 < key && key < 58) || (95 < key && key < 111))) {
            var curPos = $.fn.getSelectionStart(this),
                val = this.value,
                preLen = val.length;

            val = val.replace(/[^\d.-]/g, "");
            if ($.data(this, "numeric.localize") && !isNaN(parseFloat(val))) {
                try {
                    val = (val.indexOf(".") > -1)
                        ? val.replace(/\B(?=(\d)(\d{2})+(?!\d)\.)/g, ",")
                        : val.replace(/\B(?=(\d)(\d{2})+(?!\d))/g, ",");
                } catch (e) {
                    val = "";
                }
            }

            this.value = val;
            curPos += (val.length - preLen);
            $.fn.setCursorPosition(this, curPos);
            this.focus();
        }

        //if (this.value.indexOf("-") > -1) {
        //    $(this).css("background-color", "#d43");
        //} else {
        //    $(this).css("background-color", "#fff");
        //}
        return true;
    };

    $.fn.numeric.blur = function () {
        if (this.value.length > 0) {
            var //curPos = $.fn.getSelectionStart(this),
                val = this.value;

            val = val.replace(/[^\d.-]/g, "");
            if (!isNaN(parseFloat(val))) {
                try {

                    var fractDigits = $.data(this, "numeric.fract_digits");
                    if ($.data(this, "numeric.localize")) {
                        val = parseFloat(val).toFixed(fractDigits);
                        val = (val.indexOf(".") > -1)
                            ? val.replace(/\B(?=(\d)(\d{2})+(?!\d)\.)/g, ",")
                            : val.replace(/\B(?=(\d)(\d{2})+(?!\d))/g, ",");
                    } else if (fractDigits > 0) {
                        val = parseFloat(val).toFixed(fractDigits);
                    }
                } catch (e) {
                    val = "";
                    //$(this).css("background-color", "#fff");
                }
            } else {
                val = "";
                //$(this).css("background-color", "#fff");
            }
            this.value = val;

            //curPos += (val.length - preLen);
            //$.fn.setCursorPosition(this, curPos);
        }
        return;
    };

    $.fn.removeNumeric = function () {
        return this.data("numeric.decimal", null)
            .data("numeric.negative", null)
            .data("numeric.localize", null)
            .data("numeric.fract_digits", null)
            .unbind("keypress", $.fn.numeric.keypress)
            .unbind("keyup", $.fn.numeric.keyup)
            .unbind("blur", $.fn.numeric.blur);
    };

    $.fn.getSelectionStart = function (el) {
        el.focus();
        if (el.selectionStart) {
            return el.selectionStart;
        } else if (window.getSelection || document.getSelection || el.createTextRange) {
            var range = window.getSelection ? window.getSelection() :
                document.getSelection ? document.getSelection() :
                    document.selection && el.createTextRange ? document.selection.createRange().duplicate() : null;
            if (range) {
                range.moveEnd("character", el.value.length);
                if (range.text.length === 0) {
                    return el.value.length;
                } else {
                    return el.value.lastIndexOf(range.text);
                }
            } else {
                return el.selectionStart;
            }
        }
        return el.selectionStart;
    };
    $.fn.setCursorPosition = function (el, npos) {
        if (el.setSelectionRange) {
            el.setSelectionRange(npos, npos);
            el.focus();
        } else if (el.selectionStart) {
            el.selectionStart = npos;
            el.selectionEnd = npos;
            el.focus();
        } else if (el.createTextRange) {
            var range = el.createTextRange();
            range.collapse(true);
            range.moveEnd("character", npos);
            range.moveStart("character", npos);
            range.select();
        }
    };

})(jQuery);
