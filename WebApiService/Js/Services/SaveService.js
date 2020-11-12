'use strict';
torbaliBurada.service('IlanService', function ($http) {
    var accesstoken = localStorage.getItem('accessToken');
    var authHeaders = {};

    if (accesstoken) {
        authHeaders.Authorization = 'Bearer ' + accesstoken;
    }
    this.ekle = function (userInfo) {
        var resp = $http({
            url: "/api/EmlakIlanlar/IlanEkle/",
            method: "POST",            
            data: $.param({
                //SatilikId: userInfo.SatilikId,
                //id: userInfo.id,
                //IcOzellikler: JSON.stringify(userInfo.IcOzellikler),
                id: userInfo.id,
                SatilikId: userInfo.SatilikId,
                SemtId: userInfo.SemtId,
                MahalleId: userInfo.MahalleId,
                Baslik: userInfo.Baslik,
                Aciklama: userInfo.Aciklama,
                Fiyat: userInfo.Fiyat,
                Metrekare: userInfo.Metrekare,
                TakasliID: userInfo.TakasliID,
                OdaSayisi: userInfo.OdaSayisi,
                BulunduguKat: userInfo.BulunduguKat,
                Isitma: userInfo.Isitma,
                IcOzellikler: JSON.stringify(userInfo.IcOzellikler),
                DisOzellikler: JSON.stringify(userInfo.DisOzellikler),
                KonutTipi: userInfo.KonutTipi,
                Private: userInfo.Private,
                EmlakImarDurumu: userInfo.EmlakImarDurumu,
                EmlakTapuDurumu: userInfo.EmlakTapuDurumu,
                EmlakKullanimAmaci: userInfo.EmlakKullanimAmaci,
                UserName: userInfo.UserName
                
            }), //JSON.stringify(userInfo), // userInfo,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=utf-8', 'Authorization': authHeaders.Authorization },
            contentType: 'application/json'

        });

        return resp;
    };

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

    }

});
