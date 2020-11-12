'use strict';
torbaliBurada.controller('RegisterLoginControlCtrl', function ($scope, IlanEkleservice, $location) {

    $scope.loadSession = function() {
        var accesstoken = localStorage.getItem('accessToken');
        $scope.userName = localStorage.getItem('userName');
        if (accesstoken === null) {
            window.location.href = "/Home/Login";
            // window.location.href = '/Login/Index';
           // $location.path("/Home/Login");
        }
        //if (accesstoken != "") {
        //    var authHeaders = {};
        //    if (accesstoken) {
        //        authHeaders.Authorization = 'Bearer ' + accesstoken;
        //    }
        //    return "";
        //}
        //else {
        //    window.location.href = '/Login/Index';
        //}
    };
});