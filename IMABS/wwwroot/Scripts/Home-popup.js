var WpExpDays = 58;

var WpCampaign = "J-AU-3089";
//var WpImgURL = "@Model.homePopupDetails.Image";
//var WpTargetURL = "@Model.homePopupDetails.FindoutMoreLink";
var WpTargetURL2 = "";
var WpTargetURL3 = "";
var ResellerStr = '';

function createCookie() {
    $.cookie('Wpopup', WpCampaign.toString(), {
        expires: WpExpDays,
        path: '/'
    });
}

function Toogle_WCinput() {
    if ($('#wcpopupmode').is(":checked") == true) {
        $(".wcpopupclose").attr("id", "wcpopupclose-OFF");
    }
    else {
        $(".wcpopupclose").attr("id", "wcpopupclose");
    }

};

function closeModal() {
    if ($('#wcpopupmode').is(":checked") == true) {
        createCookie();
    }
    if (!$('#myModal').hasClass('hide')) {
        $('#myModal').addClass('hide');
    }

    if ($('#myModal').hasClass('show')) {
        $('#myModal').removeClass('show');
    }

    $('body').removeClass('modal-open');

    $('.modal-backdrop').remove();
    $("[id='myModal']").remove();
    $("#p_lt_ctl00_pageplaceholder_p_lt_ctl06_WelcomePopup_lnkBanner").attr("style", "display:none");

}

function redirectHome() {
    window.open(
        WpTargetURL,
        '_blank'
    );
}

function redirect2() {
    window.open(
        WpTargetURL2,
        '_blank'
    );
}

function redirect3() {
    window.open(
        WpTargetURL3,
        '_blank'
    );
}
$(window).on("resize", function () {

    if ($('#myModal').hasClass('show')) {
        alignModal();
    }

});

function alignModal() {

    let modalDialog = $("#myModal").find(".modal-dialog");
    if ($(window).width() >= 768)
        modalDialog.css("margin-top", 100);
    else
        modalDialog.css("margin-top", Math.max(0, ($(window).height() - modalDialog.height()) / 2));

}

function display_camp() {
    if ($.cookie('Wpopup') != WpCampaign.toString()) {


        var htmlContent = '';
        htmlContent += '<div class="modal hide" id="myModal" role="dialog" style="display:none">';
        htmlContent += '<div class="modal-dialog "><!-- Modal content-->';
        htmlContent += '<div class="modal-content">';
        htmlContent += '<div class="modal-header"><span class="wcpopupclose" id="wcpopupclose" onclick="closeModal();">&times;</span></div>';

        htmlContent += '<div class="modal-body ">';
        htmlContent += '<div id="RedesignWelcomePopup">';
        htmlContent += '<div class="row">';
        htmlContent += '<h1 align="center" style="padding-top:2%"><b>' + Heading + '</b> &nbsp;</h1>';
        htmlContent += '</br></div>';

        htmlContent += '<div class="row"><span class="welcomelink" onclick=redirectHome();><img broder="0" class="img-responsive" id="wp_image" src="' + imgSrc + '" /></span></div>';
        htmlContent += '<div align="center" onclick="closeModal();" class="pop-up-action padding-top-lg font-16" style="padding-bottom:2%;font-weight:bold"><span class="continue">' + siteLinkText + '</span><span class="welcomelink" onclick=redirectHome();>' + findoutMoreLinkText + '</span></div>';
        htmlContent += '</div>';
        htmlContent += '</div>';
        htmlContent += '</div>';
        htmlContent += '</div>';
        htmlContent += '</div>';
        $("body").append(htmlContent);


        if ($('#myModal').attr("style") !== typeof undefined && $('#myModal').attr("style") !== false) {
            $('#myModal').removeAttr("style")
        }

        if ($('#myModal').hasClass('hide')) {
            $('#myModal').removeClass('hide');
        }

        if (!$('#myModal').hasClass('show')) {
            $('#myModal').addClass('show');
        }

        //$("#myModal").modal({

        //    backdrop: 'static',
        //    keyboard: false
        //});
        $('#myModal').appendTo("body").modal('show');
        $('body').removeAttr('style');

        $("#p_lt_ctl00_pageplaceholder_p_lt_ctl06_WelcomePopup_lnkBanner").attr("style", "display:block");
        $("#p_lt_ctl00_pageplaceholder_p_lt_ctl06_WelcomePopup_lnkBanner").removeAttr("href");
        $("#p_lt_ctl00_pageplaceholder_p_lt_ctl06_WelcomePopup_lnkBanner").removeAttr("onclick");
        $("#p_lt_ctl00_pageplaceholder_p_lt_ctl06_WelcomePopup_lnkBanner").removeAttr("onmouseup");


        window.dataLayer = window.dataLayer || [];
        window.dataLayer.push({
            'event': 'WelcomePopup_Displayed',
            'value': WpCampaign.toString()
        });

    } else {

        if (!$('#myModal').hasClass('hide')) {
            $('#myModal').addClass('hide');
        }

        if ($('#myModal').hasClass('show')) {
            $('#myModal').removeClass('show');
        }

    }
}
$(document).ready(function () {
    $("#p_lt_ctl00_pageplaceholder_p_lt_ctl06_WelcomePopup_lnkBanner").attr("style", "display:none");

    display_camp();
    let popupwidth = $(window).width();
    let popupheight = $(window).height();

    let iconwidth = (popupwidth / 100) * 3;
    let iconheight = (popupwidth / 100) * 3;
    $('.wcpopup-icon-image').width(iconwidth).height(iconheight);

});