<!DOCTYPE html>
<html lang="es">
    <head>
        <title>Caite</title>
        <meta charset="utf-8"/>
        <meta name="description" content="VicProdux de limpieza y proteción" />
        <meta name="viewport" content="width=device-width, initial-scale=1"/>
        <link rel="stylesheet" type="text/css" href="public/css/actualFinal1.css"/>
        <script type="text/javascript" src="public/js/bootstrap.js"></script>
        <script type="text/javascript" src="public/js/jquery.js"></script>
        <script type="text/javascript" src="public/js/jquery-3.2.1.js"></script>
        <script type="text/javascript" src="public/js/jquery-ui.js"></script>

        <link rel="shortcut icon" type="image/x-icon" href="public/img/icon.ico"/>     
        <script type="text/javascript" src="public/js/manipularcanvas.js"></script>

    </script>
</head>
<body>
    <div id="top-header">
        <div class="container">
            <ul class="header-links pull-left">
                <li><a href="#"><i class="fa fa-phone"></i> +506-25100101</a></li>
                <li><a href="#"><i class="fa fa-envelope-o"></i> caitecaite7@gmail.com</a></li>
                <li><a href="#"><i class="fa fa-map-marker"></i> Turrialba,Cartago,Costa Rica</a></li>
            </ul>

        </div>
    </div>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div   class="container-fluid container-xl d-flex align-items-center justify-content-lg-between">

            <a class="navbar-brand" href="?controlador=Producto&accion=inicio"> <img  src="public/img/caiteFinal.png" alt="Responsive image"></a>

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
                        <a class="nav-link active" aria-current="page" href="?controlador=Producto&accion=inicio">Inicio</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="?controlador=Producto&accion=registrar">Nuevo Producto</a>
                    </li>
                    <li class="nav-item">

                        <a class="nav-link" href="?controlador=Producto&accion=actualiza">Actualizar Producto</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="?controlador=Producto&accion=eliminar">Eliminar Producto</a>
                    </li>

                    <form class="d-flex" name="buscar" action="?controlador=Producto&accion=buscarProducto" method="post">
                        <input
                            class="form-control me-2"
                            type="search"
                            placeholder="Buscar producto"
                            aria-label="Search"

                            id="Nombre" name="Nombre"

                            />
                        <button class="btn primary-btn" type="submit" style="background-color: #ff1414;border-color: black">
                            Buscar
                        </button>
                    </form>
                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li class="nav-item">
                        <a class="nav-link" style="color: #088d1c "  href="?controlador=Producto&accion=login"><span class="glyphicon glyphicon-log-in"></span> Tome&Lleve</a>
                    </li>
                </ul>

            </div>
        </div>
    </nav>
    <div class="container"style="margin-top:50px; margin-bottom:100px;">



