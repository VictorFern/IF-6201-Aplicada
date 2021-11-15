
function enviar(id) {
    var formData = new FormData(document.getElementById(id));
    alert(JSON.stringify(formData));
    var xhr = new XMLHttpRequest();
    xhr.open("POST", "http://apitomeylleve-001-site1.etempurl.com/api/Productos/Registro",true);
      if (xhr.readyState === 4 && xhr.status === 200) {
            var serverresponse = JSON.parse(xhr.responseText);
            console.log(serverresponse);
        }
    xhr.send(JSON.stringify(formData));
    //alert(JSON.stringify(producto));
//    var url = "http://apitomeylleve-001-site1.etempurl.com/api/Productos/Registro";
//    var request = new XMLHttpRequest();

//    request.open("POST", url);
////    request.setRequestHeader("Content-Type", "application/json");
//    request.onreadystatechange = function () {
//        if (request.readyState === 4 && request.status == 200) {
//            console.log(request.status);
//            console.log(request.responseText);
//        }
//    };
//    var producto = {"id": 0, "nombre": nombreP, "marca": marca, "descripcion": descripcion, "precio": precio, "dimensiones": dimension, "otrasCaracteristicas": otras, "foto": foto, "categoria": categoria, "idProveedor": 1, "cantidad": cantidad};
//    request.send(JSON.stringify(producto));
}

function enviar2(marca, nombreP, descripcion, precio, dimension, otras, foto, cantidad, categoria) {
    var producto = {"id": 0, "nombre": nombreP, "marca": marca, "descripcion": descripcion, "precio": precio, "dimensiones": dimension, "otrasCaracteristicas": otras, "foto": foto, "categoria": categoria, "idProveedor": 1, "cantidad": cantidad};
    alert(JSON.stringify(producto));
    $.ajax(
            {
                url: 'http://apitomeylleve-001-site1.etempurl.com/api/Productos/Registro/',
                type: 'post',
                data: JSON.stringify(producto),
                contentType: false,
                cache: false,
                processData: false,
                dataType: 'json',
                beforeSend: function () {
//                    $("#resultado").html("Procesando, espere");
                },
                success: function (response) {
//                    $("#resultado").html(response);
                    console.log(response);
                    alert(response);
                }
            }
    );

}//registrarProductoAjax
