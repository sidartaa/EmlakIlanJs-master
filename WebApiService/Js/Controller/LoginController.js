'use strict';

torbaliBurada.controller('loginController', function ($scope, loginservice, $window, $location, vcRecaptchaService, $http) {

    var accesstoken = localStorage.getItem('accessToken');
    if (accesstoken !== null) {

        $location.path("/Home/ProfilPage");

        // return false;
    }
    //Loading
   
    $scope.message = '';
    $scope.result = "color-default";
    $scope.isViewLoading = false;
    $scope.searchButtonText = "Giriş";
   
    //Scope Declaration
    $scope.responseData = "";

    $scope.userName = "";

    $scope.userRegistrationEmail = "";
    $scope.userRegistrationPassword = "";
    $scope.userRegistrationConfirmPassword = "";
    $scope.userRegistrationFirstName = "";
    $scope.userRegistrationLastName = "";
    $scope.userRegistrationPhone = "";
    $scope.userRegistrationDuyuru = false;
    $scope.userFirmaAd = "";
    $scope.IsMatch = false;
    
    //public string Recaptcha { get; set; }
    $scope.userLoginEmail = "";
    $scope.userLoginPassword = "";
    $scope.LoginRememberMe = false;
    $scope.userLoginIp = "";
    $scope.userRecaptcha = "";
    $scope.publicKey = "6Lf_riMUAAAAALgOVC2HfzGs0UNk6Ygg1DPNomAx";
    $scope.accessToken = "";
    $scope.refreshToken = "";
    $scope.recaptchaErrorMessage = false;
    //Ends Here

    //Function to register user
    $scope.registerUser = function () {
        //$scope.add = function () {
        if ($scope.userRegistrationPassword !== $scope.userRegistrationConfirmPassword) {
            $scope.IsMatch = true;
            return false;
        }
        $scope.IsMatch = false;
        //}
        $scope.responseData = "";

        //The User Registration Information
        var userRegistrationInfo = {
            Email: $scope.userRegistrationEmail,
            Password: $scope.userRegistrationPassword,
            ConfirmPassword: $scope.userRegistrationConfirmPassword,
            Ad: $scope.userRegistrationFirstName,
            Soyad: $scope.userRegistrationLastName,
            PhoneNumber: $scope.userRegistrationPhone,
            Duyuru: true,
            FirmaAd: $scope.userFirmaAd
        };

        var promiseregister = loginservice.register(userRegistrationInfo);

        promiseregister.then(function (resp) {
            $scope.responseData = "User is Successfully";
            $scope.userRegistrationEmail = "";
            $scope.userRegistrationPassword = "";
            $scope.userRegistrationConfirmPassword = "";
            $scope.userRegistrationFirstName = "";
            $scope.userRegistrationLastName = "";
            $scope.userRegistrationPhone = "";
            $scope.userRegistrationDuyuru = false;
            $scope.userFirmaAd = "";
            $scope.IsMatch = false;
            window.location.href = 'Home/Login';
        }, function (err) {
            $scope.responseData = "Error " + err.status;
        });

        
    };
    $scope.redirect = function () {
       // window.location.href = '/Login';
        $location.path('/Home/Login');
       
    };
   
    //Function to Login. This will generate Token 
    $scope.login = function () {
        $scope.searchButtonText = "Lütfen Bekleyiniz..."; 
        //This is the information to pass for token based authentication
       
        var userLogin = {
            grant_type: 'password',
            username: $scope.userLoginEmail,
            password: $scope.userLoginPassword
            //rememberme: $scope.LoginRememberMe
        };
        var promiselogin = loginservice.login(userLogin);
        promiselogin.then(function (resp) {

            $scope.userName = resp.data.userName;
            $scope.message = 'Giriş başarılı!';
            $scope.result = "color-green";
            $scope.searchButtonText = "Giriş";
            //Store the token information in the localStorage
            //So that it can be accessed for other views
            localStorage.setItem('userName', resp.data.userName);
            localStorage.setItem('accessToken', resp.data.access_token);
            //localStorage.setItem('refreshToken', resp.data.refresh_token);
            //localStorage.setItem("rememberme", true);
            //localStorage.setItem('firma', resp.data.firmaAd);
            window.location.href = '/Home/ProfilPage';
            // alert("giriş ok");                   
            // $location.path("/ProfilPage");

        }, function (err) {
            window.location.href = '/Home/Login';
            $scope.isViewLoading = true;
            $scope.responseData = "Error :" + err.status;
            $scope.message = 'Giriş başarısız. Lütfen bilgilerinizi kontrol ediniz!';
            $scope.result = "color-red";
            $scope.searchButtonText = "Giriş";
        });
        $scope.isViewLoading = false;
       // alert(post_data.response);
              
        
        //var userLogin = {
        //    grant_type: 'password',
        //    username: $scope.userLoginEmail, 
        //    password: $scope.userLoginPassword,
        //    rememberme: $scope.LoginRememberMe
        //};

        //var promiselogin = loginservice.login(userLogin);
        //    promiselogin.then(function (resp) {

        //    $scope.userName = resp.data.userName;
        //    $scope.message = 'Form data Saved!';
        //    $scope.result = "color-green";
        //    $scope.searchButtonText = "Giriş";
        //    //Store the token information in the localStorage
        //    //So that it can be accessed for other views
        //    localStorage.setItem('userName', resp.data.userName);
        //    localStorage.setItem('accessToken', resp.data.access_token);
        //    localStorage.setItem('refreshToken', resp.data.refresh_token);
        //    localStorage.setItem("rememberme", true);
        //    localStorage.setItem('firma',resp.data.firmaAd);
        //   // window.location.href = '/ProfilPage';
        //    $location.path("/ProfilPage");
            

        //    }, function (err) {
        //    $scope.isViewLoading = true;
        //    $scope.responseData = "Error :" + err.status;
        //    $scope.message = 'Giriş başarısız. Lütfen bilgilerinizi kontrol ediniz!';
        //    $scope.result = "color-red";
        //    $scope.searchButtonText = "Giriş";
        //});
        //$scope.isViewLoading = false;
    };
    
});