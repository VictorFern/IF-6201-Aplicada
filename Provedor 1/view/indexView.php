<?php
include_once 'public/header.php';
?>

<div class="row">

    <?php
    foreach ($vars['listado'] as $item) {
        ?>
        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12">
            <div class="box-part text-center">
                <div class="title">
                    <br>
                    <h4><?php echo $item[1] ?></h4>
                </div>
                <figure>
                    <a href="?controlador=Producto&accion=mostrarProducto&producto=<?php echo $item[0];?>">
                        <img class="fit-image  rounded d-block m-l-none" src="public/img/<?php echo $item[7];?>" alt="Responsive image">
                    </a>
                </figure>
                <div class="text">
                    <span><?php echo $item[2] ?></span>
                </div>
                <div class="caption">
                    <h3>
                        ₡<?php echo $item[3] ?>
                    </h3>
                </div>
            </div>
        </div>
        <?php
    }
    ?>
</div>

<?php
include_once 'public/footer.php';
?>

