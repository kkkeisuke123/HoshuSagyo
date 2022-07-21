
$(document).ready(function () {

    // リンククリックで作業実績情報を取得し、作業実績画面に反映させる
    $(".open-modal-link").each(function (i, element) {
        $(element).on("click", function () {
            getSagyoJisseki($(element).attr("id"));
        });
    });

    function getSagyoJisseki(sagyoKeikakuId) {
        $.ajax({
            type: "Post",
            url: "/AjaxUtility/GetSagyoJisseki",
            data: { "SagyoKeikakuId": sagyoKeikakuId },
            dataType: "json"
        }).done(function (response) {
            $("#SagyoKeikakuId").val(response["sagyoKeikakuId"]);
            $("#SagyoChakushuNichiji").val(response["sagyoChakushuNichiji"]);
            $("#SagyoChakushuSekininshaMei").val(response["sagyoChakushuSekininshaMei"]);
            $("#SagyoKanryoNichiji").val(response["sagyoKanryoNichiji"]);
            $("#SagyoKanryoSekininshaMei").val(response["sagyoKanryoSekininshaMei"]);
        });
    }
}); 