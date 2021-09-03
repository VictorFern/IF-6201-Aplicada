package com.api_pumba.controller;

import com.api_pumba.domain.Student;
import com.api_pumba.service.StudentService;
import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.NoSuchElementException;


@CrossOrigin(origins = "http://localhost:3000")
@RestController
@RequestMapping(path = "/api/student")
public class StudentController {

    @Autowired
    private StudentService service;

    @GetMapping("/students")
    public @ResponseBody List<Student> list() {
        //¿reglas de negocio?
        //if...es admin
        return service.listAll();
    }

    @GetMapping("/students/{id}")
    public @ResponseBody ResponseEntity<Student> get(@PathVariable Integer id) {
        try {
            Student student = service.get(id);
            return new ResponseEntity<Student>(student, HttpStatus.OK);
        } catch (NoSuchElementException e) {
            return new ResponseEntity<Student>(HttpStatus.NOT_FOUND);
        }
    }

    @PostMapping("/add")
    public @ResponseBody void add(@RequestBody String studentJson) {

        //reglas de negocio??

        ObjectMapper objectMapper;

        try {

            objectMapper = new ObjectMapper();

            JsonNode jsonNode = objectMapper.readTree(studentJson);

            String name = jsonNode.get("Name").asText();
            String email = jsonNode.get("Email").asText();
            String password = jsonNode.get("Password").asText();

            Student student = new Student();
            student.setName(name);
            student.setEmail(email);
            student.setPassword(password);

            service.save(student);

        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    @PutMapping("/update")
    public @ResponseBody void update(@RequestBody Student student) {
        Student existingStudent = service.get(student.getStudentId());
        service.save(student);
    }

    @DeleteMapping("/delete/{id}")
    public void delete(@PathVariable Integer id) {
        service.delete(id);
    }



    // ######################################
    // ######################################
    // END POINTS for use the stored procedures

    @GetMapping("/getAllStudents")
    public @ResponseBody List<Student> getAllStudents() {
        return service.getAllStudents();
    }

    @GetMapping("/getStudent/{id}")
    public @ResponseBody ResponseEntity<Student> getStudentById(@PathVariable Integer id){
        try {
            Student student = service.getStudentById(id);
            return new ResponseEntity<Student>(student, HttpStatus.OK);
        } catch(NoSuchElementException e){
            return new ResponseEntity<Student>(HttpStatus.NOT_FOUND);
        }
    }

    @PostMapping("/saveStudent")
    @RequestMapping(value = "/saveStudent", method = RequestMethod.POST)
    public void saveStudent(@RequestBody Student student) {

        service.insertStudentSP(student);
    }

    @PutMapping("/updateStudent")
    public void updateStudent(@RequestBody Student student){
        service.updateStudentSP(student);
    }

    @GetMapping("/deleteSP/{id}")
    @RequestMapping(value = "/deleteSP/{id}", method = RequestMethod.DELETE)
    public void deleteSP(@PathVariable Integer id) {
        service.deleteStudentSP(id);
    }

}