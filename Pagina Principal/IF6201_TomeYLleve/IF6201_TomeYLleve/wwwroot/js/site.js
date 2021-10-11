function AgregarCarrito(idP, idU, cant) {
    var parametros = {
        "idP": idP, "idU": idU, "cant": cant
    };

    $.ajax(
        {
            data: parametros,
            url: '/Cliente/AgregarCarrito',
            type: 'post',
            beforeSend: function () {     
                $("#resultado").html("Procesando")
            },
            success: function (response) {
                $("#resultado").html(response)
            }
        }
    );
}

function disminuir(c,p,t,ca) {
    inicio = document.getElementById(c).value;
    if (inicio > 1) {
        var cantidad = document.getElementById(c).value = --inicio;
        document.getElementById(ca).value = cantidad;
        var precio = document.getElementById(p).value;
        var total = cantidad * precio;
        document.getElementById(t).value = total;
    }
}

function aumentar(c, p, t, ca,s) {
    cantStock = document.getElementById(s).value;
    inicio = document.getElementById(c).value;
    var cantidad = document.getElementById(c).value = ++inicio;
    if (cantidad <= cantStock) {
        document.getElementById(ca).value = cantidad;
        var precio = document.getElementById(p).value;
        var total = cantidad * precio;
        document.getElementById(t).value = total;
    } else if (cantidad > cantStock) {
        alert("La cantidad deseada no está disponible");
        document.getElementById(c).value = --inicio
    }
}