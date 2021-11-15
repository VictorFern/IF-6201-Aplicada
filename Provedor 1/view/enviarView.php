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
                        <input class="btn btn-primary" type="button" href="javascript:;"onclick="enviar('<?php echo $item[6]?>','<?php echo $item[1]?>','<?php echo $item[2]?>',<?php echo $item[3]?>,'<?php echo $item[4]?>','<?php echo $item[5]?>','<?php echo $item[7]?>',<?php echo $item[8]?>,'<?php echo $item[9]?>'); return false;" id="agregaCarrito" name="agregaCarrito" value="Enviar"/>
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

