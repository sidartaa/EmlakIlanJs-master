(function (jQuery) {
    "use strict";
   
    function Carousel() {
       
        //jQuery(document).ready(function () {
        //    var owl = $("#rece");
        //    owl.owlCarousel({
        //        pagination: false,
        //        slideSpeed: 1000,
        //        itemsCustom: [
		//		[0, 1],
		//		[480, 1],
		//		[600, 1],
		//		[768, 2],
		//		[800, 2],
		//		[980, 2],
		//		[1024, 2],
		//		[1280, 2],
		//		[1920, 2]
        //        ]
        //    });
        //    $(".recenext").click(function () {
        //        owl.trigger('owl.next');
        //    })
        //    $(".receprev").click(function () {
        //        owl.trigger('owl.prev');
        //    })
        //});
        //jQuery(document).ready(function () {
        //    var owl = $("#rela");
        //    owl.owlCarousel({
        //        pagination: false,
        //        slideSpeed: 1000,
        //        itemsCustom: [
		//		[0, 1],
		//		[480, 1],
		//		[600, 1],
		//		[768, 2],
		//		[800, 2],
		//		[980, 2],
		//		[1024, 2],
		//		[1280, 2],
		//		[1920, 2]
        //        ]
        //    });
        //    $(".relanext").click(function () {
        //        owl.trigger('owl.next');
        //    })
        //    $(".relaprev").click(function () {
        //        owl.trigger('owl.prev');
        //    })
        //});
        //jQuery(document).ready(function () {
        //    var owl = $("#phot");
        //    owl.owlCarousel({
        //        pagination: false,
        //        slideSpeed: 1000,
        //        itemsCustom: [
		//		[0, 1],
		//		[480, 1],
		//		[600, 1],
		//		[768, 1],
		//		[800, 1],
		//		[980, 1],
		//		[1024, 1],
		//		[1280, 1],
		//		[1920, 1]
        //        ]
        //    });
        //    $(".photnext").click(function () {
        //        owl.trigger('owl.next');
        //    })
        //    $(".photprev").click(function () {
        //        owl.trigger('owl.prev');
        //    })
        //});
        //jQuery(document).ready(function () {
        //    var owl = $("#trav");
        //    owl.owlCarousel({
        //        pagination: false,
        //        slideSpeed: 1000,
        //        itemsCustom: [
		//		[0, 1],
		//		[480, 1],
		//		[600, 1],
		//		[768, 1],
		//		[800, 1],
		//		[980, 1],
		//		[1024, 1],
		//		[1280, 1],
		//		[1920, 1]
        //        ]
        //    });
        //    $(".travnext").click(function () {
        //        owl.trigger('owl.next');
        //    })
        //    $(".travprev").click(function () {
        //        owl.trigger('owl.prev');
        //    })
        //});
        //jQuery(document).ready(function () {
        //    var owl = $("#auth");
        //    owl.owlCarousel({
        //        pagination: false,
        //        slideSpeed: 1000,
        //        itemsCustom: [
		//		[0, 1],
		//		[480, 1],
		//		[600, 1],
		//		[768, 1],
		//		[800, 1],
		//		[980, 1],
		//		[1024, 1],
		//		[1280, 1],
		//		[1920, 1]
        //        ]
        //    });
        //    $(".authnext").click(function () {
        //        owl.trigger('owl.next');
        //    })
        //    $(".authprev").click(function () {
        //        owl.trigger('owl.prev');
        //    })
        //});
        //jQuery(document).ready(function () {
        //    var owl = $("#lead");
        //    owl.owlCarousel({
        //        pagination: false,
        //        slideSpeed: 1000,
        //        itemsCustom: [
		//		[0, 1],
		//		[480, 1],
		//		[600, 1],
		//		[768, 1],
		//		[800, 1],
		//		[980, 1],
		//		[1024, 1],
		//		[1280, 1],
		//		[1920, 1]
        //        ]
        //    });
        //    $(".leadnext").click(function () {
        //        owl.trigger('owl.next');
        //    })
        //    $(".leadprev").click(function () {
        //        owl.trigger('owl.prev');
        //    })
        //});
        //jQuery(document).ready(function () {
        //    var owl = $("#edit");
        //    owl.owlCarousel({
        //        pagination: false,
        //        slideSpeed: 1000,
        //        itemsCustom: [
		//		[0, 1],
		//		[480, 1],
		//		[600, 1],
		//		[768, 1],
		//		[800, 1],
		//		[980, 1],
		//		[1024, 1],
		//		[1280, 1],
		//		[1920, 1]
        //        ]
        //    });
        //    $(".editnext").click(function () {
        //        owl.trigger('owl.next');
        //    })
        //    $(".editprev").click(function () {
        //        owl.trigger('owl.prev');
        //    })
        //});
        //jQuery(document).ready(function () {
        //    var owl = $("#part");
        //    owl.owlCarousel({
        //        pagination: false,
        //        slideSpeed: 1000,
        //        itemsCustom: [
		//		[0, 2],
		//		[480, 2],
		//		[600, 2],
		//		[768, 3],
		//		[800, 3],
		//		[980, 3],
		//		[1024, 3],
		//		[1280, 3],
		//		[1920, 3]
        //        ]
        //    });
        //    $(".partnext").click(function () {
        //        owl.trigger('owl.next');
        //    })
        //    $(".partprev").click(function () {
        //        owl.trigger('owl.prev');
        //    })
        //});
        //jQuery(document).ready(function () {
        //    var owl = $("#soci");
        //    owl.owlCarousel({
        //        pagination: false,
        //        slideSpeed: 1000,
        //        itemsCustom: [
		//		[0, 7],
		//		[480, 9],
		//		[600, 10],
		//		[768, 11],
		//		[800, 11],
		//		[980, 11],
		//		[1024, 12],
		//		[1280, 12],
		//		[1920, 12]
        //        ]
        //    });
        //    $(".socinext").click(function () {
        //        owl.trigger('owl.next');
        //    })
        //    $(".sociprev").click(function () {
        //        owl.trigger('owl.prev');
        //    })
        //});
        //jQuery(document).ready(function () {
        //    var owl = $("#tech");
        //    owl.owlCarousel({
        //        pagination: false,
        //        slideSpeed: 1000,
        //        itemsCustom: [
		//		[0, 1],
		//		[480, 1],
		//		[600, 1],
		//		[768, 1],
		//		[800, 1],
		//		[980, 1],
		//		[1024, 1],
		//		[1280, 1],
		//		[1920, 1]
        //        ]
        //    });
        //    $(".technext").click(function () {
        //        owl.trigger('owl.next');
        //    })
        //    $(".techprev").click(function () {
        //        owl.trigger('owl.prev');
        //    })
        //});
        //jQuery(document).ready(function () {
        //    var owl = $("#busi");
        //    owl.owlCarousel({
        //        pagination: false,
        //        slideSpeed: 1000,
        //        itemsCustom: [
		//		[0, 1],
		//		[480, 1],
		//		[600, 1],
		//		[768, 2],
		//		[800, 2],
		//		[980, 2],
		//		[1024, 2],
		//		[1280, 2],
		//		[1920, 2]
        //        ]
        //    });
        //    $(".businext").click(function () {
        //        owl.trigger('owl.next');
        //    })
        //    $(".busiprev").click(function () {
        //        owl.trigger('owl.prev');
        //    })
        //});
        //jQuery(document).ready(function () {
        //    var owl = $("#gall");
        //    owl.owlCarousel({
        //        pagination: false,
        //        slideSpeed: 1000,
        //        itemsCustom: [
		//		[0, 2],
		//		[480, 3],
		//		[600, 3],
		//		[768, 3],
		//		[800, 3],
		//		[980, 4],
		//		[1024, 4],
		//		[1280, 4],
		//		[1920, 4]
        //        ]
        //    });
        //    $(".gallnext").click(function () {
        //        owl.trigger('owl.next');
        //    })
        //    $(".gallprev").click(function () {
        //        owl.trigger('owl.prev');
        //    })
        //});
        //jQuery(document).ready(function () {
        //    var owl = $("#gallery");
        //    owl.owlCarousel({
        //        pagination: false,
        //        slideSpeed: 1000,
        //        itemsCustom: [
		//		[0, 1],
		//		[480, 1],
		//		[600, 1],
		//		[768, 1],
		//		[800, 1],
		//		[980, 1],
		//		[1024, 1],
		//		[1280, 1],
		//		[1920, 1]
        //        ]
        //    });
        //    $(".gallerynext").click(function () {
        //        owl.trigger('owl.next');
        //    })
        //    $(".galleryprev").click(function () {
        //        owl.trigger('owl.prev');
        //    })
        //});
    }
})(jQuery);