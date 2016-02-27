  //AIzaSyBFYuBamowB61VK52rGFqB6PZXrz9dnirs
  $(document).ready(function () {  
     initialize();  
   });  
   function initialize() {  
     var mapOptions = {  
       center: new google.maps.LatLng(6.9167, 79.8473),  
       zoom: 10,  
       mapTypeId: google.maps.MapTypeId.ROADMAP  
     };  
     var map = new google.maps.Map(document.getElementById("map_canvas"),  
       mapOptions);  
     // create a marker  
     var latlng = new google.maps.LatLng(6.9167, 79.8473);  
     var marker = new google.maps.Marker({  
       position: latlng,  
       map: map,  
       title: 'My Place'  
     });  
   }
   var geocoder;
   var map;
   function codeAddress(address) {
       geocoder = new google.maps.Geocoder();
       geocoder.geocode({ 'address': address }, function (results, status) {
           if (status == google.maps.GeocoderStatus.OK) {
               var myOptions = {
                   zoom: 17,
                   center: results[0].geometry.location,
                   mapTypeId: google.maps.MapTypeId.ROADMAP
               }
               map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);
               var marker = new google.maps.Marker({
                   map: map,
                   position: results[0].geometry.location
               });
               // create a marker  
               var marker = new google.maps.Marker({
                   position: results[0].geometry.location,
                   map: map,
                   title: 'Latitude: ' + results[0].geometry.location.Ya + ' Longitude :' + results[0].geometry.location.Za
               });
           }
       });
   }