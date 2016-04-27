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

$("#sortList").delegate("#loadNextIndicator", "click", function (e) {
    e.preventDefault();
    var pinnedPostId = parseInt($("#pinnedPostIdInput").val());
    $(".loader-ajax").show();
    $("#parentLoad").hide();
    var page = parseInt($("#lazyPage").val()) + 1;

    $.get(pinnedPostId == undefined ? "/umbraco/surface/Lazy/GetNews?page=" + page : "/umbraco/surface/Lazy/GetNews?page=" + page + "&pinnedPostId=" + pinnedPostId, function (data) {
        $("#parentLoad").remove();
        $("#sortList").append(data);
        $("#lazyPage").val(page);
        $(".loader-ajax").hide();
        resizeNews();
    });
});

