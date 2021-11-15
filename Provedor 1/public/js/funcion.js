//
function enviar(marca, nombreP, descripcion, precio, dimension, otras, foto, cantidad, categoria) {

    //alert(JSON.stringify(producto));
    var url = "http://apitomeylleve-001-site1.etempurl.com/api/Productos/Registro";
    var request = new XMLHttpRequest();

    request.open("POST", url);
//    request.setRequestHeader("Content-Type", "application/json");
    request.onreadystatechange = function () {
        if (request.readyState === 4 && request.status==200) {
            console.log(request.status);
            console.log(request.responseText);
        }
    };
    var producto = {"id": 0, "nombre": nombreP, "marca": marca, "descripcion": descripcion, "precio": precio, "dimensiones": dimension, "otrasCaracteristicas": otras, "foto": foto, "categoria": categoria, "idProveedor": 1, "cantidad": cantidad};
    request.send(JSON.stringify(producto));
}

//function enviar(marca, nombreP, descripcion, precio, dimension, otras, foto, cantidad, categoria) {
//    var producto = {"id": 0, "nombre": nombreP, "marca": marca, "descripcion": descripcion, "precio": precio, "dimensiones": dimension, "otrasCaracteristicas": otras, "foto": foto, "categoria": categoria, "idProveedor": 1, "cantidad": cantidad};
//    alert(JSON.stringify(producto));
//    $.ajax(
//            {
//                url: 'http://apitomeylleve-001-site1.etempurl.com/api/Productos/Registro/',
//                type: 'post',
//                data: JSON.stringify(producto),
//                contentType: false,
//                cache: false,
//                processData: false,
//                dataType: 'json',
//                beforeSend: function () {
////                    $("#resultado").html("Procesando, espere");
//                },
//                success: function (response) {
////                    $("#resultado").html(response);
//                    console.log(response);
//                    alert(response);
//                }
//            }
//    );
//
//}//registrarProductoAjax
