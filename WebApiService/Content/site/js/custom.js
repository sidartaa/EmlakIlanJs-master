(function (jQuery) {
    "use strict";  
    var check = true;
    jQuery.fn.ccTheme = function (options) {
        return this.each(function () {
            init(jQuery(this));
								}); 	
		function flexslider(){
				$(window).load(function (){
					$('.flexslider').flexslider({
					animation: "slide",
					start: function(slider){
					$('body').removeClass('loading');
					}
					});
				});
		}
		function progress(){
			jQuery(document).ready(function (){

			function mixProgress(container) {
			return container.each(function (){
				var wrap = jQuery(this);

				wrap.find('.progress').each(function(i) {
					var element = jQuery(this);
					//console.debug(element);
					var w_att = element.find('.bar', wrap).attr('data-progress');
					element.find('.bar', wrap).css('width', w_att + '%');

					setTimeout(function(){ 
						element.addClass('start_animation animation'+i);
						
						jQuery('.animation'+i).find('.bar', wrap).countTo();
					}, (i * 11250));

				});
			});
			}

			var container = jQuery('.prog-wrap');

			mixProgress(container);
			});
			$('.timer').each(count);			  
			  function count(options) {
				var $this = $(this);
				options = $.extend({}, options || {}, $this.data('countToOptions') || {});
				$this.countTo(options);
			  }
		}
		function Carousel() {
			jQuery(document).ready(function(){
				var owl = $("#tren");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 1],
				[480, 1],
				[600, 1],
				[768, 1],
				[800, 1],
				[980, 1],
				[1024, 1],
				[1280, 1],
				[1920, 1]
				]
				});
				$(".trennext").click(function(){
				owl.trigger('owl.next');
				})
				$(".trenprev").click(function(){
				owl.trigger('owl.prev');
				})	
			});		
			jQuery(document).ready(function(){
				var owl = $("#rece");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 1],
				[480, 1],
				[600, 1],
				[768, 2],
				[800, 2],
				[980, 2],
				[1024, 2],
				[1280, 2],
				[1920, 2]
				]
				});
				$(".recenext").click(function(){
				owl.trigger('owl.next');
				})
				$(".receprev").click(function(){
				owl.trigger('owl.prev');
				})			
			});				
			jQuery(document).ready(function(){
				var owl = $("#rela");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 1],
				[480, 1],
				[600, 1],
				[768, 2],
				[800, 2],
				[980, 2],
				[1024, 2],
				[1280, 2],
				[1920, 2]
				]
				});
				$(".relanext").click(function(){
				owl.trigger('owl.next');
				})
				$(".relaprev").click(function(){
				owl.trigger('owl.prev');
				})			
			});		
			jQuery(document).ready(function(){
				var owl = $("#phot");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 1],
				[480, 1],
				[600, 1],
				[768, 1],
				[800, 1],
				[980, 1],
				[1024, 1],
				[1280, 1],
				[1920, 1]
				]
				});
				$(".photnext").click(function(){
				owl.trigger('owl.next');
				})
				$(".photprev").click(function(){
				owl.trigger('owl.prev');
				})			
			});			
			jQuery(document).ready(function(){
				var owl = $("#trav");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 1],
				[480, 1],
				[600, 1],
				[768, 1],
				[800, 1],
				[980, 1],
				[1024, 1],
				[1280, 1],
				[1920, 1]
				]
				});
				$(".travnext").click(function(){
				owl.trigger('owl.next');
				})
				$(".travprev").click(function(){
				owl.trigger('owl.prev');
				})			
			});				
			jQuery(document).ready(function(){
				var owl = $("#auth");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 1],
				[480, 1],
				[600, 1],
				[768, 1],
				[800, 1],
				[980, 1],
				[1024, 1],
				[1280, 1],
				[1920, 1]
				]
				});
				$(".authnext").click(function(){
				owl.trigger('owl.next');
				})
				$(".authprev").click(function(){
				owl.trigger('owl.prev');
				})			
			});			
			jQuery(document).ready(function(){
				var owl = $("#lead");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 1],
				[480, 1],
				[600, 1],
				[768, 1],
				[800, 1],
				[980, 1],
				[1024, 1],
				[1280, 1],
				[1920, 1]
				]
				});
				$(".leadnext").click(function(){
				owl.trigger('owl.next');
				})
				$(".leadprev").click(function(){
				owl.trigger('owl.prev');
				})			
			});				
			jQuery(document).ready(function(){
				var owl = $("#edit");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 1],
				[480, 1],
				[600, 1],
				[768, 1],
				[800, 1],
				[980, 1],
				[1024, 1],
				[1280, 1],
				[1920, 1]
				]
				});
				$(".editnext").click(function(){
				owl.trigger('owl.next');
				})
				$(".editprev").click(function(){
				owl.trigger('owl.prev');
				})			
			});				
			jQuery(document).ready(function(){
				var owl = $("#part");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 2],
				[480, 2],
				[600, 2],
				[768, 3],
				[800, 3],
				[980, 3],
				[1024, 3],
				[1280, 3],
				[1920, 3]
				]
				});
				$(".partnext").click(function(){
				owl.trigger('owl.next');
				})
				$(".partprev").click(function(){
				owl.trigger('owl.prev');
				})			
			});			
			jQuery(document).ready(function(){
				var owl = $("#soci");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 7],
				[480, 9],
				[600, 10],
				[768, 11],
				[800, 11],
				[980, 11],
				[1024, 12],
				[1280, 12],
				[1920, 12]
				]
				});
				$(".socinext").click(function(){
				owl.trigger('owl.next');
				})
				$(".sociprev").click(function(){
				owl.trigger('owl.prev');
				})			
			});			
			jQuery(document).ready(function(){
				var owl = $("#tech");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 1],
				[480, 1],
				[600, 1],
				[768, 1],
				[800, 1],
				[980, 1],
				[1024, 1],
				[1280, 1],
				[1920, 1]
				]
				});
				$(".technext").click(function(){
				owl.trigger('owl.next');
				})
				$(".techprev").click(function(){
				owl.trigger('owl.prev');
				})			
			});				
			jQuery(document).ready(function(){
				var owl = $("#busi");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 1],
				[480, 1],
				[600, 1],
				[768, 2],
				[800, 2],
				[980, 2],
				[1024, 2],
				[1280, 2],
				[1920, 2]
				]
				});
				$(".businext").click(function(){
				owl.trigger('owl.next');
				})
				$(".busiprev").click(function(){
				owl.trigger('owl.prev');
				})			
			});			
			jQuery(document).ready(function(){
				var owl = $("#gall");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 2],
				[480, 3],
				[600, 3],
				[768, 3],
				[800, 3],
				[980, 4],
				[1024, 4],
				[1280, 4],
				[1920, 4]
				]
				});
				$(".gallnext").click(function(){
				owl.trigger('owl.next');
				})
				$(".gallprev").click(function(){
				owl.trigger('owl.prev');
				})			
			});			
			jQuery(document).ready(function(){
				var owl = $("#gallery");
				owl.owlCarousel({
				pagination : false,
				slideSpeed: 1000,
				itemsCustom : [
				[0, 1],
				[480, 1],
				[600, 1],
				[768, 1],
				[800, 1],
				[980, 1],
				[1024, 1],
				[1280, 1],
				[1920, 1]
				]
				});
				$(".gallerynext").click(function(){
				owl.trigger('owl.next');
				})
				$(".galleryprev").click(function(){
				owl.trigger('owl.prev');
				})			
			});
		}
		function accordion() {
		    jQuery("ul.accordion li").each(function(){
		        if(jQuery(this).index() > 0){
		            jQuery(this).children(".accordion-content").css('display','none');
		        }else{
		            jQuery(this).find(".accordion-title").addClass('active');
		        }	                
		        jQuery(this).children(".accordion-title").bind("click", function(){
		            jQuery(this).addClass(function(){
		                if(jQuery(this).hasClass("active")) return "";
		                return "active";
		            });
		            jQuery(this).siblings(".accordion-content").slideDown();
		            jQuery(this).parent().siblings("li").children(".accordion-content").slideUp();
		            jQuery(this).parent().siblings("li").find(".active").removeClass("active");
		        });
		    });
		}
		
		function tabs() {	
				jQuery("#tabbed-widget .tabs-wrap").hide();
				jQuery("#tabbed-widget ul.posts-taps li:first").addClass("active").show();
				jQuery("#tabbed-widget .tabs-wrap:first").show();
				jQuery("#tabbed-widget  li.tabs").click(function(){
					jQuery("#tabbed-widget ul.posts-taps li").removeClass("active");jQuery(this).addClass("active");
					jQuery("#tabbed-widget .tabs-wrap").hide();var activeTab=jQuery(this).find("a").attr("href");
					jQuery(activeTab).slideDown();return false;
				});
		}
		//animated scroll loading effects		
		function animated() {	
			jQuery(document).ready(function() {				
				jQuery('.review').addClass("hidden").viewportChecker({
						classToAdd: 'visible animated fadeIn', 
						offset: 100,
						callbackFunction: function(elem){
							progress();
						}
				}); 
			}); 
		}			
		
		//popup		
		function popup() {	
		      jQuery(document).ready(function() {
		        jQuery('.popup-gallery').magnificPopup({
		          delegate: 'a',
		          type: 'image',
		          tLoading: 'Loading image #%curr%...',
		          mainClass: 'mfp-img-mobile',
		          gallery: {
		            enabled: true,
		            navigateByImgClick: true,
		            preload: [0,1] // Will preload 0 - before current, and 1 after the current image
		          },
		          image: {
		            tError: '<a href="../../../assets/js/%url%">The image #%curr%</a> could not be loaded.',
		            titleSrc: function(item) {
		              return item.el.attr('title') + '<small></small>';
		            }
		          }
		        });
		      });		      
			  
			  jQuery(document).ready(function() {
		        jQuery('.popup-photo').magnificPopup({
		          delegate: 'a',
		          type: 'image',
		          tLoading: 'Loading image #%curr%...',
		          mainClass: 'mfp-img-mobile',
		          gallery: {
		            enabled: true,
		            navigateByImgClick: true,
		            preload: [0,1] // Will preload 0 - before current, and 1 after the current image
		          },
		          image: {
		            tError: '<a href="../../../assets/js/%url%">The image #%curr%</a> could not be loaded.',
		            titleSrc: function(item) {
		              return item.el.attr('title') + '<small></small>';
		            }
		          }
		        });
		      });
		}		
		// Contact Form
		function contact(){ 
		    var error_report;
		    jQuery("#contact_submit").bind("click",function(){
		        // Hide notice message when submit
		        jQuery("#contact_form .notice_ok").hide();
		        jQuery("#contact_form .notice_error").hide();
		        error_report = false;

		        jQuery("#contact_form input, #contact_form textarea").each(function(i){

		            var form_element          = jQuery(this);
		            var form_element_value    = jQuery(this).val();
		            var form_element_id       = jQuery(this).attr("id");
		            //var form_element_class    = jQuery(this).attr("class");
		            var form_element_required = jQuery(this).hasClass("required");

		            // Check email validation
		            if(form_element_id === "contact_email"){
		                form_element.removeClass("error valid");
		                if(!form_element_value.match(/^\w[\w|\.|\-]+@\w[\w|\.|\-]+\.[a-zA-Z]{2,4}$/)){
		                    form_element.addClass("error");
		                    error_report = true;
		                } else {
		                    form_element.addClass("valid");
		                }
		            }

		            // Check input required validation
		            if(form_element_required && form_element_id !== "contact_email"){
		                form_element.removeClass("error valid");
		                if(form_element_value === ""){
		                    form_element.addClass("error");
		                    error_report = true;
		                } else {
		                    form_element.addClass("valid");
		                }
		            }

		            if(jQuery("#contact_form input, #contact_form textarea").length === i+1){
		                if(error_report === false){
		                    jQuery("#contact_form .loading").show();

		                    var $string = "ajax=true";
		                    jQuery("#contact_form input, #contact_form textarea").each(function(){
		                        var $form_element_name     = jQuery(this).attr("name");
		                        var $form_element_value    = encodeURIComponent(jQuery(this).val());
		                        $string = $string + "&" + $form_element_name + "=" + $form_element_value;
		                    });

		                    jQuery.ajax({
		                        type: "POST",
		                        url: "./page-contact-ajax.php",
		                        data:$string,
		                        success: function(response){
		                            jQuery("#contact_form .loading").hide();
		                            if(response === 'success'){
		                                jQuery("#contact_form .notice_ok").show();
		                                jQuery("#contact_form .field_submit").hide();
		                            } else {
		                                jQuery("#contact_form .notice_error").show();
		                                jQuery("#contact_form .field_submit").hide();
		                            }
		                        }
		                    });
		                }
		            }
		        });
		    return false;
		    });

		}	
