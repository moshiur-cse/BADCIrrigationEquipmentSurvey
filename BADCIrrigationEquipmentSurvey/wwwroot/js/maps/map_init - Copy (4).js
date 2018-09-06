
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



function legend_open_close(legendId, openCloseOpt, propOpt) {
    if (openCloseOpt == "open") {
        $("#" + legendId + "_btn")
            .css(propOpt, "-" + ($("#" + legendId + "_btn").outerWidth(true) + 10) + "px");
        $("#" + legendId).css(propOpt, "-4px");

        $("#" + legendId + "_opt").prop("checked", true);
    } else if (openCloseOpt == "close") {
        $("#" + legendId).css(propOpt, "-" + ($("#" + legendId).outerWidth(true) + 5) + "px");
        $("#" + legendId + "_btn").css(propOpt, "-10px");

        $("#" + legendId + "_opt").prop("checked", false);
    }
}

var map,
    bd_center = null,
    zooming = 7,
    data_type = 1,
    curr_poly = null,
    map_data = [],
    data_info = [],
    all_map_poly = [],
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
        $.getJSON("../js/maps/map_data/" + "all_data" + ".jSON",
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

                    map_init(adminCode);

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

    /*
    $("#admin_info").on("change", function () {
        $("#admin_info_upazila").hide();

        $("#admin_info_district").empty();
        $("#admin_info_district").append("<option value=''>--- select ---</option>");
        $("#admin_info_upazila").empty();
        $("#admin_info_upazila").append("<option value=''>--- select ---</option>");

        for (var fc = 0; fc < bd_all["dist"].features.length; fc++) {
            $("#admin_info_district").append("<option value='" +
                bd_all["dist"].features[fc].properties.dist_code +
                "'>" +
                bd_all["dist"].features[fc].properties.dist_name +
                "</option>");
        }

        if ($(this).val() == "upaz") {
            $("#map_label_opt").prop("checked", false);
        }
    });

    $("#admin_info_district").on("change", function () {

        if ($("#admin_info").val() == "upaz") {
            $("#admin_info_upazila").show();
        }

        $("#admin_info_upazila").empty();
        $("#admin_info_upazila").append("<option value=''>--- select ---</option>");

        var distCode = $("#admin_info_district").val();
        for (var fc = 0; fc < bd_all["upaz"].features.length; fc++) {
            if (bd_all["upaz"].features[fc].properties.dist_code == distCode) {
                $("#admin_info_upazila").append("<option value='" +
                    bd_all["upaz"].features[fc].properties.upaz_code +
                    "'>" +
                    bd_all["upaz"].features[fc].properties.upaz_name +
                    "</option>");
            }
        }

        set_map_filter();
        map_selected_info();
    });

    $("#admin_info_upazila").on("change", function () {
        set_map_filter();
        map_selected_info();
        map_label_show_hide();
    });
    */

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

        currVal = parseFloat(mapData[dc].data_value);
        if (!currVal)
            continue;
        if (minVal > currVal)
            minVal = currVal;
        if (maxVal < currVal)
            maxVal = currVal;
    }

    var clrClass = ["#FFEEDD", "#FEBBAA", "#FE9988", "#FA7766", "#FA5544", "#FA3322", "#FA1100"],
        delt = parseInt((maxVal - minVal) / clrClass.length - 1),
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

function map_init(adminCode) {

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


    if (all_map_poly && all_map_poly.length > 0) {
        for (var pc = 0; pc < all_map_poly.length; pc++) {
            if (all_map_poly[pc].map_poly && all_map_poly[pc].map_poly.getMap != null)
                all_map_poly[pc].map_poly.setMap(null);

            if (all_map_poly[pc].map_label)
                all_map_poly[pc].map_label.close();
        }
    }

    all_map_poly = [];

    //bd_center = new google.maps.LatLng(24.237777, 90.878888);
    //map = new google.maps.Map(document.getElementById("map"),
    //    {
    //        zoom: 7,
    //        center: bd_center,
    //        //mapTypeId: "terrain",
    //        mapTypeId: google.maps.MapTypeId.ROADMAP,
    //        styles: mapStyles["default"],
    //        disableDefaultUI: true
    //    }
    //);

    map = new google.maps.Map(document.getElementById("map"),
        {
            zoom: 7,
            center: bd_center,
            //mapTypeId: "terrain",
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            styles: $("#map_google_layer").prop("checked") ? mapStyles["default"] : mapStyles["off"],
            //disableDefaultUI: true
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

    if (!adminCode || !bd_all[adminCode] || !map_data || map_data.length < 1) {
        legend_open_close("legend", "close", "right");
        $("#legend").css("right", "-1000px");
        legend_open_close("legend_info", "close", "left");
        $("#legend_info").css("left", "-1000px");

        msg.init("warning", "Warning... . .", "Data not available !");
        $("#busy-indicator").fadeOut();
        return;
    }

    map.setOptions({ styles: $("#map_google_layer").prop("checked") ? mapStyles["default"] : mapStyles["off"] });

    var bdAdmin,
        adminFieldCode = adminCode + "_code",
        adminFieldName = adminCode + "_name",
        adminName = $("#admin_info option:selected").text(),
        dataName = $("#survey_info option:selected").text(),
        totalValue = 0,
        currAdminCode,
        currAdminName,
        dataValue,
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

    var clrClass = legendTheme
        ? legendTheme.map(function (d) {
            return d.color;
        })
        : ["#FFEEDD", "#FEBBAA", "#FE9988", "#FA7766", "#FA5544", "#FA3322", "#FA1100", "#FFFFFF"],
        noDataClass;

    if (clrClass.length) {
        noDataClass = clrClass[clrClass.length - 1];
        clrClass.splice(-1, 1);
    }

    map_data.map(d => totalValue += parseInt(d.data_value));

    $("#legend_info_title").append(adminName + " Wise " + dataName + " (" + totalValue + ")");
    $("#legend_title").append(dataName + " legend ");


    var infoWindow = new google.maps.InfoWindow,
        polyDefaultOptions = {
            zIndex: 101,
            strokeColor: "#DDCCAA",
            strokeWeight: 0.15,
            strokeOpacity: 0.95,
            fillOpacity: 0.95
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

    /*
    var lineStyle = {
        zIndex: 103,
        path: "M 0,-1 0,1",
        strokeColor: "#5A3322",
        strokeWeight: 0.5,
        strokeOpacity: 1,
        scale: 0.5,
        fillOpacity: 0
    };

    var map_admin_data = new google.maps.Data({
        map: map,
        style: {
            zIndex: 108,
            strokeColor: "#ff0000",
            strokeOpacity: 0.8,
            strokeWeight: 1,
            fillColor: "#ff0000",
            fillOpacity: 0.1,
        icons: [
            {
                icon: lineStyle,
                offset: "0",
                repeat: "5px"
            }
        ]
        }
    });

    //map_admin_data.addGeoJson(bdAdmin);
    map_admin_data.loadGeoJson("../js/maps/map_data/div.jSON");
    console.log(map_admin_data.properties);
    console.log(map_admin_data.features);

    map_admin_data.getArray().map(function (feature) {
        console.log(feature);

        currAdminName = feature.getProperty(adminFieldName);
        currAdminCode = feature.getProperty(adminFieldCode);
        //currValue = map_data.filter(data => data.geo_code == currAdminCode).map(data => data.data_value);

        map_data.some(function (data, i) {
            return data.geo_code == currAdminCode ? ((dataValue = data.data_value), true) : false;
        });

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

        var polyOptions = $.extend(true, {}, polyDefaultOptions);

        if (dataValue) {
            var color = legendTheme
                .filter(d => ((!parseFloat(d.minVal) || dataValue >= d.minVal) &&
                    (!parseFloat(d.maxVal) || dataValue <= d.maxVal)))
                .map(d => d.color);

            polyOptions.fillColor = color && color.length > 0 ? color[0] : noDataClass;

            $("#map_legend_infos").append("<p>" + currAdminName + " (" + dataValue + ")</p>");
        } else {
            dataValue = "no data";
            polyOptions.fillColor = noDataClass;
            polyOptions.fillOpacity = 0.95;
        }

        return polyOptions;
    });
    
    return;
    */

    // Load GeoJSON.
    //map.data.loadGeoJson("../js/maps/map_data/dist.jSON");
    // map.data.loadGeoJson("../js/maps/map_data/div.jSON");

    //map.data.addGeoJson(data);
    //map.data.forEach(function (feature) {
    //    console.log("Id from Google's feature: " + feature.getId());
    //});



    //bdAdmin
    var jsFile = "../js/maps/map_data/" + adminCode + ".jSON";
    map.data.loadGeoJson(jsFile, { idPropertyName: adminFieldCode });


    var table = $("<table>");
    table.append("<tr><th>" + adminName + "</th> <th>" + dataName + "</th></tr>");

    $("#map_legend_infos").append(table);

    console.log(map.data);
    map.data.forEach(function (feature) {

        console.log(feature);

        //var tbl = "<table>" + "<tr><th>" + adminName + "</th> <th>" + dataName + "</th></tr>";
        //tbl += "<tr><td>" + d[adminCode + "Code"] + "</td> <td>" + d[dataCode] + "</td></tr>";
        //tbl += "</table>";
        //table.append("<tr><td>" + d[adminCode + "Code"] + "</td> <td>" + d[dataCode] + "</td></tr>");
        //$("#map_legend_infos").append(content);
        //$("#legend_info_title").append(adminName + " Wise " + dataName + " (" + totalValue + ")");
        //$("#legend_title").append(dataName + " legend ");

        currAdminName = feature.getProperty(adminFieldName);
        currAdminCode = feature.getProperty(adminFieldCode);
        //currValue = map_data.filter(data => data.geo_code == currAdminCode).map(data => data.data_value);

        map_data.some(function (data, i) {
            return data.geo_code == currAdminCode ? ((dataValue = data.data_value), true) : false;
        });

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

        var polyOptions = $.extend(true, {}, polyDefaultOptions);

        if (dataValue) {
            var color = legendTheme
                .filter(d => ((!parseFloat(d.minVal) || dataValue >= d.minVal) &&
                    (!parseFloat(d.maxVal) || dataValue <= d.maxVal)))
                .map(d => d.color);

            polyOptions.fillColor = color && color.length > 0 ? color[0] : noDataClass;
        } else {
            dataValue = "no data";
            polyOptions.fillColor = noDataClass;
            polyOptions.fillOpacity = 0.95;
        }
        //$("#map_legend_infos").append("<p>" + currAdminName + " (" + dataValue + ")</p>");

        table.append("<tr><td>" + currAdminName + "</td> <td>" + dataValue + "</td></tr>");

        return polyOptions;
    });

    map.data.forEach(function (feature) {

        if (!feature.getProperty(adminFieldCode)) {
            return polyDefaultOptions;
        }

        currAdminName = feature.getProperty(adminFieldName);
        currAdminCode = feature.getProperty(adminFieldCode);


        map_data.some(function (data, i) {
            return data.geo_code == currAdminCode ? ((dataValue = data.data_value), true) : false;
        });

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

        var polyOptions = $.extend(true, {}, polyDefaultOptions);

        if (dataValue) {
            var color;
            legendTheme
                .some(th => ((!parseFloat(th.minVal) || dataValue >= parseFloat(th.minVal)) &&
                    (!parseFloat(th.maxVal) || dataValue <= parseFloat(th.maxVal)))
                    ? (color = th.color, true)
                    : false);

            polyOptions.fillColor = color ? color : noDataClass;
        } else {
            dataValue = "no data";
            polyOptions.fillColor = noDataClass;
            polyOptions.fillOpacity = 0.95;
        }
        //$("#map_legend_infos").append("<p>" + currAdminName + " (" + dataValue + ")</p>");

        table.append("<tr><td>" + currAdminName + "</td> <td>" + dataValue + "</td></tr>");

        return polyOptions;
    });



    map.data.setStyle(function (feature) {

        if (!feature.getProperty(adminFieldCode)) {
            return polyDefaultOptions;
        }

        currAdminName = feature.getProperty(adminFieldName);
        currAdminCode = feature.getProperty(adminFieldCode);


        map_data.some(function (data, i) {
            return data.geo_code == currAdminCode ? ((dataValue = data.data_value), true) : false;
        });

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

        var polyOptions = $.extend(true, {}, polyDefaultOptions);

        if (dataValue) {
            var color;
            legendTheme
                .some(th => ((!parseFloat(th.minVal) || dataValue >= parseFloat(th.minVal)) &&
                    (!parseFloat(th.maxVal) || dataValue <= parseFloat(th.maxVal)))
                    ? (color = th.color, true)
                    : false);

            //legendTheme
            //    .some(function (th) {
            //        return ((!parseFloat(th.minVal) || dataValue >= parseFloat(th.minVal)) &&
            //                (!parseFloat(th.maxVal) || dataValue <= parseFloat(th.maxVal)))
            //            ? (color = th.color, true)
            //            : false;
            //    });

            polyOptions.fillColor = color ? color : noDataClass;
        } else {
            dataValue = "no data";
            polyOptions.fillColor = noDataClass;
            polyOptions.fillOpacity = 0.95;
        }
        //$("#map_legend_infos").append("<p>" + currAdminName + " (" + dataValue + ")</p>");

        table.append("<tr><td>" + currAdminName + "</td> <td>" + dataValue + "</td></tr>");

        return polyOptions;
    });


    map.data.addListener("click",
        function (evt) {
            if (selectedPolyId && map.data.getFeatureById(selectedPolyId) && selectedPolyId != evt.feature.getId())
                map.data.revertStyle(map.data.getFeatureById(selectedPolyId));

            map.data.overrideStyle(evt.feature, polySelectedOptions);

            selectedPolyId = evt.feature.getId();

            dataValue = 0;
            if (evt.feature.getProperty(adminFieldCode)) {
                map_data.some(function (data, i) {
                    return data.geo_code == evt.feature.getProperty(adminFieldCode) ? ((dataValue = data.data_value), true) : false;
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
            if (selectedPolyId && map.data.getFeatureById(selectedPolyId))
                map.data.revertStyle(map.data.getFeatureById(selectedPolyId));

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
            map.data.overrideStyle(evt.feature, polyDefaultOptions);
        });


    if (legendTheme) {
        legendTheme.map(function (d, i) {

            var legend;
            if (d.minVal && !parseInt(d.minVal)) {
                legend = " < " + d.maxVal;
            } else if (d.minVal && !parseInt(d.maxVal)) {
                legend = " >= " + d.minVal;
            } else {
                legend = d.minVal + " - " + d.maxVal;
            }

            if (i < legendTheme.length - 1) {
                $("#map_legend_colors").append("<label class='map_legend_label'>" +
                    "<label class='map_legend_color' style='background-color:" +
                    d.color +
                    ";'></label>" +
                    legend +
                    "</label><br/>");
            } else {
                $("#map_legend_colors").append("<label class='map_legend_label'>" +
                    "<label class='map_legend_color' style='background-color:" +
                    noDataClass +
                    ";'> </label>No data</label>");

            }
        });
    }

    //$("#map_legend_colors").append("<label class='map_legend_label'>" +
    //            "<label class='map_legend_color' style='height:1px; background-color:" +
    //            "#AA8877" +
    //";'> </label>No data</label>");

    //$("#survey_count").html("Total: " + totalValue);

    $("#map_legend_colors").append("<br /> <label class='map_legend_label'>" +
        "<label class='map_legend_color' style='height:1px; background-color:" +
        "#DDCCAA" +
        ";'> </label>" +
        adminName +
        " Boundary</label>");

    if (adminCode == "upaz") {
        add_adimn_boundary("dist");
        add_adimn_boundary("div");
    } else if (adminCode == "dist") {
        add_adimn_boundary("div");
    }

    //zoom(map);
}

function add_adimn_boundary(adminCode) {
    if (!adminCode || !bd_all[adminCode]) return;

    var polyDefaultOptions = {
        zIndex: 103,
        strokeColor: "#3A2211",
        strokeWeight: 0.5,
        strokeOpacity: 1.0,
        fillOpacity: 0.00
    };

    var lineStyle = {
        zIndex: 103,
        path: "M 0,-1 0,1",
        strokeColor: "#5A3322",
        strokeWeight: 0.5,
        strokeOpacity: 1,
        scale: 0.5,
        fillOpacity: 0
    };

    if (adminCode == "div") {
        polyDefaultOptions.zIndex = 107;
        polyDefaultOptions.strokeColor = "#3A2211";
        polyDefaultOptions.strokeWeight = 1.0;

        lineStyle.zIndex = 107;
        lineStyle.strokeColor = "#3A2211";
        lineStyle.strokeWeight = 1.0;
        lineStyle.scale = 1.5,
            $("#map_legend_colors").append("<br /> <label class='map_legend_label'>" +
                "<label class='map_legend_color' style='height:0; border: 1px dashed " +
                "#3A2211" +
                ";'> </label>Division Boundary</label>");
    } else {
        $("#map_legend_colors").append("<br /> <label class='map_legend_label'>" +
            "<label class='map_legend_color' style='height:0; border-top: 1px dashed " +
            "#5A3322" +
            ";'> </label>District Boundary</label>");
    }

    $.getJSON("../js/maps/map_data/" + adminCode + ".jSON",
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
