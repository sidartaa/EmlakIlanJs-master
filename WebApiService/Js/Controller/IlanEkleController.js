'use strict';

torbaliBurada.controller('IlanEkleController', function ($scope, $sce, IlanEkleservice, IlanService, imgservice, $location, filterFilter, $http, $templateCache) {

    //$scope.userControl = true;
    $scope.token = false;
    var accesstoken = localStorage.getItem('accessToken');

    if (accesstoken === null) {
        localStorage.removeItem('accessToken');
        $scope.token = false;
        window.location.href = "/Home/Login";
        //$location.path("/Home/Login");
      //return false;
    } else {
        $scope.token = true;
    }


    $scope.parameters = {
        SatilikId: '',
        IlanTuru: '',
        id: '',
        SemtId: '',
        MahalleId: '',
        IlanKimden: '',
        Sahibi: '',
        CepTelefonu: '',
        Baslik: '',
        Aciklama: '',
        Fiyat: '',
        Metrekare: '',
        Private: '',
        TakasliID: '',
        TakasTuru: '',
        Pafta: '',
        Parsel: '',
        Ada: '',
        KonutTipi: '',
        OdaSayisi: '',
        BulunduguKat: '',
        Isitma: '',
        IcOzellikler: '',
        DisOzelliker: '',
        EmlakKullanimAmaci: '',
        EmlakImarDurumu: '',
        EmlakTapuDurumu: '',
        UserName: '',
        IletisimTelefonu:''
    };
    //#region IlanIlanlar Save
    $scope.emlakIlanSaves = function () {
        $scope.isViewLoading = true;
        $scope.responseData = "";
        //$scope.responsePost = {};
        //This is the information to pass for token based authentication
        var ilan = {
            id: $scope.parameters.id,
            IlanTuru: $scope.parameters.IlanTuru,
            IlanKimden: $scope.parameters.IlanKimden,
            SatilikId: $scope.parameters.SatilikId,
            SemtId: $scope.parameters.SemtId,
            MahalleId: $scope.parameters.MahalleId,
            Baslik: $scope.parameters.Baslik,
            Aciklama: $scope.parameters.Aciklama,
            Fiyat: $scope.parameters.Fiyat,
            Metrekare: $scope.parameters.Metrekare,
            TakasliID: $scope.parameters.TakasliID,
            TakasTuru: $scope.parameters.TakasTuru,
            Sahibi: $scope.parameters.Sahibi,
            CepTelefonu: $scope.parameters.CepTelefonu,
            Pafta: $scope.parameters.Pafta,
            Parsel: $scope.parameters.Parsel,
            Ada: $scope.parameters.Ada,
            OdaSayisi: $scope.parameters.OdaSayisi,
            BulunduguKat: $scope.parameters.BulunduguKat,
            Isitma: $scope.parameters.Isitma,
            IcOzellikler: $scope.selectionic,// $scope.parameters.IcOzellikler,
            DisOzellikler: $scope.selectiondis,// $scope.parameters.DisOzelliker,
            KonutTipi: $scope.parameters.KonutTipi,
            Private: $scope.parameters.Private,
            EmlakImarDurumu: $scope.parameters.EmlakImarDurumu,
            EmlakTapuDurumu: $scope.parameters.EmlakTapuDurumu,
            EmlakKullanimAmaci: $scope.parameters.EmlakKullanimAmaci,
            UserName: localStorage.getItem('userName'),
            IletisimTelefonu: $scope.parameters.IletisimTelefonu

        };

        var promiselogin = IlanEkleservice.ekle(ilan);
        promiselogin.then(function (resp) {
            $scope.responseData = resp.data;
            $scope.emlakIlanId = resp.data.result.id;
            $scope.emlakIlanBaslik = resp.data.result.baslik;
            // window.location.href = 'http://localhost:4595/Login/ManageUser';
        }, function (err) {

        });
        $scope.isViewLoading = false;
    };
    //#endregion
    //#region Parametreler Get

    //İlan satılık kiralık devren
    var kategoriID = { id: 1 };
    loadRootKategoriler();

    function loadRootKategoriler() {
        var kategori = IlanEkleservice.kategoriler(kategoriID);
        kategori.then(function (resp) {
            $scope.getKategoriler = resp.data;
        }, function (err) { });
    }

    //İlan türü Konut İşyeri Arsa Tarla vb..
    var subID = {};
    $scope.ilanTuru = function loadIlanTuru() {

        subID = { id: $scope.parameters.SatilikId };
        var kat = IlanEkleservice.kategoriler(subID);

        kat.then(function (resp) {
            $scope.getIlanTuru = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
    };

    //İlan semtler
    var id = {};
    $scope.clickSemt = function loadSemt() {
       // console.log($scope.parameters.id);
        id = { Id: $scope.parameters.id };

        var kat = IlanEkleservice.location(id);

        kat.then(function (resp) {
            $scope.getSemt = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
    };

    //Mahalle
    $scope.clickMahalle = function loadMahalle() {

        kategoriID = {
            Id: $scope.parameters.SemtId
        };
        var kat = IlanEkleservice.location(kategoriID);

        kat.then(function (resp) {
            $scope.getKategorilerMahalle = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
    };
    //#endregion

    //#region Location Get
    var config = { id: 1 };
    loadLocation();
    function loadLocation() {
        var location = IlanEkleservice.location(config);

        location.then(function (resp) {
            $scope.getLocation = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
    }
    //#endregion 

    //#region Load default query
    $scope.emlakEmlakTakasli = [];
    $scope.emlakOdaSayisi = [];
    $scope.emlakBulunduguKat = [];
    $scope.emlakIsitmaSekli = [];
    $scope.emlakIcOzellikler = [];
    $scope.emlakDisOzellikler = [];
    $scope.emlakKonutTipi = [];
    $scope.emlakImarDurumu = [];
    $scope.emlakTapuDurumu = [];
    $scope.emlakKullanimAmaci = [];
    $scope.emlakKimden = [];
    $scope.emlakIlanId = '';
    $scope.emlakIlanBaslik = '';
    $scope.emlakIlanResim = '';

    loadEmlakTakasli();
    loadEmlakOdaSayisi();
    loadBulunduguKat();
    loadIsitmaSekli();
    loadDisOzellikler();
    loadIcOzellikler();
    loadEmlakKonutTipi();
    loadEmlakImarDurumu();
    loadEmlakTapuDurumu();
    loadEmlakKullanimAmaci();
    loadEmlakKimden();

    function loadEmlakKimden() {
        var kat = IlanEkleservice.EmlakKimden();
        kat.then(function (resp) {
            $scope.emlakKimden = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = 'ERROR:' + err.status;
        });
    }
    function loadEmlakKullanimAmaci() {
        var kat = IlanEkleservice.EmlakKullanimAmaci();
        kat.then(function (resp) {
            $scope.emlakKullanimAmaci = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = 'ERROR:' + err.status;
        });
    }
    function loadEmlakTapuDurumu() {
        var kat = IlanEkleservice.EmlakTapuDurumu();
        kat.then(function (resp) {
            $scope.emlakTapuDurumu = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = 'ERROR:' + err.status;
        });
    }
    function loadEmlakImarDurumu() {
        var kat = IlanEkleservice.EmlakImarDurumu();
        kat.then(function (resp) {
            $scope.emlakImarDurumu = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = 'ERROR:' + err.status;
        });
    }
    function loadEmlakKonutTipi() {
        var kat = IlanEkleservice.EmlakKonutTipi();

        kat.then(function (resp) {
            $scope.emlakKonutTipi = resp.data;
            $scope.Message = "OK...";
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
    }

    function loadEmlakTakasli() {
        var query = IlanEkleservice.EmlakTakasli();

        query.then(function (resp) {
            $scope.emlakEmlakTakasli = resp.data;
            $scope.Message = "Tapu Takasli Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status;
        });
    }
    function loadEmlakOdaSayisi() {
        var emlakOdaSayisi = IlanEkleservice.EmlakOdaSayisi();

        emlakOdaSayisi.then(function (resp) {
            $scope.emlakOdaSayisi = resp.data;
            $scope.Message = "Oda Sayısı Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status;
        });
    }
    function loadBulunduguKat() {
        var query = IlanEkleservice.EmlakBulunduguKat();

        query.then(function (resp) {
            $scope.emlakBulunduguKat = resp.data;
            $scope.Message = "Bulunduğu kat Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status;
        });
    }
    function loadIsitmaSekli() {
        var query = IlanEkleservice.EmlakIsitmaSekli();

        query.then(function (resp) {
            $scope.emlakIsitmaSekli = resp.data;
            $scope.Message = "Isıtma Durumu Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status;
        });
    }
    function loadIcOzellikler() {
        var query = IlanEkleservice.EmlakIcOzellikler();

        query.then(function (resp) {
            $scope.emlakIcOzellikler = resp.data;
            $scope.Message = "İç Özellikler Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status;
        });
    }
    function loadDisOzellikler() {
        var query = IlanEkleservice.EmlakDisOzellikler();

        query.then(function (resp) {
            $scope.emlakDisOzellikler = resp.data;
            $scope.Message = "Dis Ozellikler Completed Successfully";
        }, function (err) {
            $scope.Message = "Error: " + err.status;
        });
    }
    //#endregion

    //#region Select unselect check
    $scope.selectionic = [];
    $scope.toggleSelection = function toggleSelection(fruitName) {
        var idx = $scope.selectionic.indexOf(fruitName);

        // is currently selected
        if (idx > -1) {
            $scope.selectionic.splice(idx, 1);
        }

            // is newly selected
        else {
            $scope.selectionic.push(fruitName);
        }
    };
    $scope.selectiondis = [];
    $scope.disSelection = function disSelection(fruitName) {
        var idx = $scope.selectiondis.indexOf(fruitName);

        // is currently selected
        if (idx > -1) {
            $scope.selectiondis.splice(idx, 1);
        }

            // is newly selected
        else {
            $scope.selectiondis.push(fruitName);
        }
    };
    //#endregion



    //#region Upload picture
    $scope.uploading = false;
    $scope.countFiles = '';
    $scope.data = []; //For displaying file name on browser
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

        //This line just shows you there is possible to
        //send in the extra parameter to the server.



        $scope.imageIsLoaded = function (e) {
            $scope.$apply(function () {
                $scope.imagesrc.push(e.target.result);
            });
        };

        $scope.countFiles = $scope.data.length === 0 ? '' : $scope.data.length + ' dosya seçildi...';
        $scope.$apply();
        $scope.formdata.append('countFiles', $scope.countFiles);
        $scope.formdata.append("id", $scope.emlakIlanId);
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
        var query = imgservice.uploadimg($scope);
        query.then(function (resp) {

            $scope.uploading = false;
            $scope.formdata = new FormData();
            $scope.data = [];
            $scope.countFiles = '';
            $scope.$apply;
            $scope.clear;
            $scope.emlakIlanResim = resp.data.result.resim;

        }, function (err) {
            alert("Error!!! " + err);
        });
       
    };
    $scope.clear = function () {
        angular.element("input[type='file']").val(null);
    };
    
});

