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

function disminuir(c, p, t, ca, idP, idU, asc) {
    inicio = document.getElementById(c).value;
    if (inicio > 1) {
        var cantidad = document.getElementById(c).value = --inicio;
        document.getElementById(ca).value = cantidad;
        var precio = document.getElementById(p).value;
        var total = cantidad * precio;
        document.getElementById(t).value = total;
        var subtotalTemp = document.getElementById("subtotal").value;

        var subtotal = parseInt(subtotalTemp) - parseInt(precio);
        document.getElementById("subtotal").value = subtotal;

        var parametros = {
            "idP": idP, "idU": idU, "cant": asc
        };

        $.ajax(
            {
                data: parametros,
                url: '/Cliente/UpdateCarrito',
                type: 'post',
                beforeSend: function () {
                    $("#mensaje").html("Procesando, \n\ espere por favor...");
                },
                success: function (response) {

                }
            }
        );
    }
}

function aumentar(c, p, t, ca, s, idP, idU, asc) {
    cantStock = document.getElementById(s).value;
    inicio = document.getElementById(c).value;
    var cantidad = document.getElementById(c).value = ++inicio;
    if (cantidad <= cantStock) {
        document.getElementById(ca).value = cantidad;
        var precio = document.getElementById(p).value;
        var total = cantidad * precio;
        document.getElementById(t).value = total;
        var subtotalTemp = document.getElementById("subtotal").value;

        var subtotal = parseInt(subtotalTemp) + parseInt(precio);
        document.getElementById("subtotal").value = subtotal;

        var parametros = {
            "idP": idP, "idU": idU, "cant": asc
        };

        $.ajax(
            {
                data: parametros,
                url: '/Cliente/UpdateCarrito',
                type: 'post',
                beforeSend: function () {
                    $("#mensaje").html("Procesando, \n\ espere por favor...");
                },
                success: function (response) {

                }
            }
        );
    } else if (cantidad > cantStock) {
        alert("La cantidad deseada no está disponible");
        document.getElementById(c).value = --inicio
    }
}

function EliminarCarrito(idP, idU, idF, idT) {
    var parametros = {
        "idP": idP, "idU": idU
    };

    $.ajax(
        {
            data: parametros,
            url: '/Cliente/EliminarCarrito',
            type: 'post',
            success: function (response) {
                alert("Articulo eliminado");
                $("#" + idF).remove();

                var subtotalTemp = document.getElementById("subtotal").value;
                var subtotal = parseFloat(subtotalTemp) - parseFloat(idT);
                document.getElementById("subtotal").value = subtotal;
            }
        }
    );
}