function menu_hover(li,check_child){
    if(typeof(check_child)=='undefined'  || check_child== false){
        check_child = false;
    }else{
        check_child = true;
    }
    
     var color = li.attr('color');
      if(typeof(color)!='undefined' && color!=''){
        li.css({'background':'#'+color});
        jQuery('>a',li).css({'background':'#'+color});
        jQuery('ul',li).css({'background':'#'+color});
        if(check_child){
             jQuery('ul li',li).hover(function(){
                 menu_hover(jQuery(this));
             },function(){
                 menu_hover_out(jQuery(this));
             });
        }
      }
}

function menu_hover_out(li){
     var color = li.attr('color');
      if(typeof(color)!='undefined' && color!='' && (li.hasClass('current-menu-item') || li.hasClass('current-menu-parent'))){
            li.css({'background':'#'+color});
            jQuery('>a',li).css({'background':'#'+color});
            jQuery('ul',li).css({'background':'#'+color+' !important'});
      }else{
             li.css({'background':''});
            jQuery('>a',li).css({'background':''});
            jQuery('ul',li).css({'background':''});
      }
}

var topmenu={
arrowimages: {down:['subDown', 'down.gif', 'hasSubMenu'], right:['subRight', 'right.gif']},
transition: {overtime:300, outtime:300}, 
shadow: {enable:false, offsetx:5, offsety:5}, 
showhidedelay: {showdelay: 100, hidedelay: 200}, 

detectwebkit: navigator.userAgent.toLowerCase().indexOf("applewebkit")!=-1, 
detectie6: document.all && !window.XMLHttpRequest,
css3support: window.msPerformance || (!document.all && document.querySelector), 
getajaxmenu:function($, setting){ 
	var $menucontainer=$('#'+setting.contentsource[0]) 
	$menucontainer.html("Loading Menu...")
	$.ajax({
		url: setting.contentsource[1], 
		error:function(ajaxrequest){
			$menucontainer.html('Error fetching content. Server Response: '+ajaxrequest.responseText)
		},
		success:function(content){
			$menucontainer.html(content)
			topmenu.buildmenu($, setting)
		}
	})
},


buildmenu:function($, setting){
	var top_menu=topmenu;
	var $mainmenu=$("#"+setting.mainmenuid+">ul"); 
    try{
        $mainmenu.parent().get(0).className=setting.classname || "topmenu";
    }catch(e){
    }
	
    
	var $headers=$mainmenu.find("ul").parent();
	$headers.hover(
		function(e){
			$(this).children('a:eq(0)').addClass('hover').parent('li').addClass('li_hover');
            var li = $(this).children('a:eq(0)').parent('li');
            menu_hover(li);
		},
		function(e){
			$(this).children('a:eq(0)').removeClass('hover').parent('li').removeClass('li_hover');  
            var li = $(this).children('a:eq(0)').parent('li');
            menu_hover_out(li);
		}
	)
    
    $("#"+setting.mainmenuid+">ul>li").hover(
		function(e){
			$(this).children('a:eq(0)').addClass('hover').parent('li').addClass('li_hover');
            /// add new for color
            menu_hover($(this));
		},
		function(e){
			$(this).children('a:eq(0)').removeClass('hover').parent('li').removeClass('li_hover');
             /// add new for color
              menu_hover_out($(this));
            
		}
	)
    
    
    
	$headers.each(function(i){ 
		var $curobj=$(this).css({zIndex: 300-i}) 
		var $subul=$(this).find('ul:eq(0)').css({display:'block'})
		$subul.data('timers', {})
		this._dimensions={w:this.offsetWidth, h:this.offsetHeight, subulw:$subul.outerWidth(), subulh:$subul.outerHeight()}
		this.istopheader=$curobj.parents("ul").length==1? true : false 
		$subul.css({top:this.istopheader && setting.orientation!='v'? this._dimensions.h+"px" : 0})
		$curobj.children("a:eq(0)").addClass(this.istopheader ? top_menu.arrowimages.down[2] : {}).append(
			'<span class="' + (this.istopheader && setting.orientation!='v'? top_menu.arrowimages.down[0] : top_menu.arrowimages.right[0]) + '"></span>'
		)
		if (top_menu.shadow.enable && !top_menu.css3support){ 
			this._shadowoffset={x:(this.istopheader?$subul.offset().left+top_menu.shadow.offsetx : this._dimensions.w), y:(this.istopheader? $subul.offset().top+top_menu.shadow.offsety : $curobj.position().top)} 
			if (this.istopheader)
				$parentshadow=$(document.body)
			else{
				var $parentLi=$curobj.parents("li:eq(0)")
				$parentshadow=$parentLi.get(0).$shadow
			}
			this.$shadow=$('<div class="ddshadow'+(this.istopheader? ' toplevelshadow' : '')+'"></div>').prependTo($parentshadow).css({left:this._shadowoffset.x+'px', top:this._shadowoffset.y+'px'})  
		}
		$curobj.hover(
			function(e){
				var $targetul=$subul 
				var header=$curobj.get(0) 
				clearTimeout($targetul.data('timers').hidetimer)
				$targetul.data('timers').showtimer=setTimeout(function(){
					header._offsets={left:$curobj.offset().left, top:$curobj.offset().top}
					var menuleft=header.istopheader && setting.orientation!='v'? 0 : header._dimensions.w
					menuleft=(header._offsets.left+menuleft+header._dimensions.subulw>$(window).width())? (header.istopheader && setting.orientation!='v'? -header._dimensions.subulw+header._dimensions.w : -header._dimensions.w) : menuleft 
					if ($targetul.queue().length<=1){ 
						$targetul.css({left:menuleft+"px", width:header._dimensions.subulw+'px'}).animate({height:'show',opacity:'show'}, topmenu.transition.overtime)
						if (top_menu.shadow.enable && !top_menu.css3support){
							var shadowleft=header.istopheader? $targetul.offset().left+topmenu.shadow.offsetx : menuleft
							var shadowtop=header.istopheader?$targetul.offset().top+top_menu.shadow.offsety : header._shadowoffset.y
							if (!header.istopheader && topmenu.detectwebkit){ 
								header.$shadow.css({opacity:1})
							}
							header.$shadow.css({overflow:'', width:header._dimensions.subulw+'px', left:shadowleft+'px', top:shadowtop+'px'}).animate({height:header._dimensions.subulh+'px'}, topmenu.transition.overtime)
						}
					}
				}, topmenu.showhidedelay.showdelay);
                
                /// add new for color
                 menu_hover($curobj,true);

			},
			function(e){
				var $targetul=$subul
				var header=$curobj.get(0)
				clearTimeout($targetul.data('timers').showtimer)
				$targetul.data('timers').hidetimer=setTimeout(function(){
					$targetul.animate({height:'hide', opacity:'hide'}, topmenu.transition.outtime)
					if (top_menu.shadow.enable && !top_menu.css3support){
						if (topmenu.detectwebkit){ 
							header.$shadow.children('div:eq(0)').css({opacity:0})
						}
						header.$shadow.css({overflow:'hidden'}).animate({height:0}, topmenu.transition.outtime)
					}
				}, topmenu.showhidedelay.hidedelay);
                
                /// add new for color
              menu_hover_out($curobj, true);
                

			}
		) 
	}) 
	if (top_menu.shadow.enable && top_menu.css3support){ 
		var $toplevelul=$('#'+setting.mainmenuid+' ul li ul')
		var css3shadow=parseInt(top_menu.shadow.offsetx)+"px "+parseInt(top_menu.shadow.offsety)+"px 5px #aaa" 
		var shadowprop=["boxShadow", "MozBoxShadow", "WebkitBoxShadow", "MsBoxShadow"] 
		for (var i=0; i<shadowprop.length; i++){
			$toplevelul.css(shadowprop[i], css3shadow)
		}
	}
	$mainmenu.find("ul").css({display:'none', visibility:'visible'})
},

init:function(setting){
	if (typeof setting.customtheme=="object" && setting.customtheme.length==2){ 
		var mainmenuid='#'+setting.mainmenuid
		var mainselector=(setting.orientation=="v")? mainmenuid : mainmenuid+', '+mainmenuid
		document.write('<style type="text/css">\n'
			+mainselector+' ul li a {background:'+setting.customtheme[0]+';}\n'
			+mainmenuid+' ul li a:hover {background:'+setting.customtheme[1]+';}\n'
		+'</style>')
	}
	this.shadow.enable=(document.all && !window.XMLHttpRequest)? false : this.shadow.enable 
	jQuery(document).ready(function($){ 
		if (typeof setting.contentsource=="object"){ 
			topmenu.getajaxmenu($, setting)
		}
		else{ 
			topmenu.buildmenu($, setting)
		}
	})
}

} //end topmenu variable
