$(document).ready(function () {
    /*JQuery for Complete Solution Provider Panel on Homepage*/

    jQuery(function () {
        
        var elm1Child = $('.csp-targetdiv');
        jQuery('.csp-targetdiv').hide();
        jQuery(elm1Child[0]).show();
        jQuery($('.csp-show')[0]).addClass("active");

        jQuery('.csp-show').click(function () {
            jQuery('.csp-show').removeClass("active");
            jQuery('.csp-targetdiv').hide();
            jQuery('#csp-' + $(this).attr('target')).show();
            $(this).addClass("active");
        }); 


        /*Slick Slider
            https://www.solodev.com/blog/web-design/how-to-add-an-infinite-client-logo-carousel-to-your-website.stml
            https://kenwheeler.github.io/slick/
        */
        $('.logo-carousel').slick({
            slidesToShow: 6,
            slidesToScroll: 1,
            autoplay: true,
            autoplaySpeed: 3000,
            arrows: true,
            dots: false,
            pauseOnHover: false,
            responsive: [{
                breakpoint: 768,
                settings: {
                    slidesToShow: 4
                }
            }, {
                breakpoint: 520,
                settings: {
                    slidesToShow: 2
                }
            }]
        });    
    });

});
