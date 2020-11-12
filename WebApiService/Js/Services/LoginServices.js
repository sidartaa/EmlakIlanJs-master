'use strict';
torbaliBurada.service('loginservice', function ($http) {

    this.register = function (userInfo) {
        var resp = $http({
            url: "/api/Account/Register",
            method: "POST",
            data: userInfo
        });
        return resp;
    };

    this.login = function (userlogin) {
       // console.log(userlogin);
        var resp = $http({
            url: "/TOKEN",
            method: "POST",
            data: $.param({ grant_type: 'password', username: userlogin.username, password: userlogin.password }),
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
        });
       
        return resp;
    };
    this.recaptcha = function (userInfo) {
        var resp = $http({
            url: '/api/Search/Recaptcha/',
            method: "POST",
            data: $.param({ Response: userInfo.response, RemoteIp: userInfo.remoteip }),
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
        });
        return resp;
    };
});