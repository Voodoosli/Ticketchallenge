var tableTimeout;
$(function () {
    getBusLocations();


    $('#dpdate').datepicker({
        format: 'dd-mm-yyyy',
        startDate: '0d'
    });

});
$("#fdropdownSearch").on("keyup", function () {
    var parent = $(this).parent().parent();
    var searchText = $(this).val();
    window.clearTimeout(tableTimeout);
    tableTimeout = window.setTimeout(function () {
         
        parent.find('li').not(':first').remove();
        getBusLocations(searchText, parent);
    }, 1000);
});
$("#tdropdownSearch").on("keyup", function () {
    var parent = $(this).parent().parent();
    var searchText = $(this).val();
    window.clearTimeout(tableTimeout);
    tableTimeout = window.setTimeout(function () {
        
        parent.find('li').not(':first').remove();
        getBusLocations(searchText, parent);
    }, 1000);
});
$('.dropdown-menu').on('click', 'li', function (event) {

    var buttonElement = $(this).parent().parent().find('button');
    var spantext = $(this).children('a').children('span').text();;
    var newValue = $(this).data('id');

    buttonElement.children('span').text(spantext);
    buttonElement.attr('value', newValue);


});
$('.todatbtn').click(function () {
    var today = new Date();
    var tomorrow = new Date(today);
    tomorrow.setDate(today.getDate() + 1);


    var formattedToday = ("0" + today.getDate()).slice(-2) + '-'
        + ("0" + (today.getMonth() + 1)).slice(-2) + '-'
        + today.getFullYear();


    $('#dpdate').datepicker('setDates', [formattedToday]);
});

$('.tomorrowbtn').click(function () {
    var today = new Date();
    var tomorrow = new Date(today);
    tomorrow.setDate(today.getDate() + 1);

    var formattedTomorrow = ("0" + tomorrow.getDate()).slice(-2) + '-'
        + ("0" + (tomorrow.getMonth() + 1)).slice(-2) + '-'
        + tomorrow.getFullYear();


    $('#dpdate').datepicker('setDates', [formattedTomorrow]);
});

function NavigateToJourney() {
    var origin = $('#dd_fromwhere').attr('value');
    var destination = $('#dd_towhere').attr('value');
    var date = $('#dpdate').val();
    if (typeof origin === 'undefined' || typeof destination === 'undefined' || typeof date === 'undefined') {
        alert("lütfen formu eksiksiz doldurunuz")
    }
    else {
        window.location.href = '/journey?originid=' + origin + '&destinationid=' + destination + '&date=' + date;
    } 
}



function getBusLocations(data, parent) {
    var url;
    if (typeof data === "undefined") {
        url = "/Home/BusLocations";
    }
    else {
        url = "/Home/BusLocations?data=" + data ;
    }


    $.ajax({
        url: url,
        type: 'GET',
        data: "",
        success: function (result) {
            if (typeof parent === "undefined") {
                var ul = $(".dropdown-menu ");
                $.each(result, function (index, jdata) {
                    ul.append(' <li class="dropdownli" data-id="' + jdata.id + '"><a class="dropdown-item"  href="#"><i></i><span class="dropdown-item-label">' + jdata.name + '</span></a></li>');
                });
            }
            else {
                
                $.each(result, function (index, jdata) {
                    $(parent).append(' <li class="dropdownli" data-id="' + jdata.id + '"><a class="dropdown-item"  href="#"><i></i><span class="dropdown-item-label">' + jdata.name + '</span></a></li>');
                });
            }
          
        },
        error: function (err) {// alertThis('warning', null, err.responseText);
        }
    });
}
function setLocationCookie(origin, destination, date) {
    var originparts = origin.split('-');
    var destinationparts = destination.split('-'); 
    $('#dd_fromwhere').attr('value', originparts[0]);
    $('#fromwhere').text(originparts[1]);
    $('#dd_towhere').attr('value', destinationparts[0]);
    $('#towhere').text(destinationparts[1]);
    $('#dpdate').val(date);
}

function setLocationDefault() {

    var origin = $('.dropdownfromwhere li:nth-child(2)');
    var destination = $('.dropdowntowhere li:nth-child(3)');

     
    var originid = origin.data('id')
    var destinationid = destination.data('id')

    $('#dd_fromwhere').attr('value', originid);
    $('#fromwhere').text(origin.children('a').text());

    $('#dd_towhere').attr('value', destinationid);
    $('#towhere').text(destination.children('a').text()); 

    var today = new Date(); 

    var formattedToday = ("0" + today.getDate()).slice(-2) + '-'
        + ("0" + (today.getMonth() + 1)).slice(-2) + '-'
        + today.getFullYear();


    $('#dpdate').datepicker('setDates', [formattedToday]);
     
     
}



function setLocationSwap() {

    var originid = $('#dd_fromwhere').attr('value');
    var destinationid = $('#dd_towhere').attr('value');
    var origin = $('#fromwhere').text();
    var destination = $('#towhere').text();


    var swap = $(".fa-right-left").data("changed");

   
        $('#dd_fromwhere').attr('value', destinationid);
        $('#fromwhere').text(destination );

        $('#dd_towhere').attr('value', originid);
        $('#towhere').text(origin) ;
        
   
    
}