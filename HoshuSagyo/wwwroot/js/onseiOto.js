
$(document).ready(function () {

    // 作業開始：音声応答種別ドロップダウン選択項目を変更した時の処理
    $("#kaishiShubetsuList").change(function () {
        // 選択された種別に対応するメッセージの一覧を取得します
        $.ajax({
            type: "Post",
            url: "/Utility/GetOnseiOtoShosai",
            data: { "OtoShubetsu": $("#kaishiShubetsuList").val() },
            dataType: "json"
        }).done(function (response) {
            var items = '';
            $(response).each(function () {
                items += "<option value=" + this.value + ">" + this.text + "</option>";
            })
            $("#kaishiMessageList").html(items);
        });

        // エラーメッセージをクリア
        $("#kaishi-shubetsu-error").text("");
        $("#kaishi-message-error").text("");
    });

    // 作業開始：音声応答メッセージドロップダウン選択項目を変更した時の処理
    $("#kaishiMessageList").change(function () {
         // エラーメッセージをクリア
        $("#kaishi-message-error").text("");
    });

    // 作業終了：音声応答種別ドロップダウン選択項目を変更した時の処理
    $("#shuryoShubetsuList").change(function () {
        // 選択された種別に対応するメッセージの一覧を取得します
        $.ajax({
            type: "Post",
            url: "/Utility/GetOnseiOtoShosai",
            data: { "OtoShubetsu": $("#shuryoShubetsuList").val() },
            dataType: "json"
        }).done(function (response) {
            var items = '';
            $(response).each(function () {
                items += "<option value=" + this.value + ">" + this.text + "</option>";
            })
            $("#shuryoMessageList").html(items);
        });

        // エラーメッセージをクリア
        $("#shuryo-shubetsu-error").text("");
        $("#shuryo-message-error").text("");
    });

    // 作業終了：音声応答メッセージドロップダウン選択項目を変更した時の処理
    $("#shuryoMessageList").change(function () {
        // エラーメッセージをクリア
        $("#shuryo-message-error").text("");
    });

    // 設定ボタン押下時の処理
    $("#btn-setting").click(function () {

        let inputOkFlg = true;

        // 入力状態をチェック
        if ($("#kaishiShubetsuList").val() === "") {
            $("#kaishi-shubetsu-error").text("音声応答種別を選択してください");
            inputOkFlg = false;
        }
        if ($("#kaishiMessageList").val() === "") {
            $("#kaishi-message-error").text("音声応答メッセージを選択してください");
            inputOkFlg = false;
        }
        if ($("#shuryoShubetsuList").val() === "") {
            $("#shuryo-shubetsu-error").text("音声応答種別を選択してください");
            inputOkFlg = false;
        }
        if ($("#shuryoMessageList").val() === "") {
            $("#shuryo-message-error").text("音声応答メッセージを選択してください");
            inputOkFlg = false;
        }

        if (inputOkFlg === true) {
            // モーダルを閉じる
            $("#btn-close").click();
        }
    });

    // 閉じるボタン押下時の処理
    $("#btn-close").click(function () {
        // エラーメッセージを全てクリア
        clearAllErrorMassage();
    });

    // 「×」ボタン押下時の処理
    $(".btn-close").click(function () {
        // エラーメッセージを全てクリア
        clearAllErrorMassage();
    });

    // 入力チェックエラー時のメッセージをクリアする
    function clearAllErrorMassage() {
        $("#kaishi-shubetsu-error").text("");
        $("#kaishi-message-error").text("");
        $("#shuryo-shubetsu-error").text("");
        $("#shuryo-message-error").text("");
    }
}); 