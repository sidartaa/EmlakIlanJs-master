$(document).ready(function () {
    $(".btn-select").each(function (e) {
        var value = $(this).find("ul li.selected").html();
        if (value != undefined) {
            $(this).find(".btn-select-input").val(value);
            $(this).find(".btn-select-value").html(value);
        }
    });
});
$(document).on('click', '#refresh', function () {
    $(".btn-select").each(function (e) {
        var value = $(this).find("ul li.selected").html();
       // if (value != undefined) {
            $(this).find(".btn-select-input").val('');
            $(this).find(".kategori").html("<i class='fa fa-hand-pointer-o' aria-hidden='true'></i> İlan Kategorisi Seçiniz"); 
            $(this).find(".location").html("<i class='fa fa-hand-pointer-o' aria-hidden='true'></i> İlan Semtini Seçiniz");
            $(this).find(".satilik").html("<i class='fa fa-hand-pointer-o' aria-hidden='true'></i> İlan Türünü Seçiniz");
            $(this).find(".konut").html("<i class='fa fa-hand-pointer-o' aria-hidden='true'></i> Emlak Türünü Seçiniz");
            $(this).find(".isyeri").html("<i class='fa fa-hand-pointer-o' aria-hidden='true'></i> İşyeri Türünü Seçiniz");
            $(this).find(".btn-select-input").attr('id', '');
       // }
    });

});
$(document).on('click', '.btn-select', function (e) {
    e.preventDefault();
    var ul = $(this).find("ul");
    if ($(this).hasClass("active")) {
        if (ul.find("li").is(e.target)) {
            var target = $(e.target);
            target.addClass("selected").siblings().removeClass("selected");
            var value = target.html();           
            var id = target.attr('id');
            $(this).find(".btn-select-input").attr('id', id);
           // $(this).find(".btn-select-input").attr('id', id);
            $(this).find(".btn-select-input").val(id);
            $(this).find(".btn-select-value").html(value);
           
        }
        ul.hide();
        $(this).removeClass("active");
    }
    else {
        $('.btn-select').not(this).each(function () {
            $(this).removeClass("active").find("ul").hide();
        });
        ul.slideDown(300);
        $(this).addClass("active");
    }
});

$(document).on('click', function (e) {
    var target = $(e.target).closest(".btn-select");
    if (!target.length) {
        $(".btn-select").removeClass("active").find("ul").hide();
    }
});
