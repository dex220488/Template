var pathBase = $("#global-schema").val() + "://" + $("#global-host").val() + $("#global-pathBase").val();
$(function () {
    var controllerName = $("#global-controller").val();
    var actionName = $("#global-action").val();
    var jsFullPath = pathBase + "/js/controllers/" + controllerName + "/" + actionName + ".js";
    console.log(jsFullPath);
    if (UrlExists(jsFullPath)) {
        $.getScript(jsFullPath);
    }
});

function UrlExists(url) {
    var http = new XMLHttpRequest();
    http.open('HEAD', url, false);
    http.send();
    return http.status != 404;
}