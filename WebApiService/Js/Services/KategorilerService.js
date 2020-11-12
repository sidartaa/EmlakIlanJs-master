'use strict';
torbaliBurada.service("GetParentIdKategorilerService", function ($http) {
    //loadSession();
    var accesstoken = localStorage.getItem('accessToken');
    var authHeaders = {};
   
    if (accesstoken !== null)
    {
      
        if (accesstoken)
        {
            authHeaders.Authorization = 'Bearer ' + accesstoken;
        }
        this.kategoriler = function (config) {
            var response = $http({
                url: "/api/EmlakKategoriler/GetEmlakKategori",
                method: "GET",
                params: config,
                headers: authHeaders
            });
            return response;
        };
        this.partial = function (config) {
            var response = $http({
                url: "/Login/PartialGet",
                method: "GET",
                params: config
            });
            return response;
        };

        this.ajaxGet = function (config) {
            var response = $http({
                url: "/Login/EmlakFormuHazirla",
                method: "GET",

            });
            return response;
        };
    }
    else {
       
        localStorage.removeItem('accessToken');
        window.location.href = '/Login';
        
        
    }
});