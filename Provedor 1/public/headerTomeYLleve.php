<?php header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: GET,HEAD,OPTIONS,POST,PUT");
header("Access-Control-Allow-Headers: Origin, X-Requested-With, Content-Type, Accept, Authorization");?>
<html lang="es">
    <head>
        <title>Caite</title>
        <meta charset="utf-8"/>
        <meta name="description" content="VicProdux de limpieza y proteción" />
        <meta name="viewport" content="width=device-width, initial-scale=1"/>
        <link rel="stylesheet" type="text/css" href="public/css/bootstrapssss.css"/>
        <script type="text/javascript" src="public/js/bootstrap.js"></script>
        <script type="text/javascript" src="public/js/jquery.js"></script>
        <script type="text/javascript" src="public/js/jquery-3.2.1.js"></script>
        <script type="text/javascript" src="public/js/jquery-ui.js"></script>

        <link rel="shortcut icon" type="image/x-icon" href="public/img/icon.ico"/>     

        <script type="text/javascript" src="public/js/funcion.js"></script>

    </script>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="container-fluid">

            <a class="navbar-brand" href="?controlador=Producto&accion=inicio"">Caite</a>

            <button
                class="navbar-toggler"
                type="button"
                data-bs-toggle="collapse"
                data-bs-target="#navbarSupportedContent"
                aria-controls="navbarSupportedContent"
                aria-expanded="false"
                aria-label="Toggle navigation"
                >
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                     <li class="nav-item">
                            <a class="nav-link" href="?controlador=Producto&accion=cerrarSesion"><span class="glyphicon glyphicon-log-in"></span> Cerrar Sesion</a>
                        </li>
                     </ul>
            </div>
        </div>
    </nav>
    <div class="container"style="margin-top:50px; margin-bottom:100px;">

