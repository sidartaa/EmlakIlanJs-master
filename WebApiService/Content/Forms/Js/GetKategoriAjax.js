//Kategori Seçimi Başladı
$(document).ready(function () {
    $('#myForm').validator();
    //Kategori Seç
    $('input[name="KategoriID"]').on('click', function (e) {
        var option = $('input[name="KategoriID"]:checked').val();
        $(".oneStep").addClass("display-none");
        $('#semt').addClass('display-none');
        $('#mahalle').addClass('display-none');
        $.ajax({
            type: "POST",
            url: "/Manage/SatilikKiralik",
            data: { "id": option },
        dataType: "json",
        beforeSend: function () {
            $('#divLoading').removeClass('display-none');
        },
        success: function (result) {
            var ff = $("#yaz");
            ff.empty();
            var d = result;
            for (var i = 0; i < result.length; i++) {
                ff.append('<div class="col-md-3"><div class="funkyradio-info"><input id="alt' + d[i].KategoriID + '" type="radio" name="alt" value="' + d[i].KategoriID + '"  required /><label for="alt' + d[i].KategoriID + '">' + d[i].KategoriAd + '</label></div>');
            }
            
            $('#divLoading').addClass('display-none');
            $("#ff").removeClass("display-none");
            $('#myForm').validator('update');
            
        }
    });
});
//Bitti
//Satılık Kiralık seç
$(document).on('click', 'input[name="alt"]', function (e) {
    var option = $('input[name="alt"]:checked').val();
    $(".oneStep").addClass("display-none");
    $('#mahalle').addClass('display-none');
    $.ajax({
        type: "POST",
        url: "/Manage/SemtSec",
        data: { "id": option },
    dataType: "json",
    beforeSend: function () {
        $('#divLoading').removeClass('display-none');
    },
    success: function (result) {
        var ff = $("#semtyaz");
        ff.empty();
       
        var d = result;
        for (var i = 0; i < result.length; i++) {
            ff.append('<div class="col-md-3"><div class="funkyradio-info"><input id="semt' + d[i].KategoriID + '" type="radio" name="semt" value="' + d[i].KategoriID + '"  required="required" /><label for="semt' + d[i].KategoriID + '">' + d[i].KategoriAd + '</label></div></div>');
        }
        
        $('#divLoading').addClass('display-none');
        $("#semt").removeClass("display-none");
        $('#myForm').validator('update');
    }
});
});
//Bitti
//Semt Seç
$(document).on('click', 'input[name="semt"]', function (e) {
    var option = $('input[name="semt"]:checked').val();
    $(".oneStep").addClass("display-none");
    $.ajax({
        type: "POST",
        url: "/Manage/MahalleSec",
        data: { "id": option },
    dataType: "json",
    beforeSend: function () {
        $('#divLoading').removeClass('display-none');
    },
    success: function (result) {
        var ff = $("#mahalleyaz");
        ff.empty();
       
        var d = result;
        for (var i = 0; i < result.length; i++) {
            ff.append('<div class="col-md-3"><div class="funkyradio-info"><input id="mahalle' + d[i].KategoriID + '" type="radio" name="mahalle" value="' + d[i].KategoriID + '"  required="required" /><label for="mahalle' + d[i].KategoriID + '">' + d[i].KategoriAd + '</label></div></div>');
        }
       
        $('#divLoading').addClass('display-none');
        $("#mahalle").removeClass("display-none");
        $('#myForm').validator('update');
    }
});
});
//Bitti
// Mahalle Seç
$(document).on('click', 'input[name="mahalle"]', function (e) {
    $('#myForm').validator('update');
    //console.log("none");
    if ($('input[name="mahalle"]:checked').is(":checked")) {
        $(".oneStep").removeClass("display-none");
    }
    else {
        $(".oneStep").addClass("display-none");
    }
});
    //Bitti
    //Form Oluştur
$(document).on("click", ".oneStep", function (e) {
    // KategoriID=2&alt=6&semt=23&mahalle=170
    var id = $('input[name="KategoriID"]:checked').val();
    var is = $('input[name="semt"]:checked').val();
    var iz = $('input[name="alt"]:checked').val();
    var im = $('input[name="mahalle"]:checked').val();
   
    var formData = $('#myForm').serializeObject();

    $.extend(formData, { 'KategoriID': id,'Alt':iz,"Semt":is ,"Mahalle":im}); //Send Additional data
    $.ajax({
        type: "POST",
        
        url: "/Manage/IlanEkle",
        data: decodeURIComponent($.param(formData)),
        dataType: "json",
        beforeSend: function () {
            $('#divLoading').removeClass('display-none');
        },
        success: function (data) {
            var ff = $("#FormToUpdate");
            ff.html("Yükleniyor...");
            ff.empty();
            $.post(data.Url, function (partial) {
                $('#FormToUpdate').html(partial);
                $('.selectpicker').selectpicker({
                    style: 'btn',
                    size: 8
                });
                $('#myForm').validator('update');
            });
            $('#divLoading').addClass('display-none');
           
        },
        error: function (xhr, ajaxOptions, thrownError) {
           
            $('#FormToUpdate').html(xhr.statusText + "::: " + thrownError + "::: " + ajaxOptions.toString());
           
            $('#divLoading').addClass('display-none');
        }
         
    });

});
$.fn.serializeObject = function () {
    var o = {};
    var a = this.serializeArray();
    $.each(a, function () {
        if (o[this.name] !== undefined) {
            if (!o[this.name].push) {
                o[this.name] = [o[this.name]];
            }
            o[this.name].push(this.value || '');
        } else {
            o[this.name] = this.value || '';
        }
    });
    return o;
};
    //Citti
    //Kaydet
$(document).on("click", ".twoStep", function (e) {
  
    // KategoriID=2&alt=6&semt=23&mahalle=170  
    //var KategoriID = $('input[name="KategoriID"]:checked').val();
    //var semt = $('input[name="semt"]:checked').val();
    //var alt = $('input[name="alt"]:checked').val();
    //var mahalle = $('input[name="mahalle"]:checked').val();
    //var Baslik = $('input[name="Baslik"]').val();
    //var Acilkama = $('input[name=Aciklama]').val();
    //var Fiyat = $('input[name=Fiyat]').val();
    //var Metrekare = $('input[name=Metrekare]').val();
    //var KimdenID = $('input[name=KimdenID]:checked').val();
    //var KullanimDurumuID = $('input[name=KullaninDurumuID]:checked').val();
    //var TakasliID = $('select[name=TakasliID]').selectpicker('val');
    //var OdaSayisiID = $('select[name=OdaSayisiID]').selectpicker('val');
    //var BinaYasiID = $('select[name=BinaYasiID]').selectpicker('val');
    //var KatSayisiID = $('select[name=KatSayisiID]').selectpicker('val');
    //var BanyoSayisiID = $('select[name=BanyoSayisiID]').selectpicker('val');
    //var SiteIcerisindeID = $('select[name=SiteIcerisindeID]').selectpicker('val');

    //var IsitmaID = [];
    ////var array = $.map($('input[name="locationthemes"]:checked'), function(c){return c.value; })
    //$('input[name=IsitmaID]:checked').each(function () {
    //    if ($(this).is(':checked'))
    //        IsitmaID.push($(this).val());
    //});
    var IsitmaID = $('input[name=IsitmaID]:checked').map(function () {

        return $(this).val();

    }).get();
    
   // console.log(searchIDs);
    //var CepheID = [];
    //$('input[name=CepheID]:checked').each(function () {
    //    if ($(this).is(':checked'))
    //        CepheID.push($(this).val());
    //});
    //var IcOzellikID = [];
    //$('input[name=IcOzellikID]:checked').each(function () {
    //    if ($(this).is(':checked'))
    //        IcOzellikID.push($(this).val());
    //});
    //var DisOzellikID = [];
    //$('input[name=DisOzellikID]:checked').each(function () {
    //    if ($(this).is(':checked'))
    //        DisOzellikID.push($(this).val());
    //});
    //var ResimID = [];
    //$('input[name=ResimID]:checked').each(function () {
    //    if ($(this).is(':checked'))
    //        ResimID.push($(this).val());
    //});
    ////Arsa Form
    //var ArsaKonumID = $();
    //var ArsaManzaraID = $();
    //var ArsaGenelOzellikID = $();
    var formData = $('#myForm').serializeObject();
    $.extend(formData, { 'yeni': IsitmaID }); //Send Additional data
    
    $.ajax({
        type: "POST",
        url: "/Manage/IkanEkleIki",
        data: decodeURIComponent($.param(formData)),
        dataType: "json",
        beforeSend: function () {
            $('#divLoading').removeClass('display-none');
        },
        success: function (data) {
            var ff = $("#FormToPicture");
            ff.html("Yükleniyor...");
            ff.empty();
            $.post(data.Url, function (partial) {
                $('#FormToPicture').html(partial);
                
            });
            $('#divLoading').addClass('display-none');
            $('#myForm').validator('update');
        },
        error: function (xhr, ajaxOptions, thrownError) {

            $('#FormToUpdate').html(xhr.statusText + "::: " + thrownError + "::: " + ajaxOptions.toString());

            $('#divLoading').addClass('display-none');
        }
    });

});
});