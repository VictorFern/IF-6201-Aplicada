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
    
    public function mostrar_Producto() {
//        $query = $this->db->prepare("call sp_acabado()");
//        $query->execute();
//        $data = $query->fetchAll();
//        $query->closeCursor();
        return $data;
    }
    public function mostrar_Categorias() {
        $query = $this->db->prepare("call sp_categorias()");
        $query->execute();
        $data = $query->fetchAll();
        $query->closeCursor();
        return $data;
    }
}
