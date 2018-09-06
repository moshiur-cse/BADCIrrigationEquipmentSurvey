
$(function () {

    var adminCode = "upaz";
    $("#map_label_opt").prop("checked", false);

    $("#admin_info").val(adminCode);

    set_basic_opts();
    //map_selected_info();
    //set_survey_data(true);

    draggable_modal("option_title", "map_filter_content", "map_filter_bg", false);

});


var isOpen = false;

function map_filter_open(content) {
    if (!isOpen)
        modal_open(content, 50);
    isOpen = true;
}

function map_filter_close(content) {
    if (isOpen)
        modal_close(content);
    isOpen = false;
}

function legend_open_close(legendId, openCloseOpt, propOpt) {
    if (openCloseOpt == "open") {
        $("#" + legendId + "_btn")
            .css(propOpt, "-" + ($("#" + legendId + "_btn").outerWidth(true) + 10) + "px");
        $("#" + legendId).css(propOpt, "-2px");

        $("#" + legendId + "_opt").prop("checked", true);
    } else if (openCloseOpt == "close") {
        $("#" + legendId).css(propOpt, "-" + ($("#" + legendId).outerWidth(true) + 5) + "px");
        $("#" + legendId + "_btn").css(propOpt, "-10px");

        $("#" + legendId + "_opt").prop("checked", false);
    }
}



/**
       * Update a map's viewport to fit each geometry in a dataset
       * @param {google.maps.Map} map The map to adjust
       */

function zoom(map) {
    var bounds = new google.maps.LatLngBounds();
    map.data.forEach(function (feature) {
        processPoints(feature.getGeometry(), bounds.extend, bounds);
    });
    map.fitBounds(bounds);
}

/**
 * Process each point in a Geometry, regardless of how deep the points may lie.
 * @param {google.maps.Data.Geometry} geometry The structure to process
 * @param {function(google.maps.LatLng)} callback A function to call on each
 *     LatLng point encountered (e.g. Array.push)
 * @param {Object} thisArg The value of 'this' as provided to 'callback' (e.g.
 *     myArray)
 */
function processPoints(geometry, callback, thisArg) {
    if (geometry instanceof google.maps.LatLng) {
        callback.call(thisArg, geometry);
    } else if (geometry instanceof google.maps.Data.Point) {
        callback.call(thisArg, geometry.get());
    } else {
        geometry.getArray().forEach(function (g) {
            processPoints(g, callback, thisArg);
        });
    }
}


var map,
    bd_center = null,
    zooming = 7,
    data_type = 1,
    curr_poly = null,
    map_data = [],
    data_info = [],
    //all_map_poly = [],
    //all_map_label = [],
    mapStyles = {
        "default": [
            {
                featureType: "administrative.land_parcel",
                elementType: "labels",
                stylers: [
                    {
                        visibility: "off"
                    }
                ]
            },
            {
                featureType: "poi",
                elementType: "labels.text",
                stylers: [
                    {
                        visibility: "off"
                    }
                ]
            },
            {
                featureType: "poi.business",
                stylers: [
                    {
                        visibility: "off"
                    }
                ]
            },
            {
                featureType: "road",
                elementType: "labels.icon",
                stylers: [
                    {
                        visibility: "off"
                    }
                ]
            },
            {
                featureType: "road.local",
                elementType: "labels",
                stylers: [
                    {
                        visibility: "off"
                    }
                ]
            },
            {
                featureType: "transit",
                stylers: [
                    {
                        visibility: "off"
                    }
                ]
            },
            {
                featureType: "terrain",
                stylers: [
                    {
                        visibility: "on"
                    }
                ]
            }
        ],

        "off": [
            {
                elementType: "geometry",
                stylers: [
                    {
                        "color": "#ffffff"
                    },
                    {
                        "visibility": "simplified"
                    }
                ]
            },
            {
                elementType: "labels",
                stylers: [
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                featureType: "terrain",
                stylers: [
                    {
                        visibility: "off"
                    }
                ]
            }
        ],
        "style1": [
            {
                "featureType": "administrative",
                "elementType": "geometry",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                "featureType": "administrative.land_parcel",
                "elementType": "labels",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                "featureType": "poi",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                "featureType": "poi",
                "elementType": "labels.text",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                "featureType": "road",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                "featureType": "road",
                "elementType": "labels.icon",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                "featureType": "road.local",
                "elementType": "labels",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                "featureType": "transit",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            }
            //,
            //{
            //    "featureType": "terrain",
            //    "stylers": [
            //        {
            //            visibility: "on"
            //        }
            //    ]
            //}
        ]
    };


function set_survey_data(isCenter) {
    //map_selected_info();
    //map_label_show_hide();

    var adminCode = $("#admin_info").val(),
        dataCode = $("#survey_info").val();

    map_data = [];
    try {
        $.getJSON("../js/maps/map_data/" + "all_data" + ".json",
            function (allData) {
                if (allData && allData.all_data.length > 0) {
                    //console.log(allData.all_data);

                    allData.all_data.some(function (ad, i) {
                        if (ad.adminCode == adminCode) {
                            map_data = ad.data.map(function (d, i) {
                                return { geo_code: d[adminCode + "Code"], data_value: d[dataCode] };
                            });
                            return true;
                        }
                        return false;
                    });
                    //console.log(map_data);

                    map_init(adminCode, true);

                    if (isCenter) {
                        map.setCenter(bd_center);
                        map.setZoom(7);
                    }
                }
            });

    } catch (e) {
        map_data = [];
        msg.init("Error", "Error... . .", "Error trying to load/parse JSON data !! <br />" + e.message);
    }

}


function set_basic_opts() {

    if (typeof (google) == "undefined") {
        legend_open_close("legend", "close", "right");
        $("#legend").css("right", "-1000px");
        legend_open_close("legend_info", "close", "left");
        $("#legend_info").css("left", "-1000px");

        msg.init("error", "Error... . .", "Map Loading Failed !");
        $("#busy-indicator").fadeOut();

        //console.log(".....set_basic_opts.....");
        return false;
    }

    bd_center = new google.maps.LatLng(24.237777, 90.878888);
    map = new google.maps.Map(document.getElementById("map"),
        {
            zoom: 7,
            center: bd_center,
            //mapTypeId: "terrain",
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            styles: $("#map_google_layer").prop("checked") ? mapStyles["default"] : mapStyles["off"]
            //disableDefaultUI: true
        }
    );

    set_survey_data(true);

    $("#admin_info").on("change",
        function () {
            set_survey_data();
            return false;
        });

    $("#survey_info").on("change",
        function () {
            map_selected_info();

            if ($("#survey_info").val() != 0) {
                set_survey_data();
            }

        });

    $("#legend_theme").on("change",
        function () {
            map_init($("#admin_info").val());
        });

    $("#map-full-screen").on("click",
        function () {
            if (!confirm("Are you sure to close full screen ?"))
                return;

            $("#map_info").toggleClass("map-full-screen");
        });
    $("#legend_info_opt").change(function () {
        if (this.checked) {
            legend_open_close("legend_info", "open", "left");
        } else {
            legend_open_close("legend_info", "close", "left");
        }
        return false;
    });
    $("#legend_opt").change(function () {
        if (this.checked) {
            legend_open_close("legend", "open", "right");
        } else {
            legend_open_close("legend", "close", "right");
        }
        return false;
    });

    $("#map_label_opt").change(function () {
        map_label_show_hide();
    });

    $("#map_google_layer").change(function () {
        if (map) {
            if (this.checked) {
                map.setOptions({ styles: mapStyles["default"] });
            } else {
                map.setOptions({ styles: mapStyles["off"] });
            }
        }
    });

    return true;
}

function map_selected_info() {

    $("#selected_info").empty();

    //var upazName = $("#admin_info_upazila").find(":selected").text();
    //var distName = $("#admin_info_district").find(":selected").text();
    var surveyInfo = $("#survey_info").find(":selected").text();


    //if ($("#admin_info_upazila").val()) {
    //    $("#selected_info").append("<p>Admin Boundary: <span>" + upazName + ", " + distName + "</span></p>");
    //} else if ($("#admin_info_district").val()) {
    //    $("#selected_info").append("<p>Admin Boundary: <span>" + distName + "</span></p>");
    //}

    $("#selected_info").append("<p>Selected Parameter: <span>" + surveyInfo + "</span></p>");

}

function map_label_show_hide() {

    var isShow = $("#map_label_opt").prop("checked");

    if (isShow) {
        $(".map_label").fadeIn(500);
    } else {
        $(".map_label").fadeOut(500);
    }

    return false;

    /*
    var distCode = $("#admin_info_district").val(),
        upazCode = $("#admin_info_upazila").val(),
        isShow = $("#map_label_opt").prop("checked"),
        pc = 0;

    //if (upazCode) {
    //    for (pc = 0; pc < all_map_poly.length; pc++) {
    //        if (all_map_poly[pc].upaz_code == upazCode && all_map_poly[pc].map_label) {
    //            all_map_poly[pc].map_label.setVisible(isShow);
    //        }
    //    }
    //} else {
    //    for (pc = 0; pc < all_map_poly.length; pc++) {
    //        if (all_map_poly[pc].dist_code == distCode && all_map_poly[pc].map_label) {
    //            all_map_poly[pc].map_label.setVisible(isShow);
    //        }
    //    }
    //}

    //return false;

    var selectedAdmin = "";
    if (distCode)
        selectedAdmin = ".dist_" + distCode;

    if (upazCode)
        selectedAdmin += ".upaz_" + upazCode;

    if (selectedAdmin != "") {
        $(".map_label:not(" + selectedAdmin + ")").fadeOut(500);
        if (isShow) {
            $(".map_label" + selectedAdmin).fadeIn(500);
        } else {
            $(".map_label" + selectedAdmin).fadeOut(500);
        }
        //$(".map_label:not("+selected_admin+")").fadeIn(500);
    } else {
        if (isShow) {
            $(".map_label").fadeIn(500);
        } else {
            $(".map_label").fadeOut(500);
        }
    }
    return false;
    */
}

function get_dynamic_theme(mapData) {
    var minVal = Infinity, maxVal = -Infinity, currVal, theme = [];

    if (!mapData || mapData.length < 1)
        mapData = map_data;

    if (!mapData || mapData.length < 1) return theme;

    for (var dc = 0; dc < mapData.length; dc++) {
        if (!mapData[dc].data_value)
            continue;


        //if (!currVal && currVal != 0) $.isNumeric(mapData[dc].data_value)
        if (isNaN(parseFloat(mapData[dc].data_value)))
            continue;

        currVal = parseFloat(mapData[dc].data_value);

        if (minVal > currVal)
            minVal = currVal;
        if (maxVal < currVal)
            maxVal = currVal;
    }


    //var clrClass = ["#FFEEDD", "#FEBBAA", "#FE9988", "#FA7766", "#FA5544", "#FA3322", "#FA1100"],
    var clrClass = ["#FFFF80", "#FAD155", "#F2A82F", "#AD5314", "#6A0000", "#4A0000"],
        delt = parseInt((maxVal - minVal) / clrClass.length),
        ci = 0;

    for (ci = 0; ci < clrClass.length; ci++) {
        if (ci === 0) {
            theme[ci] = { minVal: minVal, maxVal: delt, color: clrClass[ci] };
        } else if (ci === clrClass.length - 1) {
            theme[ci] = { minVal: (delt * ci) + 1, maxVal: maxVal, color: clrClass[ci] };
        } else {
            theme[ci] = { minVal: (delt * ci) + 1, maxVal: (delt * (ci + 1)), color: clrClass[ci] };
        }
    }

    theme[ci] = { minVal: "noData", maxVal: "-", color: "#FFFFFF" };

    return theme;
}


function get_theme(minVal, maxVal) {
    var theme = [];

    if (!minVal || !maxVal) return theme;

    //var clrClass = ["#FFEEDD", "#FEBBAA", "#FE9988", "#FA7766", "#FA5544", "#FA3322", "#FA1100"],
    var clrClass = ["#AFFF80", "#AAD155", "#A2A82F", "#8D5314", "#5A0000", "#3A0000"],
        delt = parseInt((maxVal - minVal) / clrClass.length),
        ci;

    for (ci = 0; ci < clrClass.length; ci++) {
        if (ci === 0) {
            theme[ci] = { minVal: minVal, maxVal: delt, color: clrClass[ci] };
        } else if (ci === clrClass.length - 1) {
            theme[ci] = { minVal: (delt * ci) + 1, maxVal: maxVal, color: clrClass[ci] };
        } else {
            theme[ci] = { minVal: (delt * ci) + 1, maxVal: (delt * (ci + 1)), color: clrClass[ci] };
        }
    }

    theme[ci] = { minVal: "noData", maxVal: "-", color: "#FFFFFF" };

    return theme;
}


function map_init(adminCode, isSetAdmin) {

    $("#legend_title").empty();
    $("#legend_info_title").empty();
    $("#map_legend_infos").empty();
    $("#map_legend_colors").empty();
    $(".map_label").empty();

    if (typeof (google) == "undefined") {
        legend_open_close("legend", "close", "right");
        $("#legend").css("right", "-1000px");
        legend_open_close("legend_info", "close", "left");
        $("#legend_info").css("left", "-1000px");

        msg.init("error", "Error... . .", "Map Loading Failed !");
        $("#busy-indicator").fadeOut();

        return;
    }


    map = new google.maps.Map(document.getElementById("map"),
        {
            zoom: 7,
            center: bd_center,
            //mapTypeId: "terrain",
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            styles: $("#map_google_layer").prop("checked") ? mapStyles["default"] : mapStyles["off"]
        }
    );

    $("#map_center").on("click",
        function () {
            map.setCenter(bd_center);
            map.setZoom(7);
        });
    google.maps.event.addListener(map,
        "mousemove",
        function (evt) {
            $("#map_cord_info").html(evt.latLng.lat().toFixed(6) + ", " + evt.latLng.lng().toFixed(6));
        });
    google.maps.event.addListenerOnce(map,
        "idle",
        function () {
            map_label_show_hide();
        });

    if (!adminCode)
        adminCode = $("#admin_info").val();

    //if (!adminCode || !map_data || map_data.length < 1) {
    //    legend_open_close("legend", "close", "right");
    //    $("#legend").css("right", "-1000px");
    //    legend_open_close("legend_info", "close", "left");
    //    $("#legend_info").css("left", "-1000px");

    //    msg.init("warning", "Warning... . .", "Data not available !");
    //    $("#busy-indicator").fadeOut();
    //    return;
    //}

    map.setOptions({ styles: $("#map_google_layer").prop("checked") ? mapStyles["default"] : mapStyles["off"] });

    //add_data_layer(adminCode);

    if ($("#basic_survey").prop("checked")) {
        add_data_layer(adminCode);
    } else {
        adminCode = "union";

        $("#admin_div").prop({ "checked": false, "disabled": false });
        $("#admin_dist").prop({ "checked": false, "disabled": false });
        $("#admin_upaz").prop({ "checked": false, "disabled": false });
        $("#admin_union").prop({ "checked": false, "disabled": false });
    }


    if (isSetAdmin && isSetAdmin === true) {

        switch (adminCode) {
            case "div":
                $("#admin_div").prop({ "checked": true, "disabled": false });

                $("#admin_dist").prop({ "checked": false, "disabled": true });
                $("#admin_upaz").prop({ "checked": false, "disabled": true });
                $("#admin_union").prop({ "checked": false, "disabled": true });
                break;

            case "dist":
                $("#admin_div").prop({ "checked": true, "disabled": false });
                $("#admin_dist").prop({ "checked": true, "disabled": false });

                $("#admin_upaz").prop({ "checked": false, "disabled": true });
                $("#admin_union").prop({ "checked": false, "disabled": true });
                break;

            case "upaz":
                $("#admin_div").prop({ "checked": true, "disabled": false });
                $("#admin_dist").prop({ "checked": true, "disabled": false });
                $("#admin_upaz").prop({ "checked": true, "disabled": false });

                $("#admin_union").prop({ "checked": false, "disabled": true });
                break;

            case "union":
                $("#admin_div").prop({ "checked": true, "disabled": false });
                $("#admin_dist").prop({ "checked": true, "disabled": false });
                $("#admin_upaz").prop({ "checked": true, "disabled": false });
                $("#admin_union").prop({ "checked": true, "disabled": false });
                break;

            default:
                $("#admin_div").prop({ "checked": false, "disabled": false });
                $("#admin_dist").prop({ "checked": false, "disabled": false });
                $("#admin_upaz").prop({ "checked": false, "disabled": false });
                $("#admin_union").prop({ "checked": false, "disabled": false });
                break;
        }

        $("#basic_survey").on("change", function () {
            map_init($("#admin_info").val(), this.checked);
        });

        $("input[type='checkbox'].multi-chkbx.admin").each(function () {
            $(this).on("change", function () {
                map_init($("#admin_info").val());
            });
        });


        $("input[type='checkbox'].multi-chkbx.road").each(function () {
            $(this).prop({ "checked": false, "disabled": false });

            $(this).on("change", function () {
                map_init($("#admin_info").val());
            });
        });


        $("input[type='checkbox'].multi-chkbx.layer").each(function () {
            $(this).prop({ "checked": false, "disabled": false });

            $(this).on("change", function () {
                if (this.checked)
                    $("#basic_survey").prop("checked", false);

                map_init($("#admin_info").val());
            });
        });

    }


    $("input[type='checkbox'].multi-chkbx.admin").each(function () {
        if (this.checked && $(this).prop("id") && $(this).prop("id").replace('admin_', ''))
            add_adimn_boundary($(this).prop("id").replace('admin_', ''));
    });


    $("input[type='checkbox'].multi-chkbx.road").each(function () {
        if (this.checked && $(this).prop("id"))
            add_other_layer($(this).prop("id"));
    });


    $("input[type='checkbox'].multi-chkbx.layer").each(function () {
        if (this.checked && $(this).prop("id")) {
            add_other_data_layer($(this).prop("id"), $(this).attr("data"));
        }

        //add_other_layer($(this).prop("id"));
    });


    return;
}


function add_data_layer(adminCode) {


    if (!adminCode)
        adminCode = $("#admin_info").val();

    if (!adminCode)
        return;


    var jsFile = "../js/maps/map_data/" + adminCode + ".json";

    //$.ajax({
    //    url: jsFile,
    //    type: "GET",
    //    error: function () {
    //        return;
    //    },
    //    statusCode: {
    //        404: function () {
    //            return;
    //        }
    //    },
    //    success: function (json) {
    //code here

    if (!map) {
        map = new google.maps.Map(document.getElementById("map"),
            {
                zoom: 7,
                center: bd_center,
                //mapTypeId: "terrain",
                mapTypeId: google.maps.MapTypeId.ROADMAP,
                styles: $("#map_google_layer").prop("checked") ? mapStyles["default"] : mapStyles["off"]
            }
        );
    }

    var
        adminFieldCode = adminCode + "_code",
        adminFieldName = adminCode + "_name",
        adminName = $("#admin_info option:selected").text(),
        dataName = $("#survey_info option:selected").text(),
        totalValue = 0,
        currAdminCode,
        currAdminName,
        dataValue,
        noDataClass = "#FFFFFF",
        selectedPolyId,
        polyCenter,
        offsetLeft,
        labelClass,
        legendTheme = $("#legend_theme").val() == "dynamic"
            ? get_dynamic_theme(map_data)
            : legend_themes[adminCode + "_" + $("#survey_info").val()];

    if (!legendTheme) {
        legendTheme = get_dynamic_theme(map_data);
        $("#legend_theme").val("dynamic");
    }

    if (legendTheme && legendTheme.length > 0) {
        noDataClass = legendTheme[legendTheme.length - 1].color;
        legendTheme.splice(-1, 1);
    }

    map_data.map(d => totalValue += parseFloat(d.data_value));
    totalValue = (totalValue % 1 == 0) ? totalValue : totalValue.toFixed(2);

    $("#legend_title").append(dataName + " legend ");

    var infoWindow = new google.maps.InfoWindow,
        polyDefaultOptions = {
            zIndex: 101,
            strokeColor: "#D0C0A0",
            strokeWeight: 0.15,
            strokeOpacity: 0.95,
            fillOpacity: 0.85
        },
        polyHoverOptions = {
            zIndex: 102,
            strokeColor: "#885522",
            strokeWeight: 0.25,
            strokeOpacity: 0.98,
            fillOpacity: 0.98
        },
        polySelectedOptions = {
            zIndex: 103,
            strokeColor: "#1155AA",
            strokeWeight: 1.0,
            strokeOpacity: 0.99,
            fillOpacity: 0.99
        },
        labelOptions = {
            zIndex: 105,
            boxClass: "map_label",
            boxStyle: {
                textAlign: "center",
                fontSize: "8.5pt",
                width: "auto"
            },
            disableAutoPan: false,
            pixelOffset: new google.maps.Size(-25, -10),
            closeBoxURL: "",
            isHidden: false,
            pane: "mapPane",
            paneId: "mapLabelPanel",
            paneClass: "map_label_panel",
            paneZIndex: 108,
            enableEventPropagation: true
        };


    //bdAdmin
    map.data.loadGeoJson(jsFile, { idPropertyName: adminFieldCode }, function (features) {

        $("#map_legend_infos").empty();

        if (!features || features.length < 1)
            return;

        var table = $("<table>").addClass("table");
        $("#legend_info_title").append(adminName + " Wise " + dataName + " (" + totalValue + ")");

        $("#map_legend_infos").append(table);
        table.append("<tr><th>" + adminName + "</th> <th>" + dataName + "</th></tr>");

        features.forEach(function (feature) {

            if (!feature.getProperty(adminFieldName) || !feature.getProperty(adminFieldCode))
                return;

            currAdminName = feature.getProperty(adminFieldName);
            currAdminCode = feature.getProperty(adminFieldCode);

            map_data.some(function (data, i) {
                return data.geo_code == currAdminCode
                    ? ((dataValue = data.data_value), true)
                    : ((dataValue = "no data"), false);
            });

            if (features.length < 5000) {
                polyCenter = new google.maps.LatLng(feature.getProperty("CNT_LAT"), feature.getProperty("CNT_LONG"));

                offsetLeft = (currAdminName.length - 2 > dataValue.length)
                    ? (3 * currAdminName.length)
                    : (3.5 * dataValue.length);
                labelOptions.content = currAdminName +
                    ("<p style='text-align:center; font-weight:bold; color:#025;'>(" + dataValue + ")</p>");
                labelOptions.pixelOffset = new google.maps.Size(-offsetLeft, -10);
                labelOptions.position = polyCenter;

                labelClass = "map_label";
                if (feature.getProperty("dist_code"))
                    labelClass += " dist_" + feature.getProperty("dist_code").dist_code;
                if (feature.getProperty("upaz_code"))
                    labelClass += " upaz_" + feature.getProperty("upaz_code").upaz_code;

                labelOptions.boxClass = labelClass;

                var mapLabel = new InfoBox(labelOptions);
                mapLabel.open(map);
            }

            table.append("<tr><td style='padding-left:8px; text-align:left;'>" +
                currAdminName +
                "</td> <td style='padding-right:8px; text-align:right;'>" +
                dataValue +
                "</td></tr>");
        });

        //map_data.map(d => totalValue += parseFloat(d.data_value));
        table.append(
            "<tr><td style='padding-right:8px; text-align:right; font-weight:600;'> Total: </td> <td style='padding-right:8px; text-align:right; font-weight:600;'> " +
            totalValue +
            "</td></tr>");

    });

    map.data.setStyle(function (feature) {

        if (!feature.getProperty(adminFieldCode) || !legendTheme) {
            return polyDefaultOptions;
        }

        map_data.some(function (data, i) {
            return data.geo_code == feature.getProperty(adminFieldCode)
                ? ((dataValue = data.data_value), true)
                : ((dataValue = "no data"), false);
        });

        var polyOptions = $.extend(true, {}, polyDefaultOptions);

        if ($.isNumeric(dataValue)) {
            var color;
            legendTheme.some(th => ((!parseFloat(th.minVal) || dataValue >= parseFloat(th.minVal)) &&
                (!parseFloat(th.maxVal) || dataValue <= parseFloat(th.maxVal)))
                ? (color = th.color, true)
                : (color = noDataClass, false)
            );

            polyOptions.fillColor = color ? color : noDataClass;
            polyOptions.strokeColor = color ? color : noDataClass;
        } else {
            polyOptions.fillColor = noDataClass;
            polyOptions.strokeColor = noDataClass;
            polyOptions.fillOpacity = 0.85;
        }

        return polyOptions;
    });


    map.data.addListener("click",
        function (evt) {
            if (selectedPolyId && map.data.getFeatureById(selectedPolyId) && selectedPolyId != evt.feature.getId()) {
                map.data.revertStyle(map.data.getFeatureById(selectedPolyId));
                //map.data.overrideStyle(map.data.getFeatureById(selectedPolyId), polyDefaultOptions);
            }

            map.data.overrideStyle(evt.feature, polySelectedOptions);

            selectedPolyId = evt.feature.getId();

            dataValue = "no data";
            if (evt.feature.getProperty(adminFieldCode)) {
                map_data.some(function (data, i) {
                    return data.geo_code == evt.feature.getProperty(adminFieldCode)
                        ? ((dataValue = data.data_value), true)
                        : ((dataValue = "no data"), false);
                });
            }

            polyCenter = new google.maps.LatLng(evt.feature.getProperty("CNT_LAT"), evt.feature.getProperty("CNT_LONG"));

            infoWindow.setContent(
                "<div style='width:auto; min-width:130px; min-height:45px; text-align:center;'>" +
                "<h2 class='info-title'>" +
                evt.feature.getProperty(adminFieldName) +
                " " +
                adminName +
                "</h2>" +
                "<h3 style='color:#058;'>Count: " +
                dataValue +
                "</h3></div>");

            infoWindow.setPosition(polyCenter);
            infoWindow.open(map);
        });

    infoWindow.addListener("closeclick",
        function () {
            if (selectedPolyId && map.data.getFeatureById(selectedPolyId)) {
                map.data.revertStyle(map.data.getFeatureById(selectedPolyId));
                //map.data.overrideStyle(map.data.getFeatureById(selectedPolyId), polyDefaultOptions);
                selectedPolyId = "";
            }

            infoWindow.setMap(null);
        });

    map.data.addListener("mousemove", function (evt) {
        $("#map_cord_info").html(evt.latLng.lat().toFixed(6) + ", " + evt.latLng.lng().toFixed(6));
    });

    map.data.addListener("mouseover",
        function (evt) {
            if (selectedPolyId && selectedPolyId == evt.feature.getId())
                return;

            map.data.overrideStyle(evt.feature, polyHoverOptions);
        });
    map.data.addListener("mouseout",
        function (evt) {
            if (selectedPolyId && selectedPolyId == evt.feature.getId())
                return;

            map.data.revertStyle(evt.feature);
            //map.data.overrideStyle(evt.feature, polyDefaultOptions);
        });

    if (legendTheme && legendTheme.length > 0) {
        legendTheme.map(function (d, i) {

            var legend;
            if (d.minVal && !parseFloat(d.minVal)) {
                legend = " < " + d.maxVal;
            } else if (d.minVal && !parseFloat(d.maxVal)) {
                legend = " >= " + d.minVal;
            } else {
                legend = d.minVal + " - " + d.maxVal;
            }

            $("#map_legend_colors").append("<label class='map_legend_label'>" +
                "<label class='map_legend_color' style='background-color:" +
                d.color +
                ";'></label>" +
                legend +
                "</label><br/>");
        });
    }

    $("#map_legend_colors").append("<label class='map_legend_label'>" +
        "<label class='map_legend_color' style='border:1px solid #eee; background-color:" +
        noDataClass +
        ";'> </label>No data</label><br/>");

    //$("#survey_count").html("Total: " + totalValue);

    //Admin Boundary
    //$("#map_legend_colors").append("<br /> <label class='map_legend_label'>" +
    //    "<label class='map_legend_color' style='height:1px; background-color:" +
    //    "#D0C0A0" +
    //    ";'> </label>" +
    //    adminName +
    //    " Boundary</label>");


    //if (adminCode == "upaz") {
    //    add_adimn_boundary("dist");
    //    add_adimn_boundary("div");
    //} else if (adminCode == "dist") {
    //    add_adimn_boundary("div");
    //}

    //zoom(map);
    //}
    //});


}


function add_other_layerN(layerName, dataField) {

    if (!layerName)
        return;

    var jsFile = "../js/maps/map_data/" + layerName + ".json";

    //$.ajax({
    //    url: jsFile,
    //    type: "GET",
    //    error: function () {
    //        return;
    //    },
    //    statusCode: {
    //        404: function () {
    //            return;
    //        }
    //    },
    //    success: function (json) {
    //code here

    if (!map) {
        map = new google.maps.Map(document.getElementById("map"),
            {
                zoom: 7,
                center: bd_center,
                //mapTypeId: "terrain",
                mapTypeId: google.maps.MapTypeId.ROADMAP,
                styles: $("#map_google_layer").prop("checked") ? mapStyles["default"] : mapStyles["off"]
            }
        );
    }

    var
        adminFieldCode = adminCode + "_code",
        adminFieldName = adminCode + "_name",
        adminName = $("#admin_info option:selected").text(),
        dataName = $("#survey_info option:selected").text(),
        totalValue = 0,
        currAdminCode,
        currAdminName,
        dataValue,
        noDataClass = "#FFFFFF",

        legendTheme = $("#legend_theme").val() == "dynamic"
            ? get_dynamic_theme(map_data)
            : legend_themes[adminCode + "_" + $("#survey_info").val()];

    if (!legendTheme) {
        legendTheme = get_dynamic_theme(map_data);
        $("#legend_theme").val("dynamic");
    }

    if (legendTheme && legendTheme.length > 0) {
        noDataClass = legendTheme[legendTheme.length - 1].color;
        legendTheme.splice(-1, 1);
    }




    var polyDefaultOptions = {
        zIndex: 101,
        strokeColor: "#D0C0A0",
        strokeWeight: 0.15,
        strokeOpacity: 0.95,
        fillOpacity: 0.85
    };


    //bdAdmin
    map.data.loadGeoJson(jsFile, { idPropertyName: adminFieldCode }, function (features) {

        if (!features || features.length < 1)
            return;

        //dataField

        //features.forEach(function (feature) {

        //    if (!feature.getProperty(adminFieldName) || !feature.getProperty(adminFieldCode))
        //        return;

        //    currAdminName = feature.getProperty(adminFieldName);
        //    currAdminCode = feature.getProperty(adminFieldCode);

        //    map_data.some(function (data, i) {
        //        return data.geo_code == currAdminCode
        //            ? ((dataValue = data.data_value), true)
        //            : ((dataValue = "no data"), false);
        //    });

        //    table.append("<tr><td style='padding-left:8px; text-align:left;'>" +
        //        currAdminName +
        //        "</td> <td style='padding-right:8px; text-align:right;'>" +
        //        dataValue +
        //        "</td></tr>");
        //});

        //map_data.map(d => totalValue += parseFloat(d.data_value));
        table.append(
            "<tr><td style='padding-right:8px; text-align:right; font-weight:600;'> Total: </td> <td style='padding-right:8px; text-align:right; font-weight:600;'> " +
            totalValue +
            "</td></tr>");

    });

    map.data.setStyle(function (feature) {

        if (!feature.getProperty(adminFieldCode) || !legendTheme) {
            return polyDefaultOptions;
        }

        map_data.some(function (data, i) {
            return data.geo_code == feature.getProperty(adminFieldCode)
                ? ((dataValue = data.data_value), true)
                : ((dataValue = "no data"), false);
        });

        var polyOptions = $.extend(true, {}, polyDefaultOptions);

        if ($.isNumeric(dataValue)) {
            var color;
            legendTheme.some(th => ((!parseFloat(th.minVal) || dataValue >= parseFloat(th.minVal)) &&
                (!parseFloat(th.maxVal) || dataValue <= parseFloat(th.maxVal)))
                ? (color = th.color, true)
                : (color = noDataClass, false)
            );

            polyOptions.fillColor = color ? color : noDataClass;
            polyOptions.strokeColor = color ? color : noDataClass;
        } else {
            polyOptions.fillColor = noDataClass;
            polyOptions.strokeColor = noDataClass;
            polyOptions.fillOpacity = 0.85;
        }

        return polyOptions;
    });


    map.data.addListener("click",
        function (evt) {
            if (selectedPolyId && map.data.getFeatureById(selectedPolyId) && selectedPolyId != evt.feature.getId()) {
                map.data.revertStyle(map.data.getFeatureById(selectedPolyId));
                //map.data.overrideStyle(map.data.getFeatureById(selectedPolyId), polyDefaultOptions);
            }

            map.data.overrideStyle(evt.feature, polySelectedOptions);

            selectedPolyId = evt.feature.getId();

            dataValue = "no data";
            if (evt.feature.getProperty(adminFieldCode)) {
                map_data.some(function (data, i) {
                    return data.geo_code == evt.feature.getProperty(adminFieldCode)
                        ? ((dataValue = data.data_value), true)
                        : ((dataValue = "no data"), false);
                });
            }

            polyCenter = new google.maps.LatLng(evt.feature.getProperty("CNT_LAT"), evt.feature.getProperty("CNT_LONG"));

            infoWindow.setContent(
                "<div style='width:auto; min-width:130px; min-height:45px; text-align:center;'>" +
                "<h2 class='info-title'>" +
                evt.feature.getProperty(adminFieldName) +
                " " +
                adminName +
                "</h2>" +
                "<h3 style='color:#058;'>Count: " +
                dataValue +
                "</h3></div>");

            infoWindow.setPosition(polyCenter);
            infoWindow.open(map);
        });

    infoWindow.addListener("closeclick",
        function () {
            if (selectedPolyId && map.data.getFeatureById(selectedPolyId)) {
                map.data.revertStyle(map.data.getFeatureById(selectedPolyId));
                //map.data.overrideStyle(map.data.getFeatureById(selectedPolyId), polyDefaultOptions);
                selectedPolyId = "";
            }

            infoWindow.setMap(null);
        });

    map.data.addListener("mousemove", function (evt) {
        $("#map_cord_info").html(evt.latLng.lat().toFixed(6) + ", " + evt.latLng.lng().toFixed(6));
    });

    map.data.addListener("mouseover",
        function (evt) {
            if (selectedPolyId && selectedPolyId == evt.feature.getId())
                return;

            map.data.overrideStyle(evt.feature, polyHoverOptions);
        });
    map.data.addListener("mouseout",
        function (evt) {
            if (selectedPolyId && selectedPolyId == evt.feature.getId())
                return;

            map.data.revertStyle(evt.feature);
            //map.data.overrideStyle(evt.feature, polyDefaultOptions);
        });

    if (legendTheme && legendTheme.length > 0) {
        legendTheme.map(function (d, i) {

            var legend;
            if (d.minVal && !parseFloat(d.minVal)) {
                legend = " < " + d.maxVal;
            } else if (d.minVal && !parseFloat(d.maxVal)) {
                legend = " >= " + d.minVal;
            } else {
                legend = d.minVal + " - " + d.maxVal;
            }

            $("#map_legend_colors").append("<label class='map_legend_label'>" +
                "<label class='map_legend_color' style='background-color:" +
                d.color +
                ";'></label>" +
                legend +
                "</label><br/>");
        });
    }

    $("#map_legend_colors").append("<label class='map_legend_label'>" +
        "<label class='map_legend_color' style='border:1px solid #eee; background-color:" +
        noDataClass +
        ";'> </label>No data</label>");

    //$("#survey_count").html("Total: " + totalValue);

    //Admin Boundary
    //$("#map_legend_colors").append("<br /> <label class='map_legend_label'>" +
    //    "<label class='map_legend_color' style='height:1px; background-color:" +
    //    "#D0C0A0" +
    //    ";'> </label>" +
    //    adminName +
    //    " Boundary</label>");


    //if (adminCode == "upaz") {
    //    add_adimn_boundary("dist");
    //    add_adimn_boundary("div");
    //} else if (adminCode == "dist") {
    //    add_adimn_boundary("div");
    //}

    //zoom(map);
    //}
    //});


}


function add_other_data_layer(layerName, dataField, dataTitle) {

    if (!layerName)
        return;

    //console.log(layerName);
    //console.log(dataField);

    if (!map) {
        map = new google.maps.Map(document.getElementById("map"),
            {
                zoom: 7,
                center: bd_center,
                //mapTypeId: "terrain",
                mapTypeId: google.maps.MapTypeId.ROADMAP,
                styles: $("#map_google_layer").prop("checked") ? mapStyles["default"] : mapStyles["off"]
            }
        );
    }


    var jsFile = "../js/maps/map_data/" + layerName + ".json";

    var
        totalValue = 0,
        dataValue,
        noDataClass = "#FFFFFF";
    //legendTheme = get_theme(1, 6);

    //if (!legendTheme) {
    //    legendTheme = get_dynamic_theme(map_data);
    //    $("#legend_theme").val("dynamic");
    //}

    //if (legendTheme && legendTheme.length > 0) {
    //    noDataClass = legendTheme[legendTheme.length - 1].color;
    //    legendTheme.splice(-1, 1);
    //}

    //map_data.map(d => totalValue += parseFloat(d.data_value));
    //totalValue = (totalValue % 1 == 0) ? totalValue : totalValue.toFixed(2);


    var polyDefaultOptions = {
        zIndex: 101,
        strokeColor: "#D0C0A0",
        strokeWeight: 0.15,
        strokeOpacity: 0.95,
        fillOpacity: 0.85
    };


    //bdAdmin
    var legendTheme = new Array();

    map.data.loadGeoJson(jsFile, function (features) {
        return;
        //console.log(feature.getProperty(dataField));

        //if (!features || features.length < 1 || !feature.getProperty(dataField))
        //    return;

        //dataValue = feature.getProperty(dataField);
        //if (!legendTheme[dataValue]) {
        //    legendTheme[dataValue] = "#" + Math.random().toString(16).slice(2, 8).toUpperCase();
        //    console.log(legendTheme[dataValue]);
        //}


        //    features.forEach(function (feature) {

        //        if (!feature.getProperty(dataField))
        //            return;

        //        dataValue =!feature.getProperty(dataField)? feature.getProperty(dataField):"no data";

        //        //map_data.some(function (data, i) {
        //        //    return data.geo_code == currlayerName
        //        //        ? ((dataValue = data.data_value), true)
        //        //        : ((dataValue = "no data"), false);
        //        //});

        //        //if (features.length < 5000) {
        //        //    //polyCenter = new google.maps.LatLng(feature.getProperty("CNT_LAT"), feature.getProperty("CNT_LONG"));

        //        //    offsetLeft = (3.5 * dataValue.length);
        //        //    labelOptions.content = "<p style='text-align:center; font-weight:bold; color:#025;'>(" + dataValue + ")</p>";
        //        //    labelOptions.pixelOffset = new google.maps.Size(-offsetLeft, -10);
        //        //    labelOptions.position = polyCenter;

        //        //    var mapLabel = new InfoBox(labelOptions);
        //        //    mapLabel.open(map);
        //        //}

        //        //table.append("<tr><td style='padding-left:8px; text-align:left;'>" +
        //        //    currAdminName +
        //        //    "</td> <td style='padding-right:8px; text-align:right;'>" +
        //        //    dataValue +
        //        //    "</td></tr>");
        //    });

        //    //map_data.map(d => totalValue += parseFloat(d.data_value));
        //    table.append(
        //        "<tr><td style='padding-right:8px; text-align:right; font-weight:600;'> Total: </td> <td style='padding-right:8px; text-align:right; font-weight:600;'> " +
        //        totalValue +
        //        "</td></tr>");

    });

    map.data.setStyle(function (feature) {

        //"Polygon"
        //console.log(feature.type);
        //console.log(feature);
        //console.log(feature.geometry.type);


        if (!feature.getProperty(dataField)) {
            return polyDefaultOptions;
        }

        dataValue = feature.getProperty(dataField);

        if (!legendTheme[dataValue]) {
            legendTheme[dataValue] = "#" + Math.random().toString(16).slice(2, 8).toUpperCase();
            //console.log(legendTheme[dataValue]);

            $("#map_legend_colors").append("<label class='map_legend_label'>" +
                "<label class='map_legend_color' style='background-color:" +
                legendTheme[dataValue] +
                ";'></label>" +
                dataValue +
                "</label><br/>");
        }


        //map_data.some(function (data, i) {
        //    return data.geo_code == feature.getProperty(dataField)
        //        ? ((dataValue = data.data_value), true)
        //        : ((dataValue = "no data"), false);
        //});

        var polyOptions = $.extend(true, {}, polyDefaultOptions);

        if (dataField == "RIVNAME") {
            polyOptions.strokeWeight = 1;
            polyOptions.strokeOpacity = 1;
            polyOptions.strokeColor = legendTheme[dataValue];

            polyOptions.fillOpacity = 0;
            polyOptions.fillColor = legendTheme[dataValue];
        } else {

            if (dataValue && legendTheme[dataValue]) {
                polyOptions.fillColor = legendTheme[dataValue];
                polyOptions.strokeColor = legendTheme[dataValue];
            } else {
                polyOptions.fillColor = noDataClass;
                polyOptions.strokeColor = noDataClass;
                polyOptions.fillOpacity = 0.85;
            }
        }

        //if ($.isNumeric(dataValue)) {
        //    var color;
        //    legendTheme.some(th => ((!parseFloat(th.minVal) || dataValue >= parseFloat(th.minVal)) &&
        //        (!parseFloat(th.maxVal) || dataValue <= parseFloat(th.maxVal)))
        //        ? (color = th.color, true)
        //        : (color = noDataClass, false)
        //    );

        //    polyOptions.fillColor = color ? color : noDataClass;
        //    polyOptions.strokeColor = color ? color : noDataClass;
        //} else {
        //    polyOptions.fillColor = noDataClass;
        //    polyOptions.strokeColor = noDataClass;
        //    polyOptions.fillOpacity = 0.85;
        //}

        return polyOptions;
    });



    //if (legendTheme && legendTheme.length > 0) {
    //    legendTheme.each(function (c, l) {
    //        console.log(c);
    //        console.log(l);
    //        $("#map_legend_colors").append("<label class='map_legend_label'>" +
    //            "<label class='map_legend_color' style='background-color:" +
    //            c +
    //            ";'></label>" +
    //            l +
    //            "</label><br/>");
    //    });
    //}


}

function add_other_line_layer(layerName, dataField, dataTitle) {

    if (!layerName)
        return;

    if (!map) {
        map = new google.maps.Map(document.getElementById("map"),
            {
                zoom: 7,
                center: bd_center,
                //mapTypeId: "terrain",
                mapTypeId: google.maps.MapTypeId.ROADMAP,
                styles: $("#map_google_layer").prop("checked") ? mapStyles["default"] : mapStyles["off"]
            }
        );
    }


    var lineStyle = {
        zIndex: 102,
        //path: "M 0,-1 0,1",
        strokeColor: "#5A3322",
        strokeWeight: 1,
        strokeOpacity: 1,
        scale: 0.5,
        fillOpacity: 0.0
    };

    var layerPath = "../js/maps/map_data/" + layerName + ".json";

    $.getJSON(layerPath, function (mapLines) {

        if (!mapLines) return;

        mapLines.features.forEach(function (feature) {
            try {
                var mapPolyLine,
                    lineGeom = feature.geometry,
                    paths = GetLatLngs(lineGeom.coordinates, (lineGeom.type == "MultiPolygon"));

                if (lineGeom.type == "MultiPolygon") {
                    paths.forEach(function (path, i) {
                        mapPolyLine = new google.maps.Polyline({
                            zIndex: 105,
                            path: path,
                            geodesic: true,
                            strokeColor: "#0000FF",
                            strokeOpacity: 1.0,
                            strokeWeight: 1,
                            map: map
                        });
                    });
                } else {
                    mapPolyLine = new google.maps.Polyline({
                        zIndex: 105,
                        path: path,
                        geodesic: true,
                        strokeColor: "#0000FF",
                        strokeOpacity: 1.0,
                        strokeWeight: 1,
                        map: map
                    });
                }
            } catch (e) {
            }
        });
    });

}


function add_adimn_boundary(adminCode) {
    if (!adminCode) return;

    //var polyDefaultOptions = {
    //    zIndex: 102,
    //    strokeColor: "#5A3322",
    //    strokeWeight: 0.15,
    //    strokeOpacity: 0.95,
    //    fillOpacity: 0.85
    //};

    var lineStyle = {
        zIndex: 102,
        //path: "M 0,-1 0,1",
        strokeColor: "#5A3322",
        strokeWeight: 0.5,
        strokeOpacity: 1,
        scale: 0.5,
        fillOpacity: 0.0
    };


    switch (adminCode) {
        case "div":
            //polyDefaultOptions.zIndex = 107;
            //polyDefaultOptions.strokeColor = "#3A2211";
            //polyDefaultOptions.strokeWeight = 1.0;

            lineStyle.zIndex = 107;
            lineStyle.path = "M 0,-1 0,1";
            lineStyle.strokeColor = "#3A2211";
            lineStyle.strokeWeight = 1.0;
            lineStyle.scale = 1.5;

            $("#map_legend_colors").append("<label class='map_legend_label'>" +
                "<label class='map_legend_color' style='height:0; border: 1px dashed #3A2211;'></label>" +
                "Division Boundary </label> <br />");
            break;

        case "dist":
            //polyDefaultOptions.zIndex = 105;
            //polyDefaultOptions.strokeColor = "#5A3322";
            //polyDefaultOptions.strokeWeight = 0.7;

            lineStyle.zIndex = 105;
            lineStyle.path = "M 0,-1 0,1";
            lineStyle.strokeColor = "#5A3322";
            lineStyle.strokeWeight = 0.7;
            lineStyle.scale = 1.0;

            $("#map_legend_colors").append("<label class='map_legend_label'>" +
                "<label class='map_legend_color' style='height:0; border-top: 1px dashed #5A3322;'></label>" +
                "District Boundary </label> <br />");
            break;

        case "upaz":
            //polyDefaultOptions.zIndex = 103;
            //polyDefaultOptions.strokeColor = "#4A0000";
            //polyDefaultOptions.strokeWeight = 0.5;

            lineStyle.zIndex = 103;
            lineStyle.path = "M 0,-1 0,1";
            lineStyle.strokeColor = "#4A0000";
            lineStyle.strokeWeight = 0.5;
            lineStyle.scale = 0.7;

            $("#map_legend_colors").append("<label class='map_legend_label'>" +
                "<label class='map_legend_color' style='height:1px; background-color:#4A0000;'></label>" +
                "Upazila Boundary </label> <br />");
            break;

        case "union":
            //polyDefaultOptions.zIndex = 102;
            //polyDefaultOptions.strokeColor = "#AA5533";
            //polyDefaultOptions.strokeWeight = 0.25;

            lineStyle.zIndex = 102;
            lineStyle.strokeColor = "#AA5533";
            lineStyle.strokeWeight = 0.25;
            lineStyle.scale = 0.5;

            $("#map_legend_colors").append("<label class='map_legend_label'>" +
                "<label class='map_legend_color' style='height:1px; background-color:#AA5533;'></label>" +
                "Upazila Boundary </label> <br />");
            break;

        default:
            break;
    }

    var adminLayerPath = "../js/maps/map_data/" + adminCode + ".json";

    $.getJSON(adminLayerPath, function (mapAdminData) {
        if (!mapAdminData) return;

        mapAdminData.features.forEach(function (feature) {
            try {
                var mapPolyLine,
                    adminGeom = feature.geometry,
                    paths = GetLatLngs(adminGeom.coordinates, (adminGeom.type == "MultiPolygon"));

                if (adminGeom.type == "MultiPolygon") {
                    paths.forEach(function (path, i) {
                        mapPolyLine = new google.maps.Polyline({
                            zIndex: 107,
                            path: path,
                            strokeOpacity: 0,
                            icons: [
                                {
                                    icon: lineStyle,
                                    offset: "0",
                                    repeat: "5px"
                                }
                            ],
                            map: map
                        });
                    });
                } else {
                    mapPolyLine = new google.maps.Polyline({
                        zIndex: 107,
                        path: paths,
                        strokeOpacity: 0,
                        icons: [
                            {
                                icon: lineStyle,
                                offset: "0",
                                repeat: "10px"
                            }
                        ],
                        map: map
                    });
                }
            } catch (e) {
            }
        });
    });

}


function add_other_layer(layerName) {
    if (!layerName) return;

    //var polyDefaultOptions = {
    //    zIndex: 103,
    //    strokeColor: "#3A2211",
    //    strokeWeight: 0.5,
    //    strokeOpacity: 1.0,
    //    fillOpacity: 0.5
    //};

    var lineStyle = {
        zIndex: 103,
        strokeColor: "#5A3322",
        strokeWeight: 0.5,
        strokeOpacity: 1,
        scale: 0.5,
        fillOpacity: 0.0
    };

    //if (layerName == "div") {
    //    polyDefaultOptions.zIndex = 107;
    //    polyDefaultOptions.strokeColor = "#3A2211";
    //    polyDefaultOptions.strokeWeight = 1.0;

    //    lineStyle.zIndex = 107;
    //    lineStyle.strokeColor = "#3A2211";
    //    lineStyle.strokeWeight = 1.0;
    //    lineStyle.scale = 1.5,
    //        $("#map_legend_colors").append("<br /> <label class='map_legend_label'>" +
    //            "<label class='map_legend_color' style='height:0; border: 1px dashed " +
    //            "#3A2211" +
    //            ";'> </label>Division Boundary</label>");
    //} else {
    //    $("#map_legend_colors").append("<br /> <label class='map_legend_label'>" +
    //        "<label class='map_legend_color' style='height:0; border-top: 1px dashed " +
    //        "#5A3322" +
    //        ";'> </label>District Boundary</label>");
    //}


    $.getJSON("../js/maps/map_data/" + layerName + ".json",
        function (mapAdminData) {
            if (!mapAdminData) return;
            mapAdminData.features.forEach(function (feature) {
                try {
                    var adminGeom = feature.geometry,
                        paths = GetLatLngs(adminGeom.coordinates, (adminGeom.type == "MultiPolygon"));

                    if (adminGeom.type == "MultiPolygon") {
                        paths.forEach(function (path, i) {
                            var mapPolyLine = new google.maps.Polyline({
                                zIndex: 107,
                                path: path,
                                strokeOpacity: 0,
                                icons: [
                                    {
                                        icon: lineStyle,
                                        offset: "0",
                                        repeat: "5px"
                                    }
                                ],
                                map: map
                            });
                        });
                    } else {
                        var mapPolyLine = new google.maps.Polyline({
                            zIndex: 107,
                            path: paths,
                            strokeOpacity: 0,
                            icons: [
                                {
                                    icon: lineStyle,
                                    offset: "0",
                                    repeat: "10px"
                                }
                            ],
                            map: map
                        });
                    }
                } catch (e) {
                }
            });
        });
}


function GetLatLngs(geoCoordinates, isMultiPoly = false) {
    if (typeof (google) == "undefined") {
        return null;
    }

    var path = [], paths = [], ci, pc, cpc;

    if (!isMultiPoly) {
        for (ci = 0; ci < geoCoordinates.length; ci++) {
            for (cpc = 0; cpc < geoCoordinates[ci].length; cpc++) {
                path.push({ lat: geoCoordinates[ci][cpc][1], lng: geoCoordinates[ci][cpc][0] });
            }
        }
        return path;
    } else {
        for (pc = 0; pc < geoCoordinates.length; pc++) {
            path = [];
            for (ci = 0; ci < geoCoordinates[pc].length; ci++) {
                for (cpc = 0; cpc < geoCoordinates[pc][ci].length; cpc++) {
                    path.push({ lat: geoCoordinates[pc][ci][cpc][1], lng: geoCoordinates[pc][ci][cpc][0] });
                }
            }
            paths.push(path);
        }
    }

    return paths;
}
