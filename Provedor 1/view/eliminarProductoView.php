<?php
include_once 'public/header.php';
?>
<div id="contenedorRegistroAdmin" class="container-fluid" style="margin-top: 55px">

    <div class="row">
        <div  class="col-md-3"></div>
        <div id="registraAdimin" class="col-md-6"class="col-sm-12"style="margin-top: 100px;">
            <h3 id="login1">Eliminar Producto</h3>
            <form name="login" action="?controlador=Producto&accion=eliminarProducto" method="post">

                <div class="form-group">
                    <input type="text" class="form-control" id="ID" name="ID" placeholder="ID" value="<?php echo $vars['producto'][0][0] ?>" required readonly/>
                </div>

                <div class="form-group">
                    <input type="text" class="form-control" id="NOMBRE" name="NOMBRE" placeholder="NOMBRE" value="<?php echo $vars['producto'][0][1] ?>" required readonly />
                </div>
                
                <div class="form-group">
                    <input type="text" class="form-control" id="DESCRIPCION" name="DESCRIPCION" placeholder="DESCRIPCION" value="<?php echo $vars['producto'][0][2] ?>" required readonly/>
                </div>
                <div class="form-group">
                    <input type="text" class="form-control" id="PRECIO" name="PRECIO" placeholder="PRECIO" value="<?php echo $vars['producto'][0][3] ?>" required readonly/>
                </div>
                <div class="form-group">
                    <input type="text" class="form-control" id="TALLA" name="TALLA" placeholder="TALLA" value="<?php echo $vars['producto'][0][4] ?>" required readonly/>
                </div>
                <div class="form-group">
                    <input type="text" class="form-control" id="COLOR" name="COLOR" placeholder="COLOR" value="<?php echo $vars['producto'][0][5] ?>" required readonly/>
                </div>
                <div class="form-group">
                    <input type="text" class="form-control" id="MARCA" name="MARCA" placeholder="MARCA" value="<?php echo $vars['producto'][0][6] ?>" required readonly/>
                </div>
                <div class="form-group">
                    <input type="text" class="form-control" id="CATEGORIA" name="CATEGORIA" placeholder="CATEGORIA" value="<?php echo $vars['producto'][0][8] ?>" required readonly/>
                </div>
               
                <div class="form-group">
                    <input type="submit" class="btnSubmit" value="Eliminar" />
                </div>
            </form>
        </div>
        <div  class="col-sm-3"></div>
    </div>
</div>
<?php
include_once 'public/footer.php';
?>
