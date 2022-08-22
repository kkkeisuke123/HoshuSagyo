
$(document).ready(function () {

    // 進捗リンククリック時の処理
    $(".open-modal-link").each(function (i, element) {
        $(element).on("click", function () {
            getSagyoJisseki($(element).attr("id"));
        });
    });

    // 作業計画IDに紐づく作業実績情報を取得する
    function getSagyoJisseki(sagyoKeikakuId) {
        $.ajax({
            type: "Post",
            url: "/Utility/GetSagyoJisseki",
            data: { "SagyoKeikakuId": sagyoKeikakuId },
            dataType: "json"
        }).done(function (response) {
            $("#SagyoKeikakuId").val(response["sagyoKeikakuId"]);
            $("#Shinchoku").val(response["shinchoku"]);
            $("#SagyoChakushuNichiji").val(response["sagyoChakushuNichiji"]);
            $("#SagyoChakushuSekininshaMei").val(response["sagyoChakushuSekininshaMei"]);
            $("#SagyoKanryoNichiji").val(response["sagyoKanryoNichiji"]);
            $("#SagyoKanryoSekininshaMei").val(response["sagyoKanryoSekininshaMei"]);

            deactivation(response["shinchoku"]);
        });
    }

    // 進捗に応じて特定の項目を非活性化する
    function deactivation(shinchoku) {
        // 着手済、終了遅延の場合
        if (shinchoku === 2 || shinchoku === 5) {
            // 着手関連の項目を非活性化
            $("#SagyoChakushuNichiji").attr("readonly", "readonly");
            $("#SagyoChakushuSekininshaMei").attr("readonly", "readonly");
            // 着手済のため、中止はできない
            $("#ChushiFlg").attr("disabled", "disabled");
        }
        // 完了済、中止の場合
        else if (shinchoku === 3 || shinchoku === 6) {
            // 閉じるボタン以外の項目を非活性化
            $("#SagyoChakushuNichiji").attr("readonly", "readonly");
            $("#SagyoChakushuSekininshaMei").attr("readonly", "readonly");
            $("#SagyoKanryoNichiji").attr("readonly", "readonly");
            $("#SagyoKanryoSekininshaMei").attr("readonly", "readonly");
            $("#ChushiFlg").attr("disabled", "disabled");
            $("#btn-update").attr("disabled", "disabled");
        }
    }

    // 中止チェックボックスチェック時の処理
    $("#ChushiFlg").change(function () {
        activeInactiveControl($("#ChushiFlg").prop("checked"));
    });

    // 項目の活性・非活性の制御を行う
    function activeInactiveControl(checked) {
        // チェックされた場合
        if (checked === true) {
            // 着手、終了関連の項目を非活性化
            $("#SagyoChakushuNichiji").attr("disabled", "disabled");
            $("#SagyoChakushuSekininshaMei").attr("disabled", "disabled");
            $("#SagyoKanryoNichiji").attr("disabled", "disabled");
            $("#SagyoKanryoSekininshaMei").attr("disabled", "disabled");
        }
        // チェックが外された場合
        else {
            // 着手、終了関連の項目を活性化
            $("#SagyoChakushuNichiji").removeAttr("disabled");
            $("#SagyoChakushuSekininshaMei").removeAttr("disabled");
            $("#SagyoKanryoNichiji").removeAttr("disabled");
            $("#SagyoKanryoSekininshaMei").removeAttr("disabled");
        }
    }

    // 閉じるボタン押下時の処理
    $("#btn-close").click(function () {
        activation();
        clearAllErrorMassage();
    });

    // 「×」ボタン押下時の処理
    $(".btn-close").click(function () {
        activation();
        clearAllErrorMassage();
    });

    // 項目を活性化する
    function activation() {
        $("#SagyoChakushuNichiji").removeAttr("readonly");
        $("#SagyoChakushuSekininshaMei").removeAttr("readonly");
        $("#SagyoKanryoNichiji").removeAttr("readonly");
        $("#SagyoKanryoSekininshaMei").removeAttr("readonly");
        $("#ChushiFlg").removeAttr("disabled");
        $("#btn-update").removeAttr("disabled");
    }

    // 入力チェックエラー時のメッセージをクリアする
    function clearAllErrorMassage() {
        $("#SagyoChakushuNichiji-error").text("");
        $("#SagyoChakushuSekininshaMei-error").text("");
    }
}); 