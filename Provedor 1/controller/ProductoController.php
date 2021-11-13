<?php

class ProductoController {

    public function __construct() {
        $this->view = new View();
    }

// constructor
// listar
    public function inicio() {
        require 'model/ProductoModel.php';
        $cliente = new ProductoModel();
        $data['listado'] = $cliente->mostrar_Producto();
        $this->view->show("indexView.php", $data);
    }

    public function registrar() {
        require 'model/ProductoModel.php';
        $cliente = new ProductoModel();
        $data = $cliente->mostrar_Categorias();
        $this->view->show("insertarProductoView.php", $data);
    }

    public function registrarProducto() {
        require 'model/ProductoModel.php';
        $cliente = new ProductoModel();

        $fileTmpPath = $_FILES['imagen']['tmp_name'];
        $fileName = $_FILES['imagen']['name'];
        $fileSize = $_FILES['imagen']['size'];
        $fileType = $_FILES['imagen']['type'];
        $fileNameCmps = explode(".", $fileName);
        $fileExtension = strtolower(end($fileNameCmps));

        $newFileName = md5(time() . $fileName) . '.' . $fileExtension;
        $allowedfileExtensions = array('jpg', 'gif', 'png');
        if (in_array($fileExtension, $allowedfileExtensions)) {
            $uploadFileDir = './public/img/';
            $dest_path = $uploadFileDir . $newFileName;
            if (move_uploaded_file($fileTmpPath, $dest_path)) {
                $cliente->registrar($_POST['Nombre'], $_POST['Descripcion'], $_POST['Precio'], $_POST['Talla'], $_POST['Color'], $_POST['Marca'], $newFileName, $_POST['Categoria']);
                $this->view->show("insertarProductoView.php", $cliente->mostrar_Categorias());
            }
        }
    }

    public function eliminar() {
        require 'model/ProductoModel.php';

        $this->view->show("buscaEliminarProductoView.php");
    }

    public function mostrarEliminar() {
        require 'model/ProductoModel.php';
        $cliente = new ProductoModel();
        $data['producto'] = $cliente->mostrar_producto_id($_POST['producto']);
        if (!empty($data['producto'][0][0])) {

            $this->view->show("eliminarProductoView.php", $data);
        } else {
            $this->view->show("buscaEliminarProductoView.php", null);
        }
    }

    public function eliminarProducto() {
        require 'model/ProductoModel.php';
        $cliente = new ProductoModel();
        $cliente->eliminar($_POST['producto1']);
        $data['listado'] = $cliente->mostrar_Producto();
        $this->view->show("indexView.php", $data);
    }

    public function actualiza() {
        require 'model/ProductoModel.php';

        $this->view->show("buscaActualizarProductoView.php");
    }

    public function mostrarActualizar() {
        require 'model/ProductoModel.php';
        $cliente = new ProductoModel();
        $data['producto'] = $cliente->mostrar_producto_id($_POST['producto']);
        $data['categorias'] = $cliente->mostrar_Categorias();
        if (!empty($data['producto'][0][0])) {

            $this->view->show("actualizarProductoView.php", $data);
        } else {
            $this->view->show("buscaActualizarProductoView.php", null);
        }
    }

    public function actualizaProducto() {
        require 'model/ProductoModel.php';
        $cliente = new ProductoModel();
        $cliente->actualizar($_POST['ID'], $_POST['NOMBRE'], $_POST['DESCRIPCION'], $_POST['PRECIO'], $_POST['TALLA'], $_POST['COLOR'], $_POST['MARCA'], $_POST['Categoria']);
        $data['listado'] = $cliente->ver_Producto($_POST['ID']);
        $this->view->show("mostrarProductoView.php", $data);
    }

    public function buscarProducto() {
        require 'model/ProductoModel.php';
        $cliente = new ProductoModel();
        $data['listado'] = $cliente->mostrar_Producto_Nombre($_POST['Nombre']);
        $this->view->show("indexView.php", $data);
    }

    public function mostrarProducto() {
        require 'model/ProductoModel.php';
        $cliente = new ProductoModel();
        $data['listado'] = $cliente->ver_Producto($_GET['producto']);
        $this->view->show("mostrarProductoView.php", $data);
    }

    public function login() {
        require 'model/ProductoModel.php';

        $this->view->show("loginView.php");
    }
    public function solicitar() {
        require 'model/ProductoModel.php';
        $cliente = new ProductoModel();
        $data['productos'] = $cliente->solicitar_key();
        $this->view->show("loginView.php", null);
    }
    
    public function inicioSeccion() {
        require 'model/ProductoModel.php';
         $cliente = new ProductoModel();
        $data['seccion'] = $cliente->inicioSeccion($_POST['clave']);
        $this->view->show("enviarView.php",null);
    }
}

// fin clase
