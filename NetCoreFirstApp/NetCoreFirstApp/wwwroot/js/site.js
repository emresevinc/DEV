$(document).ready(function () {
    debugger;
    GetDeparmentListFromCache();
});

var GetDeparmentListFromCache = function () {
    var dataList = null;
    $.ajax({
        type: 'GET',
        url: '/Home/GetDepartmentAllCacheList',
        dataType: 'json',
        success: function (data) {
            dataList = data;
            console.log(data);
        },
        error: function (error) {
            console.log(error);
        }
    })
    if (dataList != null) {
        console.log(dataList);
    }
}