var torbaliBurada = angular.module('torbaliBurada', ['ngMessages', 'mgcrea.ngStrapDocs', 'angularUtils.directives.dirPagination', 'me-lazyload', 'infinite-scroll', 'ngRoute', 'ui.bootstrap', 'ocNgRepeat', 'vcRecaptcha']);
angular.module('infinite-scroll').value('THROTTLE_MILLISECONDS', 250);

torbaliBurada.config(function ($routeProvider, $locationProvider) {

    //$locationProvider.html5Mode({
    //    enabled: false,
    //    requireBase: false
    //});
   // $locationProvider.hashPrefix('!');
    // $locationProvider.html5Mode(true);
    $locationProvider.html5Mode(false).hashPrefix('!'); 
    $routeProvider
        .when('/', {
            templateUrl: '/Home/Index',
            controller: 'WebSiteController'
        })
         .when('/Home', {
             templateUrl: '/Home/Index',
             controller: 'WebSiteController'
         })
        .when("/Register", {
            templateUrl: "/Home/Register",
            controller: "loginController"
        })
        .when("/Login", {
            templateUrl: "/Home/Login",
            controller: "loginController"
        })
        .when("/Search", {
            templateUrl: "/Home/Search",
            controller: "WebSiteController"
        })
        .when("/ProfilPage", {
            templateUrl: "/Home/ProfilPage",
            controller: "InfinityScrollController"
        })
        .when("/Create", {
            templateUrl: "/Home/Create",
            controller: "IlanEkleController"
        })
        .when("/Contact", {
            templateUrl: "/Home/Contact",
            controller: "WebSiteController"
        })
         .when("/Musteriler", {
             templateUrl: "/Home/Musteriler",
             controller: "MusterilerController"
         })
         .when("/MusteriEkle", {
             templateUrl: "/Home/MusteriEkle",
             controller: "MusterilerController"
         })
        .when("/MusteriIlan", {
            templateUrl: "/Home/MusteriIlan",
            controller: "MusterilerController"
        })
        .when("/Home/IlanDetay/:id", {
            templateUrl: "/Home/IlanDetay",
            controller: "IlanDetay"

        })
        .otherwise({ redirectTo: '/' });
});   

torbaliBurada.run(function ($rootScope, $location, $route, $timeout) {

   
    $rootScope.layout = {};
    $rootScope.layout.loading = false;
   
    $rootScope.$on('$routeChangeStart', function () {
        
        //show loading gif
        $timeout(function () {
            $rootScope.layout.loading = true;
        });
    });
    $rootScope.$on('$routeChangeSuccess', function () {
       
        //hide loading gif
        $timeout(function () {
            $rootScope.layout.loading = false;
        }, 200);
    });
    $rootScope.$on('$routeChangeError', function () {

        //hide loading gif
       //alert('wtff');
       $rootScope.layout.loading = false;

    });
});

(function () {
    angular.module('angularRecaptcha', ['vcRecaptcha'])

	.controller('loginController', ['vcRecaptchaService', '$http', function (vcRecaptchaService, $http) {
            "use strict";
            var vm = this;
	    vm.publicKey = "6Lf_riMUAAAAALgOVC2HfzGs0UNk6Ygg1DPNomAx";
	    vm.signup = function () {

	        /* vcRecaptchaService.getResponse() gives you the g-captcha-response */

	        if (vcRecaptchaService.getResponse() === "") { //if string is empty
	            alert("Please resolve the captcha and submit!");
	        } else {
	            var post_data = {  //prepare payload for request
	                //'name': vm.name,
	                //'email': vm.email,
	                //'password': vm.password,
	                'g-recaptcha-response': vcRecaptchaService.getResponse()  //send g-captcah-reponse to our server
	            };

	            /* Make Ajax request to our server with g-captcha-string */
	            $http.post('/api/Search/Recaptcha/', post_data).success(function (response) {
	                if (response.error === 0) {
	                    alert("Successfully verified and signed up the user");
	                } else {
	                    alert("User verification failed");
	                }
	                })
	                .error(function (error) {

                });
	        }
	    };
	}]);
})();

var app = angular.module('mgcrea.ngStrapDocs', ['ngAnimate', 'ngSanitize', 'mgcrea.ngStrap']);
'use strict';
angular.module('mgcrea.ngStrapDocs')


.config(function ($asideProvider) {
    angular.extend($asideProvider.defaults, {
        container: 'body',
        html: true
    });
})
.config(function ($asideProvider) {
    angular.extend($asideProvider.defaults, {
        animation: 'am-fadeAndSlideLeft',
        placement: 'left'
    });

});
