<?php
include_once 'public/header.php';
?>
<div id="contenedorRegistroAdmin" class="container-fluid" style="margin-top: 55px">
    <div class="row">
        <div  class="col-md-3"></div>
        <div id="registraAdimin" class="col-md-6"class="col-sm-12"style="margin-top: 25px;">
            <h3 id="login1">Registrar Producto</h3>
            <form enctype="multipart/form-data" name="registrar" action="?controlador=Producto&accion=registrarProducto" method="post">
                <div class="form-group">
                    <input type="text" class="form-control" id="Nombre" name="Nombre" placeholder="Producto" value=""required />
                </div>
                <div class="form-group">
                    <select class="form-control" placeholder="Categoría" id="Categoria" name="Categoria">
                        <option value="Categorias"disabled selected> Categorias</option>
                        <?php
                        foreach ($vars as $item) {
                            ?>

                            <option value="<?php echo $item[0]; ?>"> <?php echo $item[1]; ?> </option>
                            <?php
                        }
                        ?>

                    </select>
                </div>

                <div class="form-group">
                    <textarea class="form-control" id="Descripcion" name="Descripcion" placeholder="Descripcion" rows="4" style="resize: none;"></textarea>
                </div>
                <div class="form-group">
                    <input type="text" class="form-control" id="Precio" name="Precio" placeholder="Precio" value="" required/>
                </div>
                <div class="form-group">
                    <input type="text" class="form-control" id="Talla" name="Talla" placeholder="Talla" value="" required/>
                </div>
                <div class="form-group">
                    <input type="text" class="form-control" id="Color" name="Color" placeholder="Color" value="" required/>
                </div>
                <div class="form-group">
                    <input type="text" class="form-control" id="Marca" name="Marca" placeholder="Marca" value="" required/>
                </div>

                <div>
                    <input  type="file"  class="form-control" accept="image/png, .jpeg, .jpg, image/gif" id="imagen" name="imagen">
                </div>

                <div class="form-group">
                    <input type="submit" class="btnSubmit" value="Registrar" />
                </div>
            </form>
        </div>
        <div  class="col-sm-3"></div>
    </div>
</div>
<?php
include_once 'public/footer.php';
?>
