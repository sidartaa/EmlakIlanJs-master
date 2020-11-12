torbaliBurada.service('profilPageServic', function ($http) {
    this.getGenelIlanlar = function (info) {
        var data = {
            
            userName: info.usetName
        };
        var resp = $http({
            url: "/api/Search/Default/",
            method: "GET",
            params: data,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=utf-8' },
            contentType: 'application/json'

        });

        return resp;
    };
    this.getiIanIlanlar = function (info) {
        var data = {
            skip: info.skip,
            take: info.take,
            userName: info.usetName
        };
        var resp = $http({
            url: "/api/Search/Default/",
            method: "GET",
            params: data, 
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=utf-8' },
            contentType: 'application/json'

        });

        return resp;
    };
    this.getiIanIlanlarAll = function () {
        var data = {
            userName: localStorage.getItem('userName')
        };
        var resp = $http({
            url: "/api/Search/Default/All",
            method: "GET",
            params: data,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=utf-8' },
            contentType: 'application/json'

        });

        return resp;
    };

});