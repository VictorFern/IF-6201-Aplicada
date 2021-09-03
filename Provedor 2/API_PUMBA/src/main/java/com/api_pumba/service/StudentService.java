package com.api_pumba.service;

import com.api_pumba.domain.Student;
import com.api_pumba.repository.StudentRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;
import java.util.List;

@Service
@Transactional
public class StudentService {

    @Autowired
    private StudentRepository repository;


    // using ORM Hibernate
    public List<Student> listAll() {
        return repository.findAll();
    }

    public void save(Student student) { repository.save(student); }

    public Student get(int id) {
        return repository.findById(id).get();
    }

    public void delete(int id) {
        repository.deleteById(id);
    }



    // using stored procedures call
    public List<Student> getAllStudents() {
        return repository.getAllStudents();
    }

    public Student getStudentById(int id) {
        return repository.getStudentById(id);
    }

    public void insertStudentSP(Student student) {
        repository.insertStudentSP(student.getName(),
                student.getEmail(), student.getPassword());
    }

    public void updateStudentSP(Student student) {
        repository.updateStudentSP(student.getStudentId(),student.getName(),
                student.getEmail(), student.getPassword());
    }

    public void deleteStudentSP(int id) {
        repository.deleteStudentSP(id);
    }

}