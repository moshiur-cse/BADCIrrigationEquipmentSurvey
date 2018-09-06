
$(function () {

    var adminCode = "dist";

    $("#bd_info").val(adminCode);

    set_basic_opts();
    map_selected_info();
    set_survey_data(true);

    draggable_modal("option_title", "map_filter_content", "map_filter_bg", false);


    $("#bd_info").on("change",
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

});

function test() {
    var img = $("img[src$='http://maps.google.com/maps/vt?']", $("#mapLabelPanel").parent()).closest("div")
        .closest("div").closest("div").hide();

    console.log(img);
}

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


//$("#filter_option").css("display", "none");
//$("#filter_option").prop("disabled", "disabled");



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
    map_data_title,
    bd_center = null,
    zooming = 7,
    data_type = 1,
    map_data = [],
    data_info = [],
    all_map_poly = [],
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



//var lat = 24.237777, log = 90.878888;
//23.777777, 90.444444


function set_survey_data(isCenter) {
    map_selected_info();

    map_label_show_hide($("#map_label_opt").prop("checked"));

    var adminCode = $("#bd_info").val(),
        dataCode = $("#survey_info").val();

    map_data = Array();
    if (all_data && all_data[adminCode]) {
        try {
            map_data = all_data[adminCode].map(function(d, i) {
                return { geo_code: d[adminCode + "Code"], data_value: d[dataCode] };
            });

            map_init(adminCode);

            if (isCenter) {
                map.setCenter(bd_center);
                map.setZoom(7);
            }
            //currValue = map_data.filter(data => data.geo_code == currAdminCode).map(data => data.data_value);

        } catch (e) {
            msg.init("Error", "Error... . .", "Error trying to parse JSON !! <br />" + e.message);
            //alert("Error trying to parse JSON." + e.message);
        }
    }

}


function map_selected_info() {

    $("#selected_info").empty();

    var upazName = $("#bd_info_upazila").find(":selected").text();
    var distName = $("#bd_info_district").find(":selected").text();
    var surveyInfo = $("#survey_info").find(":selected").text();


    if ($("#bd_info_upazila").val()) {
        $("#selected_info").append("<p>Admin Boundary: <span>" + upazName + ", " + distName + "</span></p>");
    } else if ($("#bd_info_district").val()) {
        $("#selected_info").append("<p>Admin Boundary: <span>" + distName + "</span></p>");
    }

    $("#selected_info").append("<p>Selected Parameter: <span>" + surveyInfo + "</span></p>");

}


var curr_poly = null;

function set_basic_opts() {

    bd_center = new google.maps.LatLng(24.237777, 90.878888);
    map = new google.maps.Map(document.getElementById("map"),
        {
            zoom: 7,
            center: bd_center,
            //mapTypeId: "terrain",
            //mapTypeId: google.maps.MapTypeId.ROADMAP,
            styles: mapStyles["default"],
            //disableDefaultUI: true
        }
    );


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
        map_label_show_hide(this.checked);
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


    $("#bd_info").on("change", function () {
        $("#bd_info_upazila").hide();

        $("#bd_info_district").empty();
        $("#bd_info_district").append("<option value=''>--- select ---</option>");
        $("#bd_info_upazila").empty();
        $("#bd_info_upazila").append("<option value=''>--- select ---</option>");

        for (var fc = 0; fc < bd_all["dist"].features.length; fc++) {
            $("#bd_info_district").append("<option value='" +
                bd_all["dist"].features[fc].properties.dist_code +
                "'>" +
                bd_all["dist"].features[fc].properties.dist_name +
                "</option>");
        }

        if ($(this).val() == "upaz") {
            $("#map_label_opt").prop("checked", false);
            //map_label_show_hide(false);
        }
    });

    $("#bd_info_district").on("change", function () {

        if ($("#bd_info").val() == "upaz") {
            $("#bd_info_upazila").show();
        }

        $("#bd_info_upazila").empty();
        $("#bd_info_upazila").append("<option value=''>--- select ---</option>");

        var distCode = $("#bd_info_district").val();
        for (var fc = 0; fc < bd_all["upaz"].features.length; fc++) {
            if (bd_all["upaz"].features[fc].properties.dist_code == distCode) {
                $("#bd_info_upazila").append("<option value='" +
                    bd_all["upaz"].features[fc].properties.upaz_code +
                    "'>" +
                    bd_all["upaz"].features[fc].properties.upaz_name +
                    "</option>");
            }
        }

        set_map_filter();
        map_selected_info();
    });

    $("#bd_info_upazila").on("change", function () {
        set_map_filter();
        map_selected_info();
        map_label_show_hide($("#map_label_opt").prop("checked"));
    });


    return true;
}

function map_label_show_hide(isShow) {
    var distCode = $("#bd_info_district").val();
    var upazCode = $("#bd_info_upazila").val();

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
}

function map_init(adminCode) {

    $("#legend_title").empty();
    $("#legend_info_title").empty();
    $("#map_legend_infos").empty();
    $("#map_legend_colors").empty();

    if (all_map_poly && all_map_poly.length > 0) {
        for (var pc = 0; pc < all_map_poly.length; pc++) {
            if (all_map_poly[pc].map_poly && all_map_poly[pc].map_poly.getMap != null)
                all_map_poly[pc].map_poly.setMap(null);
        }
    }
    all_map_poly = [];

    if (typeof (google) == "undefined") {
        legend_open_close("legend", "close", "right");
        $("#legend").css("right", "-1000px");
        legend_open_close("legend_info", "close", "left");
        $("#legend_info").css("left", "-1000px");

        msg.init("error", "Error... . .", "Map Loading Failed !");
        $("#busy-indicator").fadeOut();
        return;
    }

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

    $("#map_center").on("click",
        function () {
            map.setCenter(bd_center);
            map.setZoom(7);
        });
    google.maps.event.addListenerOnce(map,
        "mousemove",
        function (evt) {
            $("#map_cord_info").html(evt.latLng.lat().toFixed(6) + ", " + evt.latLng.lng().toFixed(6));
        });
    google.maps.event.addListenerOnce(map,
        "idle",
        function () {
            //$(".map_label").css("display", $("#map_label_opt").prop("checked") ? "block" : "none");
            map_label_show_hide($("#map_label_opt").prop("checked"));
        });



    //if (!admin_code || !bd_all[admin_code]) {
    if (!adminCode || !bd_all[adminCode] || !map_data || map_data.length < 1) {
        legend_open_close("legend", "close", "right");
        $("#legend").css("right", "-1000px");
        legend_open_close("legend_info", "close", "left");
        $("#legend_info").css("left", "-1000px");

        msg.init("warning", "Warning... . .", "Data not available !");
        $("#busy-indicator").fadeOut();
        return;
    }


    var clrClass = ["#FFEEDD", "#FEBBAA", "#FE9988", "#FA7766", "#FA5544", "#FA3322", "#FA1100"],
        noDataClass = "#FFFFFF";

    //var clrClass = legend_themes["default"]
    //        ? legend_themes["default"].map(function(d) {
    //            return d.color;
    //        })
    //        : ["#FFEEDD", "#FEBBAA", "#FE9988", "#FA7766", "#FA5544", "#FA3322", "#FA1100", "#FFFFFF"],
    //    noDataClass;

    //if (clrClass.length) {
    //    noDataClass = clrClass[clrClass.length - 1];
    //    clrClass.splice(-1, 1);
    //}

    var bdAdmin = bd_all[adminCode];
    var adminFieldCode = adminCode + "_code";
    var adminFieldName = adminCode + "_name";


    var minVal = Infinity, maxVal = -Infinity, currVal, totalValue = 0;

    for (var dc = 0; dc < map_data.length; dc++) {
        if (!map_data[dc].data_value)
            continue;

        currVal = parseFloat(map_data[dc].data_value);
        totalValue += currVal;
        if (!currVal)
            continue;
        if (minVal > currVal)
            minVal = map_data[dc].data_value;
        if (maxVal < currVal)
            maxVal = map_data[dc].data_value;
    }


    var adminName = $("#bd_info option:selected").text();
    //var surveyInfo = $("#survey_info option:selected").text();

    map_data_title = adminName + " Wise Count";
    $("#legend_info_title").append(map_data_title + " (" + totalValue + ")");

    $("#legend_title").append(map_data_title);

    var delt = parseInt((maxVal - minVal) / clrClass.length) + 1;
    var currAdminCode,
        currAdminName,
        currValue,
        colorIndex,
        dataValue,
        mapPoly,
        polyCenter,
        offsetLeft,
        labelClass;

    var infoWindow = new google.maps.InfoWindow;

    var polyDefaultOptions = {
        zIndex: 101,
        strokeColor: "#553322",
        strokeWeight: 1.0,
        strokeOpacity: 0.95,
        fillOpacity: 0.95
        //strokeOpacity: 0.7,
        //fillOpacity: 0.7
    };
    var polyHoverOptions = {
        zIndex: 102,
        strokeColor: "#553322",
        strokeWeight: 2.0,
        strokeOpacity: 0.98,
        fillOpacity: 0.98
        //strokeOpacity: 0.8,
        //fillOpacity: 0.8
    };
    //fillColor: hoverColor,
    var polySelectedOptions = {
        zIndex: 103,
        strokeColor: "#0055AA",
        strokeWeight: 2.5,
        strokeOpacity: 0.99,
        fillOpacity: 0.99
        //strokeOpacity: 0.9,
        //fillOpacity: 0.9
    };

    var labelOptions = {
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

    bdAdmin.features.forEach(function (feature) {
        try {
            var adminGeom = feature.geometry;
            var adminProps = feature.properties;

            currAdminName = adminProps[adminFieldName];
            currAdminCode = adminProps[adminFieldCode];
            currValue = map_data.filter(data => data.geo_code == currAdminCode).map(data => data.data_value);

            //curr_value = Math.round(Math.random() * 5000 + 500, 10);
            //map_data.push({ geo_code: curr_admin_code, data_value: curr_value});
            ////map_data[] = { geo_code: curr_admin_code, data_value: Math.random() * 5000 };

            //console.log(curr_admin_code + " : " + curr_value);

            //"CNT_LAT","CNT_LONG"
            polyCenter = new google.maps.LatLng(adminProps["CNT_LAT"], adminProps["CNT_LONG"]);

            var polyOptions = $.extend(true, {}, polyDefaultOptions);
            if (currValue.length) {
                //rmo
                dataValue = currValue[0];

                if (dataValue != 0) {
                    colorIndex = parseInt(dataValue / delt);

                    if (colorIndex >= clrClass.length)
                        colorIndex = clrClass.length - 1;

                    polyOptions.fillColor = clrClass[colorIndex];
                } else {
                    polyOptions.fillColor = noDataClass;// = vldClass;
                }

                //dataValue = (dataValue && data_type == 2) ? parseFloat(dataValue).toFixed(2) : dataValue;

                $("#map_legend_infos").append("<p>" + currAdminName + " (" + dataValue + ")</p>");
            } else {
                dataValue = "no data";
                polyOptions.fillColor = noDataClass;
                polyOptions.fillOpacity = 0.95;
            }

            polyOptions.paths = GetGeoPaths(adminGeom.coordinates, (adminGeom.type == "MultiPolygon"));
            mapPoly = new google.maps.Polygon(polyOptions);
            mapPoly.setMap(map);

            all_map_poly.push({
                center: polyCenter,
                div_code: adminProps.div_code,
                dist_code: adminProps.dist_code,
                upaz_code: adminProps.upaz_code,
                map_poly: mapPoly
            });
            data_info = {
                pos: polyCenter,
                admin_name: adminName,
                data_admin_name: currAdminName,
                data_value: dataValue,
                div_code: adminProps.div_code,
                dist_code: adminProps.dist_code,
                upaz_code: adminProps.upaz_code
            };
            (function (mapPoly, dataInfo) {
                mapPoly.addListener("click",
                    function (evt) {

                        if (this.strokeWeight == polySelectedOptions.strokeWeight)
                            return;

                        if (curr_poly && curr_poly.getMap != null) {
                            curr_poly.setOptions(polyDefaultOptions);
                        }
                        curr_poly = this;
                        this.setOptions(polySelectedOptions);

                        if (data_type == 1) {
                            infoWindow.setContent(
                                "<div style='width:auto; min-width:130px; min-height:45px; text-align:center;'>" +
                                "<h2 class='info-title'>" +
                                dataInfo.data_admin_name +
                                " " +
                                dataInfo.admin_name +
                                "</h2>" +
                                "<h3 style='color:#058;'>Count: " +
                                dataInfo.data_value +
                                "</h3></div>");
                        } else {
                            infoWindow.setContent(
                                "<div style='width:auto; min-width:130px; min-height:45px; text-align:center;'>" +
                                "<h2 class='info-title'>" +
                                dataInfo.data_admin_name +
                                " " +
                                dataInfo.admin_name +
                                "</h2>" +
                                "<h3 style='color:#058;'>Amount: " +
                                dataInfo.data_value +
                                " (BDT.)</h3></div>");
                        }

                        infoWindow.setPosition(dataInfo.pos);
                        infoWindow.open(map, this);
                    });
                infoWindow.addListener("closeclick",
                    function () {
                        curr_poly = null;
                        mapPoly.setOptions(polyDefaultOptions);
                        infoWindow.setMap(null);
                    });

                mapPoly.addListener("mousemove",
                    function (evt) {
                        $("#map_cord_info")
                            .html(evt.latLng.lat().toFixed(6) + ", " + evt.latLng.lng().toFixed(6));
                    });
                mapPoly.addListener("mouseover",
                    function (evt) {
                        if (this.strokeWeight == polySelectedOptions.strokeWeight)
                            return;

                        this.setOptions(polyHoverOptions);
                    });
                mapPoly.addListener("mouseout",
                    function (evt) {
                        if (this.strokeWeight == polySelectedOptions.strokeWeight)
                            return;
                        this.setOptions(polyDefaultOptions);
                    });
            })(mapPoly, data_info);

            offsetLeft = (currAdminName.length - 2 > dataValue.length)
                ? (3 * currAdminName.length)
                : (3.5 * dataValue.length);
            labelOptions.content = currAdminName +
                ("<p style='text-align:center; font-weight:bold; color:#024;'>(" + dataValue + ")</p>");
            labelOptions.pixelOffset = new google.maps.Size(-offsetLeft, -10);
            labelOptions.position = polyCenter;

            labelClass = "map_label";
            if (adminProps.dist_code)
                labelClass += " dist_" + adminProps.dist_code;
            if (adminProps.upaz_code)
                labelClass += " upaz_" + adminProps.upaz_code;

            labelOptions.boxClass = labelClass;

            var polygonLabel = new InfoBox(labelOptions);
            polygonLabel.open(map);
        } catch (e) {
        }
    });

    var legend;
    for (var ci = 0; ci < clrClass.length; ci++) {
        if (ci == 0) {
            legend = " < " + delt;
        } else if (ci == clrClass.length - 1) {
            legend = " >= " + (delt * ci);
        } else {
            legend = (delt * ci) + " - " + (delt * (ci + 1) - 1);
        }

        $("#map_legend_colors").append("<label class='map_legend_label'>" +
            "<label class='map_legend_color' style='background-color:" +
            clrClass[ci] +
            ";'></label>" +
            legend +
            "</label><br/>");
    }

    $("#survey_count").html("Total no. of Branches: " + totalValue);

    $("#map_legend_colors").append("<label class='map_legend_label'>" +
        "<label class='map_legend_color' style='background-color:" +
        noDataClass +
        ";'> </label>No data</label>");

    set_map_filter();
}


function GetGeoPaths(geoCoordinates, isMultiPoly = false) {
    if (typeof (google) == "undefined") {
        return null;
    }

    var path = [], paths = [], geoPoint, ci, pc, cpc;

    if (!isMultiPoly) {
        for (ci = 0; ci < geoCoordinates.length; ci++) {
            for (cpc = 0; cpc < geoCoordinates[ci].length; cpc++) {
                geoPoint = new google.maps.LatLng(geoCoordinates[ci][cpc][1], geoCoordinates[ci][cpc][0]);
                path.push(geoPoint);
            }
        }
        paths.push(path);
    } else {
        for (pc = 0; pc < geoCoordinates.length; pc++) {
            path = [];
            for (ci = 0; ci < geoCoordinates[pc].length; ci++) {
                for (cpc = 0; cpc < geoCoordinates[pc][ci].length; cpc++) {
                    geoPoint = new google.maps.LatLng(geoCoordinates[pc][ci][cpc][1],
                        geoCoordinates[pc][ci][cpc][0]);
                    path.push(geoPoint);
                }
            }
            paths.push(path);
        }
    }

    return paths;
}

function set_map_filter() {
    var upzCode = $("#bd_info_upazila").val();
    if (upzCode) {
        set_upazila_map(upzCode);
        $("#map_label_opt").prop("checked", "checked");
    } else {
        var distCode = $("#bd_info_district").val();
        set_district_map(distCode);

        if (distCode) {
            $("#map_label_opt").prop("checked", "checked");
        } else {
            $("#map_label_opt").prop("checked", "");
        }
    }

    //            map_label_show_hide($("#map_label_opt").prop("checked"));
}

function set_district_map(distId) {

    $("#busy-indicator").fadeIn();

    var l;
    if (!distId) {
        for (l = 0; l < all_map_poly.length; l++) {
            all_map_poly[l].map_poly.setMap(map);
        }
        map.setCenter(bd_center);
        map.setZoom(7);
    } else {
        var distCenter;
        for (l = 0; l < all_map_poly.length; l++) {
            if (all_map_poly[l].dist_code != distId)
                all_map_poly[l].map_poly.setMap(null);
            else {
                all_map_poly[l].map_poly.setMap(map);
                distCenter = all_map_poly[l].center;
            }
        }

        if (distCenter) {
            map.setCenter(distCenter);
            map.setZoom(9);
        }
    }

    map_label_show_hide($("#map_label_opt").prop("checked"));

    $("#busy-indicator").fadeOut();
    $("#map_info").fadeIn(500);
    return false;
}

function set_upazila_map(upazId) {

    $("#busy-indicator").fadeIn();

    for (var l = 0; l < bd_all["upaz"].features.length; l++) {
        if (all_map_poly[l].upaz_code != upazId) {
            all_map_poly[l].map_poly.setMap(null);
        } else {
            all_map_poly[l].map_poly.setMap(map);
        }
    }

    $("#busy-indicator").fadeOut();

    $("#map_info").fadeIn(500);
    return false;
}
