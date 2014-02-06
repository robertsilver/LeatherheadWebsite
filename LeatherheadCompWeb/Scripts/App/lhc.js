(function (window) {
    // Note: _lhc stands for LeatherHeadComp
    var _lhc = function () {
        var currentPopup = null,
        
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
            nonModelPopup: nonModelPopup,
        };

    }();

    window.lhc = _lhc;

})(window)