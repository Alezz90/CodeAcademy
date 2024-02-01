//let title = $("#imageIcon");
//console.log(title);
/*
$("#imageIcon").toggle();
$("#imageIcon").Hide();
$("#imageIcon").toggle();

*/
//$("#imageIcon").css({display:"none"});
$("#buttton").click(function(){  
 
        // alert("Text: " + $("#test").text());



        $("#test1").append(" <b>Welcom</b>.");
        $("#test1").after("<i>After</i>");

        $("div").addClass("container");
        $("#buttton").css({"background-color": "yellow", "font-size": "200%"});
       /* $("#test1").text("Hello world!");
        $("#test2").html("<b>Hello world!</b>");
        $("#test3").val("enter your name");
        $("#test4").attr({
            "href" : "https://www.w3schools.com/jquery/",
            "title" : "learn more"
          });

         //alert("Value: " + $("#test").val());
         //alert($("#test").attr("href"));




   // $("#imageIcon").css("color", "red").slideUp(2000).slideDown(2000);
    
    /*$("#imageIcon").animate({
        left: '250px',
        opacity: '0.5',
        height: '150px',
        width: '150px'
      });*/


   // $("#imageIcon").slideDown("slow");
   // $("#imageIcon").fadeToggle("slow");
   // $("#imageIcon").fadeToggle(3000);

  });  