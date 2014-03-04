(function (window) {
    // Note: _lhc stands for LeatherHeadComp
    var _lhc = function () {
        var currentPopup = null,
        
        init = function() {
            var path = window.location.pathname;
            path = path.replace(/\/$/, "");
            path = decodeURIComponent(path);

            $("nav a").each(function () {
                var href = $(this).attr('href');
                if ((href.length == 1 && path.length == 0) || (href.length > 1 && path.substring(0, href.length) === href)) {
                    $(this).closest('li').addClass('active');
                }
            });
        },
            
        nonModelPopup = function() {

            $(".popup-container").hover(function () {
            }, function() {
                if (currentPopup != null) {
                    currentPopup.animate({ opacity: "hide" }, "fast");
                    currentPopup = null;
                }
            });

            $(".popup-trigger").hover(function() {

                var id = $(this).attr("id").replace("pop_trig", "pop_cont");
                var popup = $('#' + id);

                if (currentPopup != null && currentPopup.attr("id") == popup.attr("id")) {
                    return;
                }

                if (currentPopup != null && currentPopup.attr("id") != popup.attr("id")) {
                    currentPopup.animate({ opacity: "hide" }, "fast");
                }

                var pos = $(this).position();

                popup.css('left', pos.left + 70);
                popup.css('top', pos.top);

                popup.stop(true, true).animate({ opacity: "show" }, "slow");

                currentPopup = popup;

            });
        };
        return {
            init: init,
            nonModelPopup: nonModelPopup,
        };

    }();

    window.lhc = _lhc;

})(window)