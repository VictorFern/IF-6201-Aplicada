<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

class ProductoModel {

    protected $db;

    public function __construct() {
        require 'libs/SPDO.php';
        $this->db = SPDO::singleton();
    }
 public function registrar($nombre, $descripcion, $precio, $talla, $color, $marca, $foto, $idc) {
        $consulta = $this->db->prepare("call sp_insetar_producto('" . $nombre . "','" . $descripcion . "'," . $precio . "," . $talla . ",'".$color."','".$marca."','".$foto."', ".$idc.");");
        $consulta->execute();
        $consulta->closeCursor();
    }

    public function actualizar($ID,$NOMBRE, $descripcion, $precio, $talla, $color, $marca,$categoria) {
        $consulta = $this->db->prepare("call sp_actualizar_producto(".$ID.",'".$NOMBRE."','".$descripcion."',".$precio.",".$talla.",'".$color."','".$marca."',".$categoria.");");
        $consulta->execute();
        $consulta->closeCursor();
    }
    public function eliminar($ID) {
        //$consulta = $this->db->prepare("call sp_actualizar_producto(". $ID .",'" . $NOMBRE . "','" . $descripcion . "'," . $precio . "," . $talla . ",'".$color."','".$marca."',".$categoria.");");
        $consulta = $this->db->prepare("call sp_eliminar_producto(".$ID.");");
        
        $consulta->execute();
        $consulta->closeCursor();
    }
   
    public function mostrar_Producto() {
        $query = $this->db->prepare("call sp_mostrar_producto()");
        $query->execute();
        $data = $query->fetchAll();
        $query->closeCursor();
        return $data;
    }
    
    public function ver_Producto($id) {
        $query = $this->db->prepare("call sp_mostrar_producto_id(".$id.")");
        $query->execute();
        $data = $query->fetchAll();
        $query->closeCursor();
        return $data;
    }

    public function mostrar_producto_id($codigo) {
        $query = $this->db->prepare("call sp_mostrar_producto_id('". $codigo ."')");
        $query->execute();
        $data = $query->fetchAll();
        $query->closeCursor();
        return $data;
}
    
  public function mostrar_Producto_Nombre($nombre) {
        $query = $this->db->prepare("call sp_mostrar_producto_nombre('".$nombre."')");
        $query->execute();
        $data = $query->fetchAll();
        $query->closeCursor();
        return $data;
    }
    

    public function mostrar_Categorias() {
        $query = $this->db->prepare("call sp_categorias()");
        $query->execute();
        $data = $query->fetchAll();
        $query->closeCursor();
        return $data;
    }
     public function solicitar_key() {
        $data['productos'] = json_decode(file_get_contents('http://apitomeylleve-001-site1.etempurl.com/api/Productos/getKey/1'), true);
        return $data;
    }
     public function inicioSeccion($clave) {
        $data['seccion'] = json_decode(file_get_contents('http://apitomeylleve-001-site1.etempurl.com/api/Productos/login/'.$clave), true);
        return $data;
    }

}
