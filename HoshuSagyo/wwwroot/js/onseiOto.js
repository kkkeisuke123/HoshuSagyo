
// 音声応答の応答種別（ドロップダウン）が選択されたとき、
// その種別に対応するメッセージの一覧を返します
$(document).ready(function () {
    $("#kaishiShubetsuList").change(function () {

        $.ajax({
            type: "Post",
            url: "/SagyoKeikaku/GetOnseiOtoShosai",
            data: { "OtoShubetsu": $("#kaishiShubetsuList").val() },
            dataType: "json"
        }).done(function (response) {
            var items = '';
            $(response).each(function () {
                items += "<option value=" + this.value + ">" + this.text + "</option>";
            })
            $("#kaishiMessageList").html(items);
        });
    });

    $("#shuryoShubetsuList").change(function () {

        $.ajax({
            type: "Post",
            url: "/SagyoKeikaku/GetOnseiOtoShosai",
            data: { "OtoShubetsu": $("#shuryoShubetsuList").val() },
            dataType: "json"
        }).done(function (response) {
            var items = '';
            $(response).each(function () {
                items += "<option value=" + this.value + ">" + this.text + "</option>";
            })
            $("#shuryoMessageList").html(items);
        });
    });
}); 