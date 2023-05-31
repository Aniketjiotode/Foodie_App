// const cityUrl = "https://zomatoajulypi.herokuapp.com/location"
// const restUrl = "https://zomatoajulypi.herokuapp.com/restaurant?stateId="

// function getcity(){
//      fetch(cityurl,{method:'GET'})
//     .then((res)=> res.json())
//     .then ((data)=> {
//         data.map((item)=> {
//             let element = document.createElement ('option')
//             let text = document.createTextNode(item.state)
//             element.appendChild(text)
//             element.value = item.state_id
//             document.getElementById('city').appendchild(element)
//         })
//     })
// }


// function getRest(){
//     let cityId = document.getElementById('city').value;
//     let rest  =document.getElementById('restselect').value;
//     while (rest.length >0){
//         rest.remove(0)
//     }
//     fetch( `${resturl}${cityId}`,{method:'GET'})
//    .then((res)=> res.json())
//    .then ((data)=> {
//        data.map((item)=> {
//            let element = document.createElement ('option')
//            let text = document.createTextNode(item.restaurant_name)
//            element.appendChild(text)
//            rest.appendchild(element)
//        })
//    })
// }

$(document).ready(function () {
    $("#myBtn").click(function () {
        $("#myModal").modal();
    });
});
$(document).ready(function () {
    $("#myBtns").click(function () {
        $("#myModals").modal();
    });
});

$("#Adduser").click(function () {
    var objdata = $('#userdetails').serialize()
    $.ajax({
        url: "/User/SignupPage",
        data: objdata,
        type: "POST",
        contentType: "application/x-www-form-urlencoded;charset=utf-8",
        dataType: "json",
        success: function () {
            alert("SignUp Successfully")
        },
        error: function () {
            alert("Unable to Signup");
        }
    })
})

//var objdata = {
//    FirstName: $('#FirstN').val(),
//    LastName: $('#LastN').val(),
//    EmailId: $('#Email').val(),
//    Password: $('#Password').val(),
//    MobileNo: $('#Mobile').val()
//};

$("#Loginuser").click(function () {
    var objdata = $('#Logindetails').serialize()
    $.ajax({
        url: "/User/Login",
        data: objdata,
        type: "POST",
        contentType: "application/x-www-form-urlencoded;charset=utf-8",
        dataType: "json",
        success: function () {
            alert("Login Successfully");
     
        },
        error: function () {
            alert("Something is invalid please try again with coreect EmailId And Password");
        }
    })
})


    $("#showall").click(function (e) {
        e.preventDefault();
        $.ajax({
            url: "/Restaurant/Showallrestaurant",
            data: {},
            type: "GET",
            contentType: "application/x-www-form-urlencoded;charset=utf-8",
            dataType: "json",
            success: function () {
            },
            error: function () {
            }
        })
    });



$(document).ready(function () {
    $("select.Citys").change(function () {
        var $option = $(this).find('option:selected');
        var cityname = $option.text();//to get <option>Text</option> content
        $.ajax({
            url: `/Restaurant/City`,
            data: {cityname:cityname},
            type: "POST",
            contentType: "application/x-www-form-urlencoded;charset=utf-8",
            dataType: "json",
            success: function () {
              
            },
            error: function () {
                alert("Something is invalid please try again with coreect EmailId And Password");
            }
        })      
        alert("You have selected the country - " + selectedCountry);
    });
});  



$(".searechbarbtn").click(function () {
        var cityname = $(".cityname").val();
        var restaurant = $(".restName").val();          
        $.ajax({
            url: `/Restaurant/GetRestautrantbyName`,
            data: { city: cityname,name:restaurant },
            type: "get",
            contentType: "application/x-www-form-urlencoded;charset=utf-8",
            dataType: "json",
  
        }) 
});  

$(".searchrest").click(function (e) {
    var restaurant = $(".searchinput").val();
    e.preventDefault()
    $.ajax({
        url: `/Restaurant/GetRestautrantbyName`,
        data: { city:null, name: restaurant },
        type: "get",
        contentType: "application/x-www-form-urlencoded;charset=utf-8",
        dataType: "json",

    })
});  

  $(document).ready(function () {
        $(".txtname").autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: '/Restaurant/Getallcity',
                    data: {prefix:request.term},
                    dataType: "json",
                    type: "POST",
                    contentType: "application/x-www-form-urlencoded;charset=utf-8",
                    success: function (data) {
                        response($.map(data, function (item) {
                            return item;
                        }));
                    },
                    error: function (response) {
                        alert(response.responseText);
                    },
                    failure: function (response) {
                        alert(response.responseText);
                    }
                });
            },
            select: function (e, i) {
                $('.txtnames').val(i.item.CityName)
            },
            minLength: 1
        });
  });

//$(document).ready(function () {
//    $('.txtname').autocomplete({
//        source: '@Url.Action("Getallcity","Restaurant")'
//    });
//});

//$(document).ready(function () {
//    (".categorys").each(function () {
//        $(this).on("click", function () {

//            var objdata = $('#categoryid').text()
//            $.ajax({
//                url: `/Resaturant/Listing/${objdata}`,
//                data: objdata,
//                type: "POST",
//                contentType: "application/x-www-form-urlencoded;charset=utf-8",
//                dataType: "json",
//                //success: function () {
//                //    alert("Login Successfully");
//                //    window.location.href = "http://localhost:29070/User/LoginHomePage"
//                //},
//                //error: function () {
//                //    alert("Something is invalid please try again with coreect EmailId And Password");
//                //}
//            })
//        })

//    })
//});



