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
                $cliente->registrar($_POST['Nombre'], $_POST['Descripcion'], $_POST['Precio'], $_POST['Talla'], $_POST['Color'], $_POST['Marca'], $dest_path,$_POST['Categoria']);
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
        }else{
            $this->view->show("buscaEliminarProductoView.php",null);
            
        }
        
    }
    public function eliminarProducto() {
        require 'model/ProductoModel.php';
        $cliente = new ProductoModel();
        $cliente->eliminar($_POST['ID']);
        $this->view->show("buscaEliminarProductoView.php",null);
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
        }else{
            $this->view->show("buscaActualizarProductoView.php",null);
            
        }
        
    }
     public function actualizaProducto() {
        require 'model/ProductoModel.php';
        $cliente = new ProductoModel();
        $cliente->actualizar($_POST['ID'], $_POST['NOMBRE'], $_POST['DESCRIPCION'], $_POST['PRECIO'], $_POST['TALLA'], $_POST['COLOR'], $_POST['MARCA'],$_POST['Categoria']);
        $this->view->show("buscaActualizarProductoView.php",null);
    }
    
    

}

// fin clase