/* ==========================================================================
   exists - Check if an element exists
   ========================================================================== */		
	
	function exists(e) {
		return $(e).length > 0;
	}


/* ==========================================================================
   handleMobileMenu 
   ========================================================================== */		

	function handleMobileMenu() {

		if ($(window).width() > 600) {
			
			$("#mobile-menu").hide();
			$("#mobile-menu-trigger").removeClass("mobile-menu-opened").addClass("mobile-menu-closed");
		
		} else {
			
			if (!exists("#mobile-menu")) {
				
				$("#menu").clone().attr({
					id: "mobile-menu",
					"class": "fixed container"
				}).insertAfter("#header");
				
				$("#mobile-menu > li > a, #mobile-menu > li > ul > li > a").each(function() {
					var $t = $(this);
					if ($t.next().hasClass('sub-menu') || $t.next().is('ul') || $t.next().is('.sf-mega')) {
						$t.append('<span class="fa fa-angle-down mobile-menu-submenu-arrow mobile-menu-submenu-closed"></span>');
					}
				});
			
				$(".mobile-menu-submenu-arrow").click(function(event) {
					var $t = $(this);
					if ($t.hasClass("mobile-menu-submenu-closed")) {
						$t.parent().siblings("ul").slideDown(300);
						$t.parent().siblings(".sf-mega").slideDown(300);
						$t.removeClass("mobile-menu-submenu-closed fa-angle-down").addClass("mobile-menu-submenu-opened fa-angle-up");
					} else {
						$t.parent().siblings("ul").slideUp(300);
						$t.parent().siblings(".sf-mega").slideUp(300);
						$t.removeClass("mobile-menu-submenu-opened fa-angle-up").addClass("mobile-menu-submenu-closed fa-angle-down");
					}
					event.preventDefault();
				});
				
				$("#mobile-menu li, #mobile-menu li a, #mobile-menu ul").attr("style", "");
				
			}
			
		}

	}

