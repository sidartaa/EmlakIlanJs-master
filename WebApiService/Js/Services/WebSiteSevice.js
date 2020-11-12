'use strict';
torbaliBurada.service("WebSiteService", function ($http, $window) {
    this.search = function (page) {

        var resp = $http({
            method: 'GET',
            url: '/api/Search/DefaultS/',
            params: page //JSON.stringify(userInfo), // userInfo,
            //headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=utf-8' },
            //contentType: 'application/json',

        });

        return resp;
    };
    this.location = function (config) {
        var response = $http({
            url: "/api/EmlakLocation/GetEmlakLocation",
            method: "GET",
            params: config
           // headers: authHeaders
        });
        return response;
    };
    this.kategoriSearch = function (page) {

        var resp = $http({
            method: 'GET',
            url: '/api/Search/Default/Emlak/',
            params: page //JSON.stringify(userInfo), // userInfo,
            //headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=utf-8' },
            //contentType: 'application/json',

        });

        return resp;
    };

    this.getImage = function (page) {
        var resp = $http({
            method: 'GET',
            url: '/api/Search/Default/Images/',

            params: page //JSON.stringify(userInfo), // userInfo,
            //headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=utf-8' },
            //contentType: 'application/json',

        });

        return resp;

    };
    //loadSession();    
    this.kategoriler = function (config) {
        var response = $http({
            url: "/api/EmlakKategoriler/GetEmlakKategori",
            method: "GET",
            params: config

        });
        return response;
    };
    this.getIlanDetay = function (config) {
        var response = $http({
            url: "/api/Search/Default/IlanDetay",
            method: "GET",
            params: config

        });
        return response;
    };
    this.EmlakKonutTipi = function () {
        var response = $http({
            url: "/api/EmlakKonutTipi/EmlakKonutTipi",
            method: "GET"
            //headers: authHeaders
        });
        return response;
    };
    this.EmlakTapuDurumu = function () {
        var response = $http({
            url: "/api/EmlakTapuDurumu/EmlakTapuDurumu",
            method: "GET"
            //headers: authHeaders
        });
        return response;
    };
    this.EmlakImarDurumu = function () {
        var response = $http({
            url: "/api/EmlakImarDurumu/EmlakImarDurumu",
            method: "GET"
            // headers:authHeaders
        });
        return response;
    };
    this.EmlakKullanimAmaci = function () {
        var response = $http({
            url: "/api/EmlakKullanimAmaci/EmlakKullanimAmaci",
            method: "GET"
        });
        return response;
    };
    var accesstoken = $window.localStorage.getItem('accessToken');
    var authHeaders = {};
    if (accesstoken !== null) {
        if (accesstoken) {
            authHeaders.Authorization = 'Bearer ' + accesstoken;
        }
        }
        this.DeleteImages = function (config) {
            var response = $http({
                url: "/api/Upload/DeleteImages",
                method: "GET",
                params: config,
                headers: { "Authorization": 'Bearer ' + $window.localStorage.getItem('accessToken') }
            });
            return response;
        };
        this.GetImages = function (config) {
            var response = $http({
                url: "/api/Upload/GetImages",
                method: "GET",
                params: config,
                headers: { "Authorization": 'Bearer ' + $window.localStorage.getItem('accessToken') }
            });
            return response;
        };
        this.getIlan = function (config) {
           // alert($window.localStorage.getItem('accessToken'));
            var response = $http({
                url: "/api/Search/Default/GetIlan",
                method: "GET",
                params: config,
                headers: { "Authorization": 'Bearer ' + $window.localStorage.getItem('accessToken') }
            });
            return response;
        };
        this.updateIlan = function (update) {
            var resp = $http({
                url: "/api/Search/Default/UpdateIlan/",
                method: "POST",
                data: $.param({
                    id: update.id,
                    Baslik: update.Baslik,
                    Aciklama: update.Aciklama,
                    Fiyat: update.Fiyat,
                    MetreKare: update.MetreKare,
                    Private: update.Private,
                    UserName: update.UserName,
                    TakasliID: update.TakasliID,
                    CepTelefonu: update.CepTelefonu,
                    TakasTuru: update.TakasTuru,
                    Sahibi: update.Sahibi,
                    Ada: update.Ada,
                    Pafta: update.Pafta,
                    Parsel: update.Parsel,
                    IletisimTelefonu: update.IletisimTelefonu
                    
                }),
                headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=utf-8', 'Authorization': authHeaders.Authorization },
                contentType: 'application/json'
                // headers: authHeaders

            });

            return resp;
        };
   
    //else {
        
//user control finish
   // }
    

});
