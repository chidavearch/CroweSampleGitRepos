$(document).ready(function () {
    $.ajax({
        url: "http://rest-service.guides.spring.io/greeting"
    }).then(function (data) {
        $('.greeting-content').append(data.content);
    });
});

