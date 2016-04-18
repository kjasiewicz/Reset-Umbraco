$(document).ready(function () {
    resizeNews();
    $(window).resize(function () {
        resizeNews();
    });
});

function resizeNews() {
    if ($(window).width() > 769) {
        $(".news-box").each(function () {
            $(this).css("min-height", $(this).siblings(".news-img").height());
        });
    } else {
        $(".news-box").each(function () {
            $(this).css("min-height", "auto");
        });
    }
}

