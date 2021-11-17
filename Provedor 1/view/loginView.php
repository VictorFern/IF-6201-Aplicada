<?php

include_once 'public/header.php';
?>
<section class="vh-100" style="background-color: #a76e26;">
    <div class="container py-5 h-100">
        <div class="row d-flex justify-content-center align-items-center h-100">
            <div class="col col-xl-10">
                <div class="card" style="border-radius:1rem;">
                    <div class="row g-0">
                        <div class="col-md-6 col-lg-5 d-none d-md-block">
                            <img  src="public/img/zapatosEnviar.jpg" width="400" height="425" alt="login form"  style="border-radius: 1rem 0 0 1rem;" />
                        </div>
                        <div class="col-md-6 col-lg-7 d-flex align-items-center">
                            <div class="card-body p-4 p-lg-5 text-black">
                                <form id="iniciaSesion" action="?controlador=Producto&accion=inicioSeccion" method="POST">
                                    <h1>Iniciar Sesión</h1>
                                    

                                    <input type="password" id="clave" name="clave" style="margin-bottom: 15px;" class="form-control" placeholder="Clave" required/>

                                    <button type="submit" class="btn btn-success">Iniciar Sesión</button>
                                    <p class="mb-5 pb-lg-2" style="color: #393f81;">¿Solicitar contraseña si no la tiene? 
                                        <a href="?controlador=Producto&accion=solicitar" style="color: #393f81;">Solicitar key</a>
                                    </p>
                                </form>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<?php

include_once 'public/footer.php';
?>