/* ==========================================================================
   showHideMobileMenu
   ========================================================================== */

	function showHideMobileMenu() {
		
		$("#mobile-menu-trigger").click(function(event) {
			
			var $t = $(this);
			var $n = $("#mobile-menu");
			
			if ($t.hasClass("mobile-menu-opened")) {
				$t.removeClass("mobile-menu-opened").addClass("mobile-menu-closed");
				$n.slideUp(300);
			} else {
				$t.removeClass("mobile-menu-closed").addClass("mobile-menu-opened");
				$n.slideDown(300);
			}
			event.preventDefault();
			
		});
		
	}
/* ==========================================================================
  topMenu 
 ========================================================================== */		
		function MainMenu() {
		   //topmenu for top-bar navigation
		    topmenu.init({
		        mainmenuid: "top-nav-id", //menu DIV id
		        orientation: 'h', //Horizontal or vertical menu: Set to "h" or "v"
		        classname: 'top-nav cocaMenu', //class added to menu's outer DIV
		        contentsource: "markup" //"markup" or ["container_id", "path_to_menu_file"]
		    });
		    //topmenu for top navigation
		    topmenu.init({
		        mainmenuid: "top-nav-id", //menu DIV id
		        orientation: 'h', //Horizontal or vertical menu: Set to "h" or "v"
		        classname: 'top-nav cocaMenu', //class added to menu's outer DIV
		        contentsource: "markup" //"markup" or ["container_id", "path_to_menu_file"]
			});

		    // top Navigation for mobile.
		    var top_nav_mobile_button = jQuery('#top-nav-mobile');
		    var top_nav_cloned;
		    var top_nav = jQuery('#top-nav-id > ul');

		    top_nav.clone().attr('id','top-nav-mobile-id').removeClass().appendTo( top_nav_mobile_button );
		    top_nav_cloned = top_nav_mobile_button.find('> ul');
		        jQuery('#top-nav-mobile-a').click(function(){
		            if(jQuery(this).hasClass('top-nav-close')){
		                jQuery(this).removeClass('top-nav-close').addClass('top-nav-opened');
		                top_nav_cloned.slideDown( 400 );
		            } else {
		                jQuery(this).removeClass('top-nav-opened').addClass('top-nav-close');
		                top_nav_cloned.slideUp( 400 );
		            }
		            return false;
		        });
		        top_nav_mobile_button.find('a').click(function(event){
		            event.stopPropagation();
		        });
		}
		function init($contex) {
			jQuery(".content-wrapper").fitVids();
			Carousel();
			flexslider();
			accordion();
			tabs();
			progress();
			animated();
			popup();
			contact();
			handleMobileMenu();
			showHideMobileMenu(); 			
			MainMenu(); 
			if(typeof $.fn.superfish != 'undefined'){		
				jQuery('#menu').superfish({
					delay: 500,
					animation: {opacity:'show',height:'show'},
					speed: 100,
					cssArrows: true
				});	
			}
/* ==========================================================================
   When the window is resized, do
   ========================================================================== */
   
	jQuery(window).resize(function() {
		handleMobileMenu();		 		
	});
        }
    } /* END Class */

})(jQuery);

jQuery(document).ready(function() {
    jQuery('body').ccTheme();
});
    