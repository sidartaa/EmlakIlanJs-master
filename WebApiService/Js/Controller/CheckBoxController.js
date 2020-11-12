'use strict';
torbaliBurada.controller('emlakOzellikleriCtrl', function ($scope, IlanEkleservice,  $http, $sce) {
   
    $scope.emlakTapuDurumu = [];
    $scope.emlakSiteIcerisinde = [];
    $scope.emlakOdaSayisi = [];
    $scope.emlakIcOzellikler = [];
    $scope.emlakDisOzellikler = [];
    $scope.emlakIsitmaSekli = [];
    $scope.emlakBulunduguKat = [];
    $scope.emlakEmlakTakasli = [];

    $scope.Message = "";
    $scope.userName = localStorage.getItem('userName');// localStorage.setItem('userName', resp.data.userName);
    $scope.getHtml = "";
    loadEmlakTapuDurumu();
    loadEmlakSiteIcerisinde();
    loadEmlakOdaSayisi();
    loadEmlakTakasli();
    loadBulunduguKat();
    loadIsitmaSekli();
    loadDisOzellikler();
    loadIcOzellikler();

    $scope.emlakIlanModel = {
        baslik: '',
        aciklama: '',
        fiyat: '',
        metrekare: '',
        takas: '',
        kimdem: '',
        odaSayisi: '',
        bulunduguKat: '',
        isitma: '',
        disOzelllik: '',
        icOzellik: ''

    };

    function loadIcOzellikler() {
        var query = IlanEkleservice.EmlakIcOzellikler();

        query.then(function (resp) {
            $scope.emlakIcOzellikler = resp.data;
            $scope.Message = "İç Özellikler Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status
        });
    }
    function loadDisOzellikler() {
        var query = IlanEkleservice.EmlakTapuDurumu();

        query.then(function (resp) {
            $scope.emlakDisOzellikler = resp.data;
            $scope.Message = "Dis Ozellikler Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status
        });
    }
    function loadIsitmaSekli() {
        var query = IlanEkleservice.EmlakIsitmaSekli();

        query.then(function (resp) {
            $scope.emlakIsitmaSekli = resp.data;
            $scope.Message = "Isıtma Durumu Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status
        });
    }
    function loadBulunduguKat() {
        var query = IlanEkleservice.EmlakBulunduguKat();

        query.then(function (resp) {
            $scope.emlakBulunduguKat = resp.data;
            $scope.Message = "Tapu Durumu Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status
        });
    }
    function loadEmlakTakasli() {
        var query = IlanEkleservice.EmlakTakasli();

        query.then(function (resp) {
            $scope.emlakEmlakTakasli = resp.data;
            $scope.Message = "Tapu Takasli Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status
        });
    }
    ////
    function loadEmlakTapuDurumu() {
        var tapuDurumu = IlanEkleservice.EmlakTapuDurumu();

        tapuDurumu.then(function (resp) {
            $scope.emlakTapuDurumu = resp.data;
            $scope.Message = "Tapu Durumu Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status
        });
    }
    function loadEmlakSiteIcerisinde() {
        var siteIcerisinde = IlanEkleservice.EmlakSiteIcerisinde();

        siteIcerisinde.then(function (resp) {
            $scope.emlakSiteIcerisinde = resp.data;
            $scope.Message = "Site Içerisinde Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status
        });
    }
    function loadEmlakOdaSayisi() {
        var emlakOdaSayisi = IlanEkleservice.EmlakOdaSayisi();

        emlakOdaSayisi.then(function (resp) {
            $scope.emlakOdaSayisi = resp.data;
            $scope.Message = "Oda Sayısı Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status
        });
    }

   
    $scope.logout = function () {

        localStorage.removeItem('accessToken');
        $location.path("/Login")
    };
});

