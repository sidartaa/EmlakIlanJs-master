"use strict";
torbaliBurada.controller("IlanDetay",
    function($scope,
        $http,
        $sce,
        WebSiteService,
        $aside,
        $anchorScroll,
        $location,$log,$route, $routeParams) {

       
        var url = window.location.pathname.split('/'); // $location.path().split('/');
        $scope.zero = url[0];
        $scope.one = url[1];
        $scope.firstParameter = url[2];
        $scope.secondParameter = url[3];
        // Using $routeParams
        $scope.param1 = url;
       // $scope.param2 = window.location.pathname.split('/');

        var baseUri = window.location.href;
        //Removes any # from href (optional)
        if (baseUri.slice(baseUri.length - 1, baseUri.length) === "#")
            baseUri = baseUri.slice(0, baseUri.length - 1);
        var split = window.location.pathname.split('/');
        if (split.length > 2)
            baseUri = baseUri.replace(window.location.pathname, '') + "/" + split[1] + "/";
        //This will append the last slash
        if (baseUri.substring(baseUri.length - 1, baseUri.length) !== "/")
            baseUri += "/";
        $scope.param2 = baseUri;
    });
