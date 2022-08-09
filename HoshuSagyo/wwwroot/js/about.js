$(document).ready(function () {
    let pathname = $(location).attr("pathname");
    let actionname = pathname.slice(pathname.lastIndexOf("/") + 1);
    console.log(actionname);
    if (actionname === "About") {
        $("#about").addClass("active");
    }
    else if (actionname === "TransitionDiagram") {
        $("#transitionDiagram").addClass("active");

    }
    else if (actionname === "ScreenExplanation") {
        $("#screenExplanation").addClass("active");
    }
    else if (actionname === "Usage") {
        $("#usage").addClass("active");
    }
});