import React, { Component } from 'react';
import './App.css';
import axios from "axios";
import "bootstrap/dist/css/bootstrap.min.css";
import { faEdit, faTrashAlt } from '@fortawesome/free-solid-svg-icons';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { Modal, ModalBody, ModalFooter, ModalHeader } from 'reactstrap';

const url = 'http://localhost:8080/API_PUMBA/products/';
const url2 = "http://apitomeylleve-001-site1.etempurl.com/api/Productos/";


export class App extends Component {

  state = {
    products: [],
    modalInsert: false,
    modalType: 'insert',
    modalDelete: false,
    form: {
      productId: 0,
      nombre: '',
      marca: '',
      descripcion: '',
      precio: 0,
      dimensiones: '',
      foto: '',
      idProveedor: 2,
      otrasCaracteristicas: 'no disponible',
      categoria: 'licores',
      cantidad: 1

    }
  };




  modalInsert = () => {
    this.setState({ modalInsert: !this.state.modalInsert });
  }

  selectProduct = (product) => {

    this.setState({
      modalType: 'update',
      form: {
        productId: product.productId,
        nombre: product.nombre,
        marca: product.marca,
        descripcion: product.descripcion,
        precio: product.precio,
        dimensiones: product.dimensiones,
        foto: product.foto,
        idproveedor: 2,
        otrascaracteristicas: 'no disponible',
        categoria: 'licores',
        cantidad: 1
      }
    })
  }

  getProducts = () => {

    axios.get(url + 'getAllProducts')
      .then(response => {
        this.setState({ products: response.data });
      }).catch(error => {
        console.log(error.message);
      })
  }


  insertProduct = async () => {

    delete this.state.form.id;
    await axios.post(url + 'insertProduct', this.state.form)
      .then(response => {
        this.modalInsert();
        this.getProducts();
      }).catch(error => {
        console.log(error.message);
      })
  }


  updateProduct = () => {

    axios.put(url + 'updateProduct', this.state.form)
      .then(response => {
        this.modalInsert();
        this.getProducts();
      }).catch(error => {
        console.log(error.message);
      })
  }


  deleteProduct = () => {

    axios.delete(url + 'deleteProduct/' + this.state.form.productId,)
      .then(response => {
        this.modalInsert();
        this.getProducts();
      }).catch(error => {
        console.log(error.message);
      })

  }

  

  sendProduct = async () => {

    delete this.state.form.id;
    await axios.post(url2 + 'Registro', this.state.form)
      .then(response => {
        this.modalInsert();
        this.getProducts();
      }).catch(error => {
        console.log(error.message);
        console.log(this.state.form);
      })
  }


  handleChange = async e => {

    e.persist();
    await this.setState({
      form: {
        ...this.state.form,
        [e.target.name]: e.target.value
      }
    });
  }


  // GUI 
  componentDidMount() { // se llama al cargar la página init
    this.getProducts();
    
  }

  render() {
    const { form } = this.state;

    return (

      <div className="App">

        <a href='' target='_blank'><img src='https://i.postimg.cc/Vv6hfWZN/logo512.png' border='0' alt='logo512'/></a>
        <br /><br /><br />
        <a href="http://apitomeylleve-001-site1.etempurl.com/api/Productos/getKey/2" target="_blank">solicitar key Tome & Lleve</a>

        <br /><br /><br />

        <input type="text" name="key" id="key" /> 
        <a href="http://apitomeylleve-001-site1.etempurl.com/api/Productos/login/IF6201-Proyecto-Aplicada-2021" target="_blank">acceder Tome & Lleve</a>

        
        <br /><br /><br />
        <button className="btn btn-success" onClick={() => { this.setState({ form: null, modalType: 'insert' }); this.modalInsert() }}>Agregar producto</button>
        <br /><br />

        <table className="table " align="center">
          <thead>
            <tr>
              <th>Id</th>
              <th>Nombre</th>
              <th>Marca</th>
              <th>Descripción</th>
              <th>Precio</th>
              <th>Dimensiones</th>
              <th>Imagen</th>
              <th>Editar</th>
            </tr>
          </thead>

          <tbody>
            {this.state.products.map(product => {
              let uri
              return (
                <tr>
                  <td>{product.productId}</td>
                  <td>{product.nombre}</td>
                  <td>{product.marca}</td>
                  <td>{product.descripcion}</td>
                  <td>{product.precio}</td>
                  <td>{product.dimensiones}</td>
                  <td>
                    <div className="App">

                    <a><img src={product.foto} alt="" border="0" /></a>
                    </div>
                  </td>
                  <td>
                    <button className="btn btn-primary" onClick={() => { this.selectProduct(product); this.modalInsert() }}><FontAwesomeIcon icon={faEdit} /></button>
                  </td>
                </tr>
              )
            })}
          </tbody>

        </table>

        <Modal isOpen={this.state.modalInsert}>
          <ModalHeader style={{ display: 'block' }}>
            <span style={{ float: 'right' }} onClick={() => this.modalInsert()}>cerrar X</span>
          </ModalHeader>
          <ModalBody>
            <div className="form-group">
              <label htmlFor="id">ID</label>
              <input className="form-control" type="number" name="productId" id="productId" readOnly onChange={this.handleChange} value={form ? form.productId : 0} />
              <br />
              <label htmlFor="nombre">Nombre</label>
              <input className="form-control" type="text" name="nombre" id="nombre" onChange={this.handleChange} value={form ? form.nombre : ''} />
              <br />
              <label htmlFor="marca">Marca</label>
              <input className="form-control" type="text" name="marca" id="marca" onChange={this.handleChange} value={form ? form.marca : ''} />
              <br />
              <label htmlFor="descripcion">Descripción</label>
              <input className="form-control" type="text" name="descripcion" id="descripcion" onChange={this.handleChange} value={form ? form.descripcion : ''} />
              <br />
              <label htmlFor="precio">Precio</label>
              <input className="form-control" type="number" name="precio" id="precio" onChange={this.handleChange} value={form ? form.precio : ''} />
              <br />
              <label htmlFor="dimensiones">Dimensiones</label>
              <input className="form-control" type="text" name="dimensiones" id="dimensiones" onChange={this.handleChange} value={form ? form.dimensiones : ''} />
              <br />
              <label>Imagen: Ingrese la URL</label>
              <a href="https://postimages.org/" target="_blank">::cargar aquí::</a>
              <input type="text" className="form-control" name="foto" id="foto" onChange={this.handleChange} value={form ? form.foto : ''} required />
              <br />
            </div>
          </ModalBody>

          <ModalFooter>
            {this.state.modalType === 'insert' ?
              <button className="btn btn-success" onClick={() => this.insertProduct()}>Insertar</button> :
              <button className="btn btn-primary" onClick={() => this.updateProduct()}>Actualizar</button>
            }

            <button className="btn btn-danger" onClick={() => this.deleteProduct()}>Eliminar</button>
            <button className="btn btn-danger" onClick={() => this.sendProduct()}>Enviar a T & LL</button>
            <button className="btn btn-danger" onClick={() => this.modalInsert()}>Cancelar</button>
          </ModalFooter>
        </Modal>

      </div>
    );
  }
}

export default App;