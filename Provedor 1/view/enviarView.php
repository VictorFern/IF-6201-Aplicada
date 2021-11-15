<?php
include_once 'public/headerTomeYLleve.php';
?>
<div class="container">
    <div class="table-responsive">
        <h1>Lista de productos a enviar</h1>
        <table class="table table-bordered table-hover table-condensed" id="table">
            <thead>
                <tr id="table">
                    <th id="table">Nombre</th>
                    <th id="table">Descripcion</th>
                    <th id="table">Precio</th>
                    <th id="table">Enviar</th>
                </tr>
            </thead>
            <?php
            foreach ($vars['listado'] as $item) {
                ?>
                <tr id="table">
                    <td id="table"><?php echo $item[1] ?>
                        <div id="box1">
                            <img src="public/img/<?php echo $item[7]; ?>"alt="Responsive image" width="200px" height="100px">
                        </div>
                    </td>
                    <td id="table"><?php echo $item[2] ?></td>
                    <td id="table">₡<?php echo $item[3] ?></td>
                    <td id="table">
                        <form enctype="multipart/form-data" id="<?php echo $item[0] ?>" name="<?php echo $item[0] ?>" action="?controlador=Producto&accion=enviarApi" method="post">
                            <input type="text" class="form-control" id="nombre" name="nombre" placeholder="Producto" value="<?php echo $item[1] ?>"required hidden/>
                            <input type="text" class="form-control" id="descripcion" name="descripcion" placeholder="Producto" value="<?php echo $item[2] ?>"required hidden/>
                            <input type="text" class="form-control" id="precio" name="precio" placeholder="Producto" value="<?php echo $item[3] ?>"required hidden/>
                            <input type="text" class="form-control" id=dimension" name="dimension" placeholder="Producto" value="<?php echo $item[4] ?>"required hidden/>
                            <input type="text" class="form-control" id="otras" name="otras" placeholder="Producto" value="<?php echo $item[5] ?>"required hidden/>
                            <input type="text" class="form-control" id="marca" name="marca" placeholder="Producto" value="<?php echo $item[6] ?>"required hidden/>
                            <input type="text" class="form-control" id="foto" name="foto" placeholder="Producto" value="<?php echo $item[7] ?>"required hidden/>
                            <input type="text" class="form-control" id="cantidad" name="cantidad" placeholder="Producto" value="<?php echo $item[8] ?>"required hidden/>
                            <input type="text" class="form-control" id="categoria" name="categoria" placeholder="Producto" value="<?php echo $item[9] ?>"required hidden/>
                            <div class="form-group">
                                <input type="submit" class="btnSubmit" value="Enviar" />
                            </div>
                        </form>

                    </td>
                </tr>
                <?php
            }
            ?>
        </table>
    </div>
</div>
<?php
include_once 'public/footer.php';
?>

