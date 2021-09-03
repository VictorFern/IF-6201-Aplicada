import React, { Component } from 'react';
import './App.css';
import axios from "axios";
import "bootstrap/dist/css/bootstrap.min.css";
import { faEdit, faTrashAlt } from '@fortawesome/free-solid-svg-icons';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { Modal, ModalBody, ModalFooter, ModalHeader } from 'reactstrap';

const url = 'http://localhost:8080/api/student/';

export class App extends Component {

  state = {
    students: [],
    modalInsert: false,
    modalType: 'insert',
    modalDelete: false,
    form: {
      studentId: 0,
      name: '',
      email: '',
      password: '',
    }
  };

  modalInsert = () => {
    this.setState({ modalInsert: !this.state.modalInsert });
  }

  selectStudent = (student) => {
    this.setState({
      modalType: 'update',
      form: {
        studentId: student.studentId,
        name: student.name,
        email: student.email,
        password: student.password
      }
    })
  }

  getStudents = () => {
    axios.get(url + 'getAllStudents').then(response => {
      this.setState({ students: response.data });
    }).catch(error => {
      console.log(error.message);
    })
  }

  saveStudent = async () => {
    delete this.state.form.id;
    await axios.post(url + 'saveStudent', this.state.form).then(response => {
      this.modalInsert();
      this.getStudents();
    }).catch(error => {
      console.log(error.message);
    })
  }

  updateStudent = () => {
    axios.put(url + 'updateStudent', this.state.form).then(response => {
      this.modalInsert();
      this.getStudents();
    })
  }

  deleteStudent = () => {

    axios.delete(url + 'DeleteSP/' + this.state.form.studentId, this.state.form).then(response => {
      this.modalInsert();
      this.getStudents();
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

  componentDidMount() { // similat to Oninit en Angular
    this.getStudents();
  }

  render() {
    const { form } = this.state;
    return (
      <div className="App">
        <br /><br /><br />
        <button className="btn btn-success" onClick={() => { this.setState({ form: null, modalType: 'insert' }); this.modalInsert() }}>Agregar estudiante</button>
        <br /><br />
        <table className="table ">
          <thead>
            <tr>
              <th>Id</th>
              <th>Nombre</th>
              <th>Email</th>
              <th>Contraseña</th>
              <th>Acciones</th>
            </tr>
          </thead>
          <tbody>
            {this.state.students.map(student => {
              return (
                <tr>
                  <td>{student.studentId}</td>
                  <td>{student.name}</td>
                  <td>{student.email}</td>
                  <td>{student.password}</td>
                  <td>
                    <button className="btn btn-primary" onClick={() => { this.selectStudent(student); this.modalInsert() }}><FontAwesomeIcon icon={faEdit} /></button>
                    {"   "}
                    <button className="btn btn-danger" onClick={() => { this.selectStudent(student); this.setState({ modalDelete: true }) }}><FontAwesomeIcon icon={faTrashAlt} /></button>
                  </td>
                </tr>
              )
            })}
          </tbody>
        </table>

        <Modal isOpen={this.state.modalInsert}>
          <ModalHeader style={{ display: 'block' }}>
            <span style={{ float: 'right' }} onClick={() => this.modalInsert()}>x</span>
          </ModalHeader>
          <ModalBody>
            <div className="form-group">
              <label htmlFor="id">Id</label>
              <input className="form-control" type="number" name="studentId" id="studentId" readOnly onChange={this.handleChange} value={form ? form.studentId : 0} />
              <br />
              <label htmlFor="name">Nombre</label>
              <input className="form-control" type="text" name="name" id="name" onChange={this.handleChange} value={form ? form.name : ''} />
              <br />
              <label htmlFor="email">Email</label>
              <input className="form-control" type="text" name="email" id="email" onChange={this.handleChange} value={form ? form.email : ''} />
              <br />
              <label htmlFor="password">Contraseña</label>
              <input className="form-control" type="text" name="password" id="password" onChange={this.handleChange} value={form ? form.password : ''} />
            </div>
          </ModalBody>

          <ModalFooter>
            { this.state.modalType === 'insert' ?
              <button className="btn btn-success" onClick={() => this.saveStudent()}>Insertar</button> :
              <button className="btn btn-primary" onClick={() => this.updateStudent()}>Actualizar</button> 
            }

            <button className="btn btn-danger" onClick={() => this.deleteStudent()}>Eliminar</button>
            <button className="btn btn-danger" onClick={() => this.modalInsert()}>Cancelar</button>

          </ModalFooter>
        </Modal>

      </div>
    );
  }
}

export default App;