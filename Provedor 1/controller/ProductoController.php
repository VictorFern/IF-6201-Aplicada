<?php

class ProductoController {

    public function __construct() {
        $this->view = new View();
    }

// constructor

    public function mostrar() {
        $data['listado'] = null;

        $this->view->show("indexView.php", $data);
    }

// listar

    public function inicio() {
        $this->view->show("indexView.php", null);
    }

    public function registrar() {
        require 'model/ProductoModel.php';
        $cliente = new ProductoModel();
        $data = $cliente->mostrar_Categorias();
        $this->view->show("insertarProductoView.php", $data);
    }

    public function registrarRegistrar() {
        
    }

}

// fin clase
