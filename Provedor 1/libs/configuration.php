<?php

require 'libs/Config.php';
$config = Config::singleton();
$config->set('controllerFolder', 'controller/');
$config->set('modelFolder', 'model/');
$config->set('viewFolder', 'view/');
//
$config->set('dbhost', 'localhost'); // ip
$config->set('dbname', 'if6201_caite');
$config->set('dbuser', 'root');
$config->set('dbpass', 'Kurama1727x.');

//$config->set('dbhost', '163.178.107.10'); // ip
//$config->set('dbname', 'if6201_caite');
//$config->set('dbuser', 'laboratorios');
//$config->set('dbpass', 'KmZpo.2796');
?>

