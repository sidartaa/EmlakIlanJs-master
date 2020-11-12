torbaliBurada.controller('MusterilerController', function ($scope, $http, $routeParams, IlanEkleservice) {
    $scope.param = $routeParams.param;
    alert($scope.param);
    //Form Elemanları
    $scope.musteri = {
        Ad: '',
        Soyad: '',
        Email: '',
        CepTelefonu: '',
        EnDusukFiyat: '',
        EnYuksekFiyat: '',
        Statu: '',
        Kategori: '',
        Location: ''
    };
    //Loading
    $scope.isMusteriSaveLoading = false;

    //Müşteri Kaydet
    $scope.musteriSave = function () {
        $scope.isMusteriSaveLoading = true;
        $scope.responseData = "";
        var musteri = {
            Ad: $scope.musteri.Ad,
            Soyad: $scope.musteri.Soyad,
            Email: $scope.musteri.Email,
            CepTelefonu: $scope.musteri.CepTelefonu,
            EnDusukFiyat: $scope.musteri.EnDusukFiyat,
            EnYuksekFiyat: $scope.musteri.EnYuksekFiyat,
            Statu: $scope.musteri.Statu,
            Kategori: $scope.selectionic,
            Tur: $scope.selectiondis,
            Location: $scope.selectionLocation,
            Semt:$scope.selectionSemt
        };
        var musterikaydet = IlanEkleservice.musteriekle(musteri);
        musterikaydet.then(function (resp) {
            $scope.responseData = resp.data;
        }, function (err) {

        });
        $scope.isMusteriSaveLoading = false;
    };

    //#region Select unselect check
    $scope.selectionic = [];
    $scope.toggleSelection = function toggleSelection(fruitName) {

        var idx = $scope.selectionic.indexOf(fruitName);
        $scope.ilanTuru(fruitName);
              
        if (idx > -1) {           
            $scope.selectionic.splice(idx, 1);
            $scope.ilanTuruSplit(fruitName);
        }
        else {
            $scope.selectionic.push(fruitName);         
        }
    };
    $scope.selectiondis = [];
    $scope.disSelection = function disSelection(fruitName) {

        var idx = $scope.selectiondis.indexOf(fruitName);

        if (idx > -1) {
            $scope.selectiondis.splice(idx, 1);            
        }           
        else {
            $scope.selectiondis.push(fruitName);
        }
    };

    $scope.selectionLocation = [];
    $scope.locSelection = function disSelection(fruitName) {
        $scope.clickSemt(fruitName);
        var idx = $scope.selectionLocation.indexOf(fruitName);

        if (idx > -1) {
            $scope.selectionLocation.splice(idx, 1);
        }
        else {
            $scope.selectionLocation.push(fruitName);
        }
    };
    $scope.selectionSemt = [];
    $scope.semSelection = function disSelection(fruitName) {

        var idx = $scope.selectionSemt.indexOf(fruitName);

        if (idx > -1) {
            $scope.selectionSemt.splice(idx, 1);
        }
        else {
            $scope.selectionSemt.push(fruitName);
        }
    };
    //#endregion

    //Müşteri Listele
    $scope.parameters = {
        CurrentPage: 1,
        TotalPage: 0
    };
    var getMusteri = {
        page: 1
    };
    $scope.MusterilerSerach = function (data) {
        $scope.isMusteriSaveLoading = true;

        var promisesearch = IlanEkleservice.musterisearch(data);
        promisesearch.then(function (response) {
            if (data.page === 1)
                $scope.Musteriler = [];
          //  $scope.Location = [];
            angular.forEach(response.data.result.musteriler, function (value) {
                $scope.Musteriler.push(value);
            });
            
            $scope.parameters.TotalPage = response.data.result.totalPage;
            $scope.isMusteriSaveLoading = false;

        }, function () {
            $scope.isMusteriSaveLoading = false;
        });
    };
    $scope.NextPage = function () {

        if ($scope.parameters.CurrentPage < $scope.parameters.TotalPage) {
            $scope.parameters.CurrentPage += 1;


            var data = {
                page: $scope.parameters.CurrentPage                
            };

            $scope.MusterilerSerach(data);
        }
    };
    $scope.MusterilerSerach(getMusteri);

    //
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
   // var subID = {};
    $scope.ilanTuru = function loadIlanTuru(subID) {

        subID = { id: subID };
       
        var kat = IlanEkleservice.kategoriler(subID);

        kat.then(function (resp) {
            $scope.getIlanTuru = resp.data;            
           
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
    };
    $scope.ilanTuruSplit = function loadIlanTuru(subID) {

        subID = { id: subID };       
        var kat = IlanEkleservice.kategoriler(subID);

        kat.then(function (resp) {
         
            angular.forEach(resp.data.result, function (value) {
               
                var idx = $scope.selectiondis.indexOf(value.id);
                if (idx > -1) {
                    $scope.selectiondis.splice(idx, 1);
                }
            });
           
        }, function (err) {
            $scope.Message = "ERROR: " + err.status;
        });
    };
    //İlan semtler
    var id = {};
    $scope.clickSemt = function loadSemt(sentid) {
        // console.log($scope.parameters.id);
        id = { Id: sentid };

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
});