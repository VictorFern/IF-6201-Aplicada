<?php
include_once 'public/header.php';
?>
<div class="container" id="muestraProducto">


    <div class="row">
        <div id="" class="col-lg-4 col-md-4 col-sm-4 col-xs-12">
            <div class="box-part text-center">
                <div class="title">
                    <br>
                    <h4> Marca: <?php echo $vars['listado'][0][6] ?></h4>
                    <h5> ID: <?php echo $vars['listado'][0][0] ?></h5>
                </div>
                <figure>
                    <img class="fit-image  rounded d-block m-l-none" src="public/img/<?php echo $vars['listado'][0][7]; ?>" alt="Responsive image">
                </figure>
                <div class="text">
                    <h5>Modelo: <?php echo $vars['listado'][0][1] ?></h5>
                </div>
                <div class="caption">
                    <h3>
                        Precio ₡<?php echo $vars['listado'][0][3] ?>
                    </h3>
                </div>
            </div>
        </div>

        <div id="" class="col-lg-4 col-md-4 col-sm-4 col-xs-12">
            <div class="box-part text-center">
                <div class="title">
                    <br>


                </div>

                <div class="text">
                    <br>
                    <br>
                    <br>
                    <h4> Talla: <?php echo $vars['listado'][0][4] ?> </h4><br>
                    <h5> Color: <?php echo $vars['listado'][0][5] ?></h5><br>
                    <h5>
                        Descripcion: <?php echo $vars['listado'][0][2] ?>
                    </h5><br>
                </div>
                <div class="caption">
                    <div class="row">


                        <div class="col-md-12">
                            <form id="idPro1"  name="login" class="col-sm-12"  action="?controlador=Producto&accion=mostrarActualizar" method="post">                            
                                <input  type="text"  class="form-control" id="producto" name="producto" placeholder="Codigo" value="<?php echo $vars['listado'][0][0] ?>" required hidden />
                                <input class="btn btn-primary"  type="submit" id="actualiza" name="actualiza" value="Actualizar"/>
                            </form>
                        </div>
                        <br>
                        <br>
                        <div class="col-md-12">
                            <form  id="idPro" class="col-sm-12"  action="?controlador=Producto&accion=eliminarProducto" method="post">
                                <input  type="text"  class="form-control" id="producto1" name="producto1" placeholder="Codigo" value="<?php echo $vars['listado'][0][0] ?>" required hidden />
                                <input class="btn btn-danger"  type="submit" id="eliminar" width="100" name="Eliminar" value="Eliminar"/>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<?php
include_once 'public/footer.php';
?>

