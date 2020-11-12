'use strict';
torbaliBurada.service('IlanEkleservice', function ($http, $httpParamSerializerJQLike) {
    var accesstoken = localStorage.getItem('accessToken');
    var authHeaders = {};

    if (accesstoken) {
        authHeaders.Authorization = 'Bearer '+accesstoken;
    }
    this.musterisearch = function (page) {

        var resp = $http({
            method: 'GET',
            url: '/api/MusteriList/MusteriListesi/',
            params: page,
            headers: authHeaders


        });

        return resp;
    };
    this.musteriekle = function (musteri) {
        var resp = $http({
            url: "/api/MusteriList/MusteriEkle/",
            method: "POST",
            data: $.param({
                Ad: musteri.Ad,
                Soyad: musteri.Soyad,
                Email: musteri.Email,
                CepTelefonu: musteri.CepTelefonu,
                EnDusukFiyat: musteri.EnDusukFiyat,
                EnYuksekFiyat: musteri.EnYuksekFiyat,
                Statu: musteri.Statu,
                Kategori: JSON.stringify(musteri.Kategori),
                Location: JSON.stringify(musteri.Location),
                Tur: JSON.stringify(musteri.Tur),
                Semt: JSON.stringify(musteri.Semt)

            }),
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=utf-8', 'Authorization': authHeaders.Authorization },
            contentType: 'application/json'
        });

        return resp;
    };
    this.ekle = function (ilan) {
        var resp = $http({
            url: "/api/EmlakIlanlar/IlanEkle/",
            method: "POST",
            //data: $httpParamSerializerJQLike(ilan),
            data: $.param({
                id: ilan.id,
                IlanKimden: ilan.IlanKimden,
                SatilikId: ilan.SatilikId,
                SemtId: ilan.SemtId,
                MahalleId: ilan.MahalleId,
                Baslik: ilan.Baslik,
                Aciklama: ilan.Aciklama,
                Fiyat: ilan.Fiyat,
                Metrekare: ilan.Metrekare,
                TakasliID: ilan.TakasliID,
                TakasTuru: ilan.TakasTuru,
                Sahibi: ilan.Sahibi,
                CepTelefonu: ilan.CepTelefonu,
                Pafta: ilan.Pafta,
                Parsel: ilan.Parsel,
                Ada: ilan.Ada,
                OdaSayisi: ilan.OdaSayisi,
                BulunduguKat: ilan.BulunduguKat,
                Isitma: ilan.Isitma,
                IcOzellikler: JSON.stringify(ilan.IcOzellikler),
                DisOzellikler: JSON.stringify(ilan.DisOzellikler),
                KonutTipi: ilan.KonutTipi,
                Private: ilan.Private,
                EmlakImarDurumu: ilan.EmlakImarDurumu,
                EmlakTapuDurumu: ilan.EmlakTapuDurumu,
                EmlakKullanimAmaci: ilan.EmlakKullanimAmaci,
                UserName: ilan.UserName,
                IlanTuru: ilan.IlanTuru,
                IletisimTelefonu: ilan.IletisimTelefonu
            }), //JSON.stringify(userInfo), // userInfo,
            headers: { 'Content-Type': "application/x-www-form-urlencoded; charset=utf-8", 'Authorization': authHeaders.Authorization },
            contentType: 'application/json'
            

        });

        return resp;
    };
    //#region Default get query
    this.EmlakKimden = function () {
        var response = $http({
            url: "/api/EmlakKimden/EmlakKimden",
            method: "GET",
            headers: authHeaders
        });
        return response;
    };
    this.EmlakKullanimAmaci = function () {
        var response = $http({
            url: "/api/EmlakKullanimAmaci/EmlakKullanimAmaci",
            method: "GET",
            headers: authHeaders
        });
        return response;
    };
    this.EmlakTapuDurumu = function () {
        var response = $http({
            url: "/api/EmlakTapuDurumu/EmlakTapuDurumu",
            method: "GET",
            headers: authHeaders
        });
        return response;
    };
    this.kategoriler = function (subID) {
        var response = $http({
            url: "/api/EmlakKategoriler/GetEmlakKategori",
            method: "GET",
            params: subID,
            headers: authHeaders
        });
        return response;
    };
    this.location = function (config) {
        var response = $http({
            url: "/api/EmlakLocation/GetEmlakLocation",
            method: "GET",
            params: config,
            headers: authHeaders
        });
        return response;
    };

    this.EmlakImarDurumu = function () {
        var response = $http({
            url: "/api/EmlakImarDurumu/EmlakImarDurumu",
            method: "GET",
            headers: authHeaders
        });
        return response;
    };
    this.EmlakIcOzellikler = function () {
        var response = $http({
            url: "/api/EmlakIcOzellikler/EmlakIcOzellikleri",
            method: "GET",
            headers: authHeaders
        });
        return response;
    };
    this.EmlakDisOzellikler = function () {
        var response = $http({
            url: "/api/EmlakDisOzellikler/EmlakDisOzellikleri",
            method: "GET",
            headers: authHeaders
        });
        return response;
    };
    this.EmlakIsitmaSekli = function () {
        var response = $http({
            url: "/api/EmlakIsitmaTuru/EmlakIsitmaTuru",
            method: "GET",
            headers: authHeaders
        });
        return response;
    };
    this.EmlakBulunduguKat = function () {
        var response = $http({
            url: "/api/EmlakBulunduguKat/BulunduguKat",
            method: "GET",
            headers: authHeaders
        });
        return response;
    };
    this.EmlakTakasli = function () {
        var response = $http({
            url: "/api/EmlakTakasli/EmlakTakasli",
            method: "GET",
            headers: authHeaders
        });
        return response;
    };
    ///
    this.EmlakTapuDurumu = function () {
        var response = $http({
            url: "/api/EmlakTapuDurumu/EmlakTapuDurumu",
            method: "GET",
            headers: authHeaders
        });
        return response;
    };
    this.EmlakSiteIcerisinde = function () {
        var response = $http({
            url: "/api/EmlakSiteIcerisinde/EmlakSiteIcerisinde",
            method: "GET",
            headers: authHeaders
        });
        return response;
    };
    this.EmlakOdaSayisi = function () {
        var response = $http({
            url: "/api/EmlakOdaSayisi/EmlakOdaSayisi",
            method: "GET",
            headers: authHeaders
        });
        return response;
    };
    this.EmlakKonutTipi = function () {
        var response = $http({
            url: "/api/EmlakKonutTipi/EmlakKonutTipi",
            method: "GET",
            headers: authHeaders
        });
        return response;
    };
    //#endregion




});
