function fnDecimalonkeyDown(obj, evt, dp) {
    var a = obj.value.split(".");
    var charCode = evt.which ? evt.which : event.keyCode;
    if (a.length == 2) {
        dp = dp == undefined ? 2 : dp;
        if (a[1].length > dp) return false;
    }
    if ((charCode == 110 || charCode == 190 || charCode == 46) && a.length > 1) return false;
    if ((charCode == 110 || charCode == 190 || charCode == 46)) return true;
    if (charCode == 8) return true;
    if (charCode > 47 && charCode < 58) return true;
    return false;
}
function fnNumberKeyDown(obj, evt) {
    var charCode = evt.which ? evt.which : event.keyCode;
    if (charCode == 8) return true;
    if (charCode > 47 && charCode < 58) return true;
    if (charCode > 95 && charCode < 106) return true;
    if (charCode == 46 || charCode == 37 || charCode == 39 || charCode == 9) return true;
    return false;
}