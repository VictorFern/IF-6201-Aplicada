package com.api_pumba.controller;

import com.api_pumba.domain.Product;
import com.api_pumba.service.ProductService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.NoSuchElementException;

@CrossOrigin(origins = "*", allowedHeaders = "*")
@RestController
@RequestMapping(path = "/products")
public class ProductController {

    @Autowired
    private ProductService service;

    @GetMapping("/getAllProducts")
    public @ResponseBody
    List<Product> getAllProducts() {
        return service.getAllProducts();
    }

    @GetMapping("/getProduct/{id}")
    public @ResponseBody
    ResponseEntity<Product> getProductById(@PathVariable Integer id) {
        try {
            Product product = service.getProductById(id);
            return new ResponseEntity<Product>(product, HttpStatus.OK);
        } catch (NoSuchElementException e) {
            return new ResponseEntity<Product>(HttpStatus.NOT_FOUND);
        }
    }

    @PostMapping("/insertProduct")
    @RequestMapping(value = "/insertProduct", method = RequestMethod.POST)
    public void insertProduct(@RequestBody Product product) {
        service.insertProduct(product);
    }

    @PutMapping("/updateProduct")
    public void updateProduct(@RequestBody Product product) {
        service.updateProduct(product);
    }

    @DeleteMapping("/deleteProduct/{id}")
    public void deleteProduct(@PathVariable Integer id) {
        service.deleteProduct(id);
    }

}