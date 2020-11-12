'use strict';
torbaliBurada.controller('WebPageIndex', function ($scope,  WebSiteService) {
    var config = {
        Id: 1
    };
    $scope.IsLoadingKat = false;
    $scope.getKategoriler = [];
    loadKategoriler();
    function loadKategoriler() {
        $scope.IsLoadingKat = true;
        var kat = WebSiteService.kategoriler(config);

        kat.then(function (resp) {
            $scope.getKategoriler = resp.data;
            // $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
        $scope.IsLoadingKat = false;
    }
});

torbaliBurada.controller('ModalImagesEditingCtrl', function ($scope, $modalInstance, $modal, items, WebSiteService, $http, imgservice) {
    $scope.rowsimg = [];
    $scope.ImgLoading = true;
    $scope.id = items;
    var config = {
        Id: ''
    };

    $scope.GetImages = function loadilan(items) {
        $scope.ImgLoading = true;
        config = {
            IlanId: items
        };
        // $scope.id = items;
        var getIlan = WebSiteService.GetImages(config);
        getIlan.then(function (resp) {
            $scope.rowsimg = resp.data;
            $scope.ImgLoading = false;
        });
    };

    $scope.true = false;
    //Delete img
    $scope.DeleteImg = function loadilan(items) {
        config = {
            id: items
        };

        $modalInstance.querydelete = WebSiteService.DeleteImages(config);
        $modalInstance.querydelete.then(function (resp) {

            $scope.GetImages($scope.id);
        });


    };
    $scope.GetImages(items);
    $scope.ok = function () {
        $modalInstance.close($scope.selected.item);
    };
    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };
    //Upload img
    $scope.uploading = false;
    $scope.countFiles = '';
    $scope.data = [];
    $scope.imagesrc = [];
    $scope.formdata = new FormData();

    $scope.getFiles = function (file) {
        angular.forEach(file, function (value, key) {
            $scope.formdata.append(key, value);
            $scope.data.push({ FileName: value.name, FileLength: value.size });
        });

        for (var i = 0; i < file.length; i++) {
            var files = file[i];
            var reader = new FileReader();
            reader.onload = $scope.imageIsLoaded;
            reader.readAsDataURL(files);
        }
        $scope.imageIsLoaded = function (e) {
            $scope.$apply(function () {
                $scope.imagesrc.push(e.target.result);
            });
        };

        $scope.countFiles = $scope.data.length === 0 ? '' : $scope.data.length + ' dosya seçildi...';
        $scope.$apply();
        $scope.formdata.append('countFiles', $scope.countFiles);
        $scope.formdata.append("id", $scope.id);
        // console.log($scope.emlakIlanId);
    };
    $scope.uploadedFile = function (element) {
        // var files = element.target.files; //FileList object
        for (var i = 0; i < files.length; i++) {
            var file = files[i];
            var reader = new FileReader();
            reader.onload = $scope.imageIsLoaded;
            reader.readAsDataURL(file);
        }

    };
    $scope.imageIsLoaded = function (e) {
        $scope.$apply(function () {
            $scope.imagesrc.push(e.target.result);
        });
    };
    $scope.uploadFiles = function () {
        $scope.uploading = true;
        $modalInstance.query = imgservice.uploadimg($scope);
        $modalInstance.query.then(function (resp) {

            $scope.uploading = false;
            $scope.formdata = new FormData();
            $scope.data = [];
            $scope.countFiles = '';
            $scope.$apply;
            $scope.clear;
            $scope.emlakIlanResim = resp.data.result.resim;
            $scope.GetImages($scope.id);

        }, function (err) {
            alert("Error!!! " + err);
        });

    };
    $scope.clear = function () {
        angular.element("input[type='file']").val(null);
    };


});
torbaliBurada.controller('ModalEditingIlanCtrl', function ($scope, $modalInstance, $modal, items, WebSiteService, $http, imgservice) {
   

    $scope.IlanLoading = false;
    $scope.rowilan = [];

    var config = {
        id: ''
    };
    $scope.firstReset = function () {
        $modalInstance.frmIlanupdate = {};
    };
    function trim(text) {
        if (text !== null)
            return text.replace(/^\s+|\s+$/g, "");
        else
            return text;
    }

    //Update Ilan
    $scope.parameters = {
        id: '', Baslik: '', Aciklama: '', Fiyat: '', MetreKare: '', TakasliID: '', UserName: '', Private: '', CepTelefonu: '', TakasTuru: '', Sahibi: '', Ada: '', Pafta: '', Parsel: '', IletisimTelefonu: ''
    };

    $scope.getIlanim = function loadilan(items) {
        $scope.IlanLoading = true;
        config = {
            id: items
        };

        // $scope.id = items;
        $modalInstance.getIlan = WebSiteService.getIlan(config);
        $modalInstance.getIlan.then(function (resp) {
            $scope.frmIlanupdate = {};
            $scope.rowilan = resp.data;

            $scope.$watch('handle', function () {
                $scope.parameters.id = $scope.rowilan.result.id;
                $scope.parameters.Baslik = $scope.rowilan.result.baslik;
                $scope.parameters.Aciklama = trim($scope.rowilan.result.aciklama);
                $scope.parameters.Fiyat = $scope.rowilan.result.fiyat;
                $scope.parameters.MetreKare =$scope.rowilan.result.metreKare;
                $scope.parameters.TakasliID = $scope.rowilan.result.takasli;
                $scope.parameters.UserName = $scope.rowilan.result.userName;
                $scope.parameters.Private = $scope.rowilan.result.private;
                $scope.parameters.CepTelefonu = $scope.rowilan.result.ilanSahibiCepTelefonu;
                $scope.parameters.TakasTuru=$scope.rowilan.result.takasTuru;
                $scope.parameters.Sahibi = $scope.rowilan.result.ilanSahibi;
                $scope.parameters.Ada=$scope.rowilan.result.ada;
                $scope.parameters.Pafta=$scope.rowilan.result.pafta;
                $scope.parameters.Parsel=$scope.rowilan.result.parsel;
                $scope.parameters.IletisimTelefonu = $scope.rowilan.result.iletisimTelefonu;
               // console.log($scope);
            });
            $scope.IlanLoading = false;
        });
    };
    $scope.UpdateOk = false;
    $scope.emlakIlanUpdate = function () {
      
        $scope.$watch('handle', function () {

        });
        var update = {
            id: $scope.parameters.id,
            Baslik: $scope.parameters.Baslik,
            Aciklama: $scope.parameters.Aciklama,
            Fiyat: $scope.parameters.Fiyat,
            MetreKare: $scope.parameters.MetreKare,
            Private: $scope.parameters.Private,
            UserName: $scope.parameters.UserName,
            TakasliID: $scope.parameters.TakasliID,
            CepTelefonu:$scope.parameters.CepTelefonu,
            TakasTuru:$scope.parameters.TakasTuru,
            Sahibi:$scope.parameters.Sahibi,
            Ada:$scope.parameters.Ada,
            Pafta:$scope.parameters.Pafta,
            Parsel:$scope.parameters.Parsel,
            IletisimTelefonu: $scope.parameters.IletisimTelefonu
        };
       // console.log(update);
        $modalInstance.promiselogin = WebSiteService.updateIlan(update);
       
        $modalInstance.promiselogin.then(function (resp) {
            $scope.rowilan = [];
            $scope.rowilan = resp.data;
            $scope.UpdateOk = true;
            $scope.emlakIlanId = resp.data.result.id;
            $scope.emlakIlanBaslik = resp.data.result.baslik;
            // window.location.href = 'http://localhost:4595/Login/ManageUser';
            window.location.reload();
        }, function (err) {

        });

    };
    $scope.getIlanim(items);
    $scope.ok = function () {
        $modalInstance.close($scope.selected.item);
    };
    $scope.cancel = function () {       
        $modalInstance.dismiss('cancel');
        $scope.firstReset();
    };
});

torbaliBurada.controller('WebSiteController', function ($scope, $http, $sce, WebSiteService, $aside, $anchorScroll, $location, IlanService, $modal, $log,Logs, profilPageServic, $window) {
   
    $scope.Logs = new Logs();
    //#region Login Kontrol
    $scope.items1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
    $scope.loginTrue = false;
    loginKontrol();
    function loginKontrol() {
        var accesstoken = localStorage.getItem('accessToken');
        if (accesstoken === null) {
            $scope.loginTrue = false;
        }
        else {
            $scope.loginTrue = true;
        }
    }

    //#endregion

    //#region Get kategoriler
    $scope.getKategoriler = [];
    loadKategoriler();
    function loadKategoriler() {
        var config = {
            Id: 1
        };
        $scope.IsLoadingKat = true;
        var kat = WebSiteService.kategoriler(config);

        kat.then(function (resp) {
            $scope.getKategoriler = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
        $scope.IsLoadingKat = false;
    }
    //#endregion
    //#region Get Semtler
    var kategoriID = { id: 2 };
    loadSemtler();
    $scope.getSemt = [];
    function loadSemtler() {
       // id = { Id: 2 };

        var kat = WebSiteService.location(kategoriID);

        kat.then(function (resp) {
            $scope.getSemt = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
    }
    //#endregion
    $scope.ilanOzellikler = [];
    $scope.query = false;
    $scope.ilanGenel = function loadilan(id) {
        var config = {
            Id: id
        };
        var getIlan = WebSiteService.getIlanDetay(config);
        getIlan.then(function (resp) {
            $scope.ilanOzellikler = resp.data.result.ilanResimler;
           console.log($scope.ilanOzellikler);
            $scope.query = true;
        });
    };
    //Update ilan
    $scope.EditingIlan = function (id) {

        var modalInstance = $modal.open({
            templateUrl: 'myModalEditingIlan.html',
            controller: 'ModalEditingIlanCtrl',
            scope: $scope,
            size: 'lg',
            resolve: {
                items: function () {
                    return id;
                }
            }
        });

        modalInstance.result.then(function (selectedItem) {
            $scope.selected = selectedItem;

        }, function () {
            $log.info($scope.selected + 'Modal dismissed at: ' + new Date());

        });
    };
    //Edit İlan img
    $scope.EditingImages = function (id) {

        var modalInstance = $modal.open({
            templateUrl: 'myModalImages.html',
            controller: 'ModalImagesEditingCtrl',
            scope: $scope,
            size: 'lg',
            resolve: {
                items: function () {
                    return id;
                }
            }
        });

        modalInstance.result.then(function (selectedItem) {
            $scope.selected = selectedItem;

        }, function () {
            $log.info($scope.selected + 'Modal dismissed at: ' + new Date());

        });
    };
    $scope.open = function (id) {

        var modalInstance = $modal.open({
            templateUrl: 'myModalContent.html',
            controller: 'ModalInstanceCtrl',
            scope: $scope,
            size: 'lg',
            resolve: {
                items: function () {
                    return id;
                }
            }
        });



        modalInstance.result.then(function (selectedItem) {
            $scope.selected = selectedItem;
        }, function () {
            $log.info($scope.selected + 'Modal dismissed at: ' + new Date());
        });
    };
    $scope.reSerach = function () {
        //  $scope.ArsaTipi = false;
        $scope.KonutTipi = false;
        $scope.IsyeriTipi = false;
        $scope.parameters = {
            id: '',
            SatilikId: '',
            SemtId: '',
            MahalleId: '',
            CurrentPage: 1,
            TotalPage: 0,
            userName: '',
            KonutTipi: '',
            IsyeriTipi: '',
            ArsaTipi: ''
        };
        $scope.emlakIlanSerachDefauld(dataM);
    };

    $scope.id = {};
    $scope.KonutTipi = false;
    $scope.ArsaTipi = true;
    $scope.IsyeriTipi = false;

    $scope.clickSatilikKiralik = function loadKategoriler(id) {
        id = String(id).replace(/<[^>]+>/gm, '');
        id = parseInt(id);
        $scope.parameters.id = id;
       
        //selectId.push($scope.parameters.id);
        $scope.IsLoadingKat = true;
        kategoriID = {
            Id: id
        };

        var kat = WebSiteService.kategoriler(kategoriID);

        kat.then(function (resp) {
            $scope.getKategorilerSatilik = resp.data;
            $scope.Message = "OK...";
            $scope.IsLoadingKat = false;
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
    };
    $scope.clickSemt = function loadKategoriler(id) {
        id = String(id).replace(/<[^>]+>/gm, '');
        id = parseInt(id);
        $scope.parameters.SatilikId = id;
        $scope.IsLoadingKat = true;
        if (id === 5) {
            $scope.KonutTipi = true;            
            $scope.IsyeriTipi = false;
        }
        if (id === 6) {
           
            $scope.KonutTipi = false;
            $scope.IsyeriTipi = true;
        }
       
        kategoriID = {
            Id: id
        };
        var kat = WebSiteService.kategoriler(kategoriID);

        kat.then(function (resp) {
            $scope.getKategorilerSemt = resp.data;
            $scope.Message = "OK...";
            $scope.IsLoadingKat = false;
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
    };
    $scope.clickLock = function loadKategoriler(id) {
        id = String(id).replace(/<[^>]+>/gm, '');
        id = parseInt(id);
        $scope.parameters.SemtId = id;
    };
    $scope.clickKonutTipi = function loadKategoriler(id) {
        id = String(id).replace(/<[^>]+>/gm, '');
        id = parseInt(id);
        $scope.parameters.KonutTipi = id;
    };
    $scope.clickIsyeriTipi = function loadKategoriler(id) {
        id = String(id).replace(/<[^>]+>/gm, '');
        id = parseInt(id);
        $scope.parameters.IsyeriTipi = id;
    };
    $scope.clickIsyeriTipi = function loadKategoriler(id) {
        id = String(id).replace(/<[^>]+>/gm, '');
        id = parseInt(id);
        $scope.parameters.IsyeriTipi = id;
    };
    $scope.clickArsaImarDurumu = function loadKategoriler(id) {
        id = String(id).replace(/<[^>]+>/gm, '');
        id = parseInt(id);
        $scope.parameters.IsyeriTipi = id;
    };
    $scope.clickArsaTapuDurumu = function loadKategoriler(id) {
        id = String(id).replace(/<[^>]+>/gm, '');
        id = parseInt(id);
        $scope.parameters.IsyeriTipi = id;
    };
    $scope.clickMahalle = function loadKategoriler(id) {
        //selectId.push($scope.parameters.id);
        $scope.IsLoadingKat = true;
        kategoriID = {
            Id: id
        };
        var kat = WebSiteService.kategoriler(kategoriID);

        kat.then(function (resp) {
            $scope.getKategorilerMahalle = resp.data;
            $scope.Message = "OK...";
            $scope.IsLoadingKat = false;
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
    };
    $scope.showUserScore = false;
    $scope.topResim = [];

    $scope.getResim = function ilanTopResim(id) {
        var config = {
            IlanId: id
        };
        var promisesearch = IlanService.getImage(config);
        promisesearch.then(function (resp) {
            if (resp.data.result) {
                $scope.topResim.push(resp.data.result);
                //$scope.showUserScore = true;
            }
            //return $scope.topResim[ilanId];
            //else
            //    $scope.topResim = "domates.jpg";
            //return $scope.topResim;  
        }, function () {
            console.log('error');
        });
        return $scope.topResim.resim;
    };

    //Emlak Tipi
    $scope.emlakKonutTipi = [];
    loadEmlakKonutTipi();
    function loadEmlakKonutTipi() {
        var kat = WebSiteService.EmlakKonutTipi();

        kat.then(function (resp) {
            $scope.emlakKonutTipi = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
    }

    //Emlak Tapu Durumu Emlak Imar Durumu
    $scope.emlakImarDurumu = [];
    $scope.emlakTapuDurumu = [];
    //loadEmlakImarDurumu();
    //loadEmlakTapuDurumu();
    function loadEmlakTapuDurumu() {
        var kat = WebSiteService.EmlakTapuDurumu();
        kat.then(function (resp) {
            $scope.emlakTapuDurumu = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = 'ERROR:' + err.status;
        });
    }
    function loadEmlakImarDurumu() {
        var kat = WebSiteService.EmlakImarDurumu();
        kat.then(function (resp) {
            $scope.emlakImarDurumu = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = 'ERROR:' + err.status;
        });
    }

    //İşyeri  Kullanım Amacı
    $scope.emlakKullanimAmaci = [];
    loadEmlakKullanimAmaci();
    function loadEmlakKullanimAmaci() {
        var kat = WebSiteService.EmlakKullanimAmaci();
        kat.then(function (resp) {
            $scope.emlakKullanimAmaci = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = 'ERROR:' + err.status;
        });
    }
    //////////////////////////////////////////////////////////////
    $scope.parametersearch = {
        id: '',
        SatilikId: '',
        SemtId: '',
        MahalleId: '',
        CurrentPage: 1,
        TotalPage: 0,
        userName: '',
        KonutTipi: '',
        IsyeriTipi: '',
        ArsaTipi: ''
    };
    $scope.loadingsearch = false;
    $scope.parameters = {
        id: '',
        SatilikId: '',
        SemtId: '',
        MahalleId: '',
        CurrentPage: 1,
        TotalPage: 0,
        userName: '',
        KonutTipi: '',
        IsyeriTipi: '',
        ArsaTipi: ''
    };

    
   // var kategoriID = {};
    $scope.IsLoading = false;
    $scope.IsSearch = true;
    $scope.IsLoadingKat = false;
    $scope.EmployeeList = [];
    $scope.EmployeeListDefauld = [];

    $scope.default = {
        CurrentPage: 1,
        TotalPage: 0,
        userName: '',
        id: '',
        SatilikId: '',
        SemtId: '',
        MahalleId: '',
        KonutTipi: '',
        IsyeriTipi: '',
        ArsaTipi: ''
    };

    $scope.emlakIlanSerach = function () {
        $scope.IsLoading = true;
      //  SearchFunction();
        var data = {
            page: 1,
            userName: $scope.parameters.userName,
            id: $scope.parameters.id,
            SatilikId: $scope.parameters.SatilikId,
            SemtId: $scope.parameters.SemtId,
            MahalleId: $scope.parameters.MahalleId,
            KonutTipi: $scope.parameters.KonutTipi,
            IsyeriTipi: $scope.parameters.IsyeriTipi,
            ArsaTipi: $scope.parameters.ArsaTipi
        };
        var promisesearch = IlanService.search(data);

        promisesearch.then(function (response) {
            if (data.page === 1) {
                $scope.Ilanlar = [];
                $scope.parameters.CurrentPage = 1;
            }
                
            $scope.Location = [];
            angular.forEach(response.data.result.ilanlar, function (value) {
                //$scope.getResim(value.id);
                $scope.Ilanlar.push(value);
                // console.log($scope.EmployeeList);
            });
            //angular.forEach(response.data.result.adresler, function (value) {
            //    //$scope.getResim(value.id);
            //    $scope.Location.push(value);
            //    // console.log($scope.EmployeeList);
            //});
            $scope.parameters.TotalPage = response.data.result.totalPage;
            
            $scope.IsLoading = false;

        }, function () {


        });
        // sleep(5000);

    };
    function SearchFunction() {
        var x = document.getElementById('IsSearch');
        if (x.style.display === 'none') {

            x.style.transition = 'all linear 0.5s';
            x.style.display = 'block';

        } else {

            x.style.transition = 'all linear 0.5s';
            x.style.display = 'none';
        }
    }
    function sleep(milliseconds) {
        var start = new Date().getTime();

        for (var i = 0; i < 1e7; i++) {
            var tm = new Date().getTime();
            tm = tm - start;
            if (tm > milliseconds) {
                break;
            }
        }
    }

    $scope.emlakIlanSerachDefauld = function (data) {
        $scope.IsLoading = true;

        var promisesearch = WebSiteService.search(data);
        promisesearch.then(function (response) {
            if (data.page === 1)
                $scope.Ilanlar = [];
                $scope.Location = [];
            angular.forEach(response.data.result.ilanlar, function (value) {
                //$scope.getResim(value.id);
                $scope.Ilanlar.push(value);
               // console.log($scope.EmployeeList);
            });
            //angular.forEach(response.data.result.adresler, function (value) {
            //    //$scope.getResim(value.id);
            //    $scope.Location.push(value);
            //    // console.log($scope.EmployeeList);
            //});
            $scope.parameters.TotalPage = response.data.result.totalPage;

            $scope.IsLoading = false;

        }, function () {
            $scope.IsLoading = false;
        });
    };
    var dataM = {
        page: 1,
        userName: '',
        id: 0,
        SatilikId: 0,
        SemtId: 0,
        MahalleId: 0,
        KonutTipi: 0,
        IsyeriTipi: 0,
        ArsaTipi: 0
    };
    $scope.emlakIlanSerachDefauld(dataM);

    $scope.emlakIlanSerachKategori = function loadkategori(id) {
       // alert("tıklandı");
        $scope.IsLoading = true;
        SearchFunction();
        var data = {
            page: 1,
            userName: '',
            id: id,
            SatilikId: 0,
            SemtId: 0,
            MahalleId: 0,
            KonutTipi: 0,
            IsyeriTipi: 0,
            ArsaTipi: 0
        };
        var promisesearch = WebSiteService.kategoriSearch(data);

        promisesearch.then(function (response) {
            if (data.page === 1) {
                $scope.Ilanlar = [];
                $scope.Location = [];
                $scope.parameters.CurrentPage = 1;
            }
            angular.forEach(response.data.result, function (value) {
                $scope.Ilanlar.push(value);

            });
            //angular.forEach(response.data.result.adresler, function (value) {
            //    //$scope.getResim(value.id);
            //    $scope.Location.push(value);
            //    // console.log($scope.EmployeeList);
            //});
            $scope.parameters.TotalPage = response.data.result.totalPage;
            //sleep(5000);
            $scope.IsLoading = false;
            // $scope.IsSearch = true;
            SearchFunction();

        }, function () {


        });
        // sleep(5000);
    };

    $scope.sifirla = function () {
        $scope.parameters.CurrentPage = 1;
        $scope.parameters.TotalPage = 0;
    };
    $scope.NextPage = function () {
       
        if ($scope.parameters.CurrentPage < $scope.parameters.TotalPage) {
            $scope.parameters.CurrentPage += 1;
           

            var data = {
                page: $scope.parameters.CurrentPage,
                userName: $scope.parameters.userName,
                id: $scope.parameters.id,
                SatilikId: $scope.parameters.SatilikId,
                SemtId: $scope.parameters.SemtId,
                MahalleId: $scope.parameters.MahalleId,
                KonutTipi: $scope.parameters.KonutTipi,
                IsyeriTipi: $scope.parameters.IsyeriTipi,
                ArsaTipi: $scope.parameters.ArsaTipi
            };
            
            $scope.emlakIlanSerachDefauld(data);
        }
    };
   
});
torbaliBurada.controller('ModalInstanceCtrl', function ($scope, $modalInstance, $modal, items, WebSiteService, $http) {
    $scope.rows = [];
    $scope.ImgLoading = false;
    var config = {
        Id: ''
    };
    $scope.baslik = '';
    $scope.ilanGenel = function loadilan(items) {
        $scope.ImgLoading = true;
        config = {
            Id: items
        };
        var getIlan = WebSiteService.getIlanDetay(config);
        getIlan.then(function (resp) {
            $scope.rows = resp.data.result;
            console.log($scope.rows);
            $scope.ImgLoading = false;
        });

    };

    $scope.ilanGenel(items);
    $scope.ok = function () {
        $modalInstance.close($scope.selected.item);
    };

    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };
   


});
// Angular Directive's for 
//--------------------------------------------------------------------------------------
torbaliBurada.directive('clickMe', function () {
    return {

        restrict: 'A',

        link: function (scope, element, attrs) {
            element.bind('click', function () {

                scope.$apply(attrs.clickMe);
            });
        }
    };
});
torbaliBurada.directive('mySwiper', function () {
    return {
        restrict: 'C',
        link: function (scope, element, attrs) {

            var swiperpagination = angular.element(element[0].querySelectorAll('.swiper-pagination'));
            var swiperbuttonnext = element[0].querySelectorAll('.swiper-button-next');
            var swiperbuttonprev = element[0].querySelectorAll('.swiper-button-prev');

            var mySwiper = element.swiper({
                mode: "horizontal",
                loop: true
            });
            var swiper = new Swiper(element, {
                pagination: swiperpagination,
                paginationClickable: true,
                nextButton: swiperbuttonnext,
                prevButton: swiperbuttonprev,
                spaceBetween: 30,
                centeredSlides: true
                //autoplay: 2500,
                //autoplayDisableOnInteraction: false
            });
        }

    };
});
torbaliBurada.directive('daCarousel', function () {
    return {
        restrict: 'C',
        replace: true,
        // scope: { img: "=myItem" },
        link: function (scope, element, attrs) {
            //$(element).owlCarousel({
            //     navigation: true, // Show next and prev buttons
            //     slideSpeed: 300,
            //     autoPlay: 3000,
            //     stopOnHover: true, 
            //     paginationSpeed: 1000,
            //     goToFirstSpeed: 2000,
            //     singleItem: true,
            //    autoHeight: true,
            //   transitionStyle: "fade"

            //});
            $(element).carousel({
                interval: 3000

            });


        }

    };
});
torbaliBurada.directive('activeSlider', function () {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            element.children("div").addClass("active");
        }
    };
});
torbaliBurada.directive('benimDirectivim', function () {
    return {
        restrict: 'E',
        replace: true,
        scope: {
            heroes: '=data'
        },
        link: function (scope, element, attrs) {
            //var x = scope.heroes.resim;

            //if (!x) {
            //    x = '/Userimage/slider1.png';
            //    scope.heroes.resim = x;
            //    alert(x);
            //}

        }
        ,
        template: '<div class="item"><img class="img-responsive" alt="{{heroes.resim}}" ng-src="/Userimage/{{heroes.resim}}" ></div>'
    };
});
torbaliBurada.directive('checkImage', function ($http) {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            attrs.$observe('ngSrc', function (ngSrc) {
                $http.get(ngSrc).success(function () {
                    // alert('image exist');
                }).error(function () {
                    // alert('image not exist');
                    element.attr('src', '/Userimage/slider1.png'); // set default image
                });
            });
        }
    };
});
torbaliBurada.directive('aLink', ['$location', function ($location) {

    return {
        restrict: 'EA',
        replace: true,
        scope: { ahref: '@data' },
        link: function (scope, elem, attrs) {
            //things happen here
            elem.on('click', function () {
                scope.$apply(function () {
                    $location.url(ahref);
                });
            });

        }
    };
}]);
torbaliBurada.directive('scrollTo', function () {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            element.on('click', function () {
                var scrollPos = 840;
                $(".menu").slideToggle(750);
                var target = $(attrs.scrollTo);
                if (target.length > 0) {
                    $('html, body').animate({
                        scrollTop: scrollPos //$("#catalogSection").offset().top  //target.offset().top
                    }, 1000);
                }
            });
        }
    };
});
torbaliBurada.directive('scrollTohome', function () {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            element.on('click', function () {
                var scrollPos = 2300;
                // $(".menu").slideToggle(750);
                var target = $(attrs.scrollTo);
                if (target.length > 0) {
                    $('html, body').animate({
                        scrollTop: scrollPos  //790 //scrollPos//target.offset().top
                    }, 1000);
                }
            });
        }
    };
});
torbaliBurada.directive('scrollSearch', function () {
    return {
        restrict: 'AC',
        link: function (scope, element, attrs) {
            element.on('click', function () {
                $(".menu").slideToggle(750);
                // var scrollPos = 1300;
                // $(".menu").slideToggle(300);
                //var target = $(attrs.scrollTo);
                //if (target.length > 0) {
                //    $('html, body').animate({
                //        scrollTop: $("#catalogSection").offset().top - 50 //scrollPos//target.offset().top
                //    }, 1000);
                //}
            });
        }
    };
});
torbaliBurada.filter('strLimit', ['$filter', function ($filter) {
    return function (input, limit) {
        if (!input) return;
        if (input.length <= limit) {
            return input;
        }

        return $filter('limitTo')(input, limit) + '...';
    };
}]);
torbaliBurada.directive("owlCarousel", function () {
        return {
            restrict: 'E',
            transclude: false,
            link: function (scope) {
                scope.initCarousel = function(element) {
                    // provide any default options you want
                    var defaultOptions = {
                    };
                    var customOptions = scope.$eval($(element).attr('data-options'));
                    // combine the two options objects
                    for(var key in customOptions) {
                        if (customOptions.hasOwnProperty(key)) {
                            defaultOptions[key] = customOptions[key];
                        }
                    }
                    // init carousel
                    $(element).owlCarousel(defaultOptions);
                };
            }
        };
})
    .directive('owlCarouselItem', [function () {
        return {
            restrict: 'A',
            transclude: false,
            link: function(scope, element) {
                // wait for the last item in the ng-repeat then call init
                if(scope.$last) {
                    scope.initCarousel(element.parent());
                }
            }
        };
    }]);
torbaliBurada.factory('Logs', function (WebSiteService) {
    var Logs = function () {
        this.items = [];
        this.busy = false;
        this.data = {
            TotalPage: 1000000, PageSize: 40, CurrentPage: 0,
            userName: '',
            id: '',
            SatilikId: '',
            SemtId: '',
            MahalleId: '',
            KonutTipi: '',
            IsyeriTipi: '',
            ArsaTipi: ''
        };
        this.query = true;
    };

    Logs.prototype.nextPage = function () {

        if (this.data.CurrentPage < this.data.TotalPage) {
            this.data.CurrentPage = (this.data.CurrentPage + 1);
            if (this.busy) return;
            this.busy = true;

            var getData = WebSiteService.search(this.data);
            getData.then(function (resp) {
                var items = resp.data.result.ilanlar;
                for (var i = 0; i < items.length; i++) {
                    this.items.push(items[i]);
                }
                this.data = {
                    TotalPage: resp.data.result.totalPage, PageSize: 5, CurrentPage: resp.data.result.currentPage,
                    userName: '',
                    id: '',
                    SatilikId: '',
                    SemtId: '',
                    MahalleId: '',
                    KonutTipi: '',
                    IsyeriTipi: '',
                    ArsaTipi: ''
                };
                this.busy = false;

            }.bind(this));
        }
    };

    return Logs;
});


