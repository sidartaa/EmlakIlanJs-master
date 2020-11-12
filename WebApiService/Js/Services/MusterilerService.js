torbaliBurada.service('MusterilerService', function ($http, $window, $location) {

    var accesstoken = localStorage.getItem('accessToken');
    var authHeaders = {};
    if (accesstoken !== null) {
        if (accesstoken) {
            authHeaders.Authorization = 'Bearer ' + accesstoken;
        }
    }
    this.musteriekle = function (musteri) {
        var resp = $http({
            url: "/api/MusteriList/MusteriEkle/",
            method: "POST",
            data: $.param({
                Ad: musteri.Ad,
                Soyad: musteri.Soyad,
                Email: musteri.Email,
                CepTelefonu: musteri.CepTelefonu,
                EnDusukFiyat: musteri.EnDusukFiyat,
                EnYuksekFiyat: musteri.EnYuksekFiyat,
                Statu:musteri.Statu,
                Kategori: JSON.stringify(musteri.Kategori),
                Location: JSON.stringify(musteri.Location),
                
            }),
            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=utf-8', 'Authorization': authHeaders.Authorization },
            contentType: 'application/json'
        });

        return resp;
    };
});