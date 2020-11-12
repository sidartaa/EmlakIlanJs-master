'use strict';
torbaliBurada.filter('myCurrency', ['$filter', function ($filter) {
    return function (input) {
        input = parseFloat(input);
        input = input.toFixed(input % 1 === 0 ? 0 : 2);
        return input.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ',') + ' TL';
    };
}]);
torbaliBurada.factory('accessFac', function () {
    var obj = {};
    this.access = false;
    obj.getPermission = function () { //set the permission to true
        var accesstoken = localStorage.getItem('accessToken');
        if (accesstoken === null) {
            // window.location.href = '/Login';
            $location.path("/Login");
            this.access = true;
        }
    };
    obj.checkPermission = function () {
        return this.access; //returns the users permission level 
    };
    return obj;
});
torbaliBurada.controller('profilPageCtrl', function ($window, $scope, $http, profilPageServic, $location) {

    var accesstoken = localStorage.getItem('accessToken');
    $scope.currentPage = 1;
    $scope.pageSize = 15;
    $scope.meals = [];
    if (accesstoken === null) {
        localStorage.removeItem('accessToken');
        window.location.href = '/Home/Login';
        // $location.path("/Login")

        return false;
    }
    else {
        //var userName = localStorage.getItem('userName');
        $scope.default = {
            skip: 1,
            take: 30,
            userName: localStorage.getItem('userName')
        };
        //  ilanlar();
        //-----------------------------------------------------------
        $scope.ilanParameters = {
            id: '',
            SatilikId: '',
            SemtId: '',
            MahalleId: '',
            Baslik: '',
            Aciklama: '',
            Fiyat: '',
            Metrekare: '',
            TakasliID: '',
            OdaSayisi: '',
            BulunduguKat: '',
            Isitma: '',
            IcOzellikler: '',
            DisOzelliker: '',
            KonutTipi: '',
            Private: '',
            EmlakImarDurumu: '',
            EmlakTapuDurumu: '',
            EmlakKullanimAmaci: ''
        };
        $scope.isViewLoading = true;
        
        $scope.aktifIlanlar = function () {

        }
    }
});

torbaliBurada.controller('InfinityScrollController', function ($scope, $http, $window, $location) {

    $scope.Cikis = function() {
        var accesstoken = localStorage.getItem('accessToken');

        if (accesstoken !== null) {
            localStorage.removeItem('accessToken');
            localStorage.removeItem('userName');
            //localStorage.removeItem('refreshToken');
            //localStorage.removeItem("rememberme");
            //localStorage.removeItem('firma');
            $scope.token = false;
            window.location.href = "/Home/Login";
            //$location.path("/Home/Login");
        }
    }

    $scope.function = false;
    $scope.token = false;
    var accesstoken = localStorage.getItem('accessToken');

    if (accesstoken === null) {
        localStorage.removeItem('accessToken');
    }
    else {
        $scope.token = true;
        $scope.userControl = true;
    }
    $scope.CurrentPage = 1;
    $scope.TotalPage = 0;
    $scope.EmployeeList = [];

    function GetEmployeeData(page) {
        $scope.IsLoading = true;
        var data = {

            page: page
        };
        $http({
            method: 'GET',
            url: '/api/Search/DefaultS/',
            params: data
        }).then(function (response) {
            angular.forEach(response.data.result.ilanlar,
                function (value) {
                    $scope.EmployeeList.push(value);
                    // console.log($scope.EmployeeList);
                });

            $scope.TotalPage = response.data.result.totalPage;
            $scope.IsLoading = false;
        }, function () {
            $scope.IsLoading = false;
        });
    }

    GetEmployeeData($scope.CurrentPage);

    $scope.NextPage = function () {
        if ($scope.CurrentPage < $scope.TotalPage) {
            $scope.CurrentPage += 1;
            GetEmployeeData($scope.CurrentPage);
        }
    };
    // }
});
torbaliBurada.controller('InfinitySearchController', ['$scope', '$http', function ($scope, $http) {
    $scope.CurrentPage = 1;
    $scope.TotalPage = 0;
    $scope.EmployeeList = [];
    $scope.default = {
        CurrentPage: 1,
        TotalPage: 0,
        userName: '',
        id: '',
        SatilikId: '',
        SemtId: '',
        MahalleId: ''
    };
    $scope.emlakIlanSerach = function () {
        $scope.IsLoading = true;
        //  $scope.responseData = "";
        var data = {
            page: $scope.default.CurrentPage,
            userName: $scope.default.userName,
            id: $scope.default.id,
            SatilikId: $scope.default.SatilikId,
            SemtId: $scope.default.SemtId,
            MahalleId: $scope.default.MahalleId
        };
        var promisesearch = IlanService.ekle(userLogin);
        promisesearch.then(function (response) {
            angular.forEach(response.data.result.evlatlar,
                function (value) {
                    $scope.EmployeeList.push(value);
                });
            $scope.default.TotalPage = response.data.result.totalPage;
            $scope.IsLoading = false;
        },
            function () {
                $scope.IsLoading = false;
            });
    };
    function GetEmployeeData(page) {
        $scope.IsLoading = true;
        var data = {

            page: page.CurrentPage,
            userName: page.userName,
            id: page.id,
            SatilikId: page.SatilikId,
            SemtId: page.SemtId,
            MahalleId: page.MahalleId
        };
        $http({
            method: 'GET',
            url: '/api/Search/DefaultS/',
            params: data
        }).then(function (response) {
            angular.forEach(response.data.result.evlatlar,
                function (value) {
                    $scope.EmployeeList.push(value);
                });
            $scope.default.TotalPage = response.data.result.totalPage;
            $scope.IsLoading = false;
        },
            function () {
                $scope.IsLoading = false;
            });
    };

    GetEmployeeData($scope.default);

    $scope.NextPage = function () {
        // if ($scope.IsLoading == true) 
        if ($scope.default.CurrentPage < $scope.default.TotalPage) {
            $scope.default.CurrentPage += 1;
            GetEmployeeData($scope.default);
        }
    };
}]);
//directive
torbaliBurada.directive('infinityscroll', function () {
    return {
        restrict: 'A',

        link: function (scope, element, attrs) {

            element.bind('scroll',
                function () {

                    if (element[0].scrollTop + element[0].offsetHeight === element[0].scrollHeight) {
                        scope.$apply(attrs.infinityscroll);
                    }
                });
        }
    };
});
