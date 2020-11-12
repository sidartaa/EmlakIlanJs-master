'use strict';
torbaliBurada.service("sessionSecvice", function ($http, $window, $location) {
    var accesstoken = localStorage.getItem('accessToken');
   
    if (accesstoken != "")
    {
       
        if (accesstoken)
        {
            authHeaders.Authorization = 'Bearer ' + accesstoken;
        }
    }
    else
    {
        $location.path("/Login")
       // window.location.href = '/Login/Index';
        
    }


});