<?php

include_once 'public/header.php';
?>
<section class="vh-100" style="background-color: #9A616D;">
    <div class="container py-5 h-100">
        <div class="row d-flex justify-content-center align-items-center h-100">
            <div class="col col-xl-10">
                <div class="card" style="border-radius:1rem;">
                    <div class="row g-0">
                        <div class="col-md-6 col-lg-5 d-none d-md-block">
                            <img src="https://mdbootstrap.com/img/Photos/new-templates/bootstrap-login-form/img1.jpg" alt="login form" class="img-fluid" style="border-radius: 1rem 0 0 1rem;" />
                        </div>
                        <div class="col-md-6 col-lg-7 d-flex align-items-center">
                            <div class="card-body p-4 p-lg-5 text-black">
                                <form id="iniciaSesion" action="#" method="POST">
                                    <h1>Iniciar Sesión</h1>
                                    <input type="text" style=" margin-bottom: 15px;" class="form-control" placeholder="Provedor" required/>

                                    <input type="password" style="margin-bottom: 15px;" class="form-control" placeholder="Clave" required/>

                                    <button type="submit" class="btn btn-success">Iniciar Sesión</button>
                                    <p class="mb-5 pb-lg-2" style="color: #393f81;">¿Solicitar contraseña si no la tiene? 
                                        <a href="#!" style="color: #393f81;">Solicitar key</a>
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
