!function(){var a=$("#main");a.on("mouseenter",function(){a.style="background: #888"}),a.on("mouseleave",function(){a.style=""});var e=$("#sidebar,#wrapper"),s=$("#sidebarToggle i.fa");$("#sidebarToggle").on("click",function(){e.toggleClass("hide-sidebar"),e.hasClass("hide-sidebar")?(s.removeClass("fa-angle-left"),s.addClass("fa-angle-right")):(s.addClass("fa-angle-left"),s.removeClass("fa-angle-right"))})}();