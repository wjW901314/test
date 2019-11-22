function GetData() {
    $.ajax({
        url: "http://10.158.4.237:8085/WebService.svc/ConnectTest",
        type: "GET",
        dataType: "Json",
        contentType: "application/json",
        //data: '{"value","123"}',
        timeout: 1000,
        error: function () {
            alert("error");
        },
        success: function (result) {
            Console.log(result);
            alert(result);
        }
    });
}