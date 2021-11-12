<?php
include_once 'public/header.php';
?>

<div class="row">
    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12">
        <div id="box1">
            <figure>
                <img class="fit-image  rounded d-block m-l-none" src="public/img/<?php echo $vars['listado'][0][7] ?>" alt="Responsive image">
            </figure>
            <div class="caption">
                <h3>
                    <?php echo $vars['listado'][0][6] ?>
                </h3>
            </div>
        </div>
    </div>
    <div class="col-lg-3">

        <div id="box2">
            <div class="title">
                <br>
                <h4><?php echo $vars['listado'][0][1] ?></h4>
            </div>

            <div class="text">
                <span><?php echo $vars['listado'][0][2] ?></span>
            </div>
            <div class="caption">
                <h3>
                  Precio:  ₡<?php echo $vars['listado'][0][3] ?>
                </h3>
            </div>
            <div class="caption">
                <h3>
                    Talla: <?php echo $vars['listado'][0][4] ?>
                </h3>
            </div>
            <div class="caption">
                <h3>
                   Color: <?php echo $vars['listado'][0][5] ?>
                </h3>
            </div>
            <div>
                <form  id="idPro" class="col-sm-12" style="margin-top:50px; margin-bottom:100px;" action="?controlador=Producto&accion=mostrarActualizar" method="post">
                    <input type="text"  class="form-control" id="producto" name="producto" placeholder="Codigo" value="<?php echo $vars['listado'][0][0] ?>" required hidden />
                <input class="btn btn-primary" type="submit" id="actualiza" name="actualiza" value="Actualizar"/>
            </form>
            </div>
            <div>
             <form name="login" action="?controlador=Producto&accion=eliminarProducto" method="post">
                <input type="text"  class="form-control" id="producto1" name="producto1" placeholder="Codigo" value="<?php echo $vars['listado'][0][0] ?>" required hidden />
                <input class="btn btn-primary" type="submit" id="eliminar" name="Eliminar" value="Eliminar"/>
            </form>
            </div>
        </div> 
    </div>
</div>

<?php
include_once 'public/footer.php';
?>

