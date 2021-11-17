<?php
include_once 'public/header.php';
?>
<div id="contenedorRegistroAdmin" class="container-fluid" style="margin-top: 55px">
    <div class="row">
        <div  class="col-md-3"></div>
        <div id="buscaActualiza" class="col-md-6"style="margin-top: 100px">
            <h1>Buscar producto para Actualizar</h1>
            <form  id="idPro" class="col-sm-12" style="margin-top:50px; margin-bottom:100px;" action="?controlador=Producto&accion=mostrarActualizar" method="post">
                
                <input type="text" class="form-control" id="producto" name="producto" placeholder="Codigo" value="" required /><br><br>
                <input class="btn btn-primary" type="submit" id="actualiza" name="actualiza" value="Buscar"/>
            </form>
        </div>
    </div>
</div>
<?php
include_once 'public/footer.php';
?>
