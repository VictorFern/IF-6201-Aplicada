package com.api_pumba.controller;

import com.api_pumba.domain.Categoria;
import com.api_pumba.service.CategoriaService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.NoSuchElementException;

@CrossOrigin(origins = "*", allowedHeaders = "*")
@RestController
@RequestMapping(path = "/categories")
public class CategoriaController {

    @Autowired
    private CategoriaService service;

    @GetMapping("/getAllCategorias")
    public @ResponseBody
    List<Categoria> getAllCategorias() {
        return service.getAllCategorias();
    }

    @GetMapping("/getCategoria/{id}")
    public @ResponseBody
    ResponseEntity<Categoria> getCategoriaById(@PathVariable Integer id) {
        try {
            Categoria categoria = service.getCategoriaById(id);
            return new ResponseEntity<Categoria>(categoria, HttpStatus.OK);
        } catch (NoSuchElementException e) {
            return new ResponseEntity<Categoria>(HttpStatus.NOT_FOUND);
        }
    }

    @PostMapping("/insertCategoria")
    @RequestMapping(value = "/insertCategoria", method = RequestMethod.POST)
    public void insertCategoria(@RequestBody Categoria categoria) {
        service.insertCategoria(categoria);
    }

    @PutMapping("/updateCategoria")
    public void updateCategoria(@RequestBody Categoria categoria) {
        service.updateCategoria(categoria);
    }

    @DeleteMapping("/deleteCategoria/{id}")
    public void deleteCategoria(@PathVariable Integer id) {
        service.deleteCategoria(id);
    }

}