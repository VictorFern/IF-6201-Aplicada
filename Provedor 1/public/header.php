<!DOCTYPE html>
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
        <script type="text/javascript" src="public/js/manipularcanvas.js"></script>

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
                        <a class="nav-link active" aria-current="page" href="?controlador=Producto&accion=inicio">Inicio</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="?controlador=Producto&accion=registrar">Nuevo Producto</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Actualizar Producto</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Eliminar Producto</a>
                    </li>
                    <form class="d-flex" name="buscar" action="?controlador=Producto&accion=buscarProducto" method="post">
                        <input
                            class="form-control me-2"
                            type="search"
                            placeholder="Buscar producto"
                            aria-label="Search"
                            id="Nombre" name="Nombre"
                            />
                        <button class="btn btn-outline-success" type="submit">
                            Buscar
                        </button>
                    </form>
            </div>
        </div>
    </nav>
    <div class="container"style="margin-top:50px; margin-bottom:100px;">
        
   

