package com.api_pumba.service;

import com.api_pumba.domain.Product;
import com.api_pumba.repository.ProductRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;
import java.util.List;

@Service
@Transactional
public class ProductService {

    @Autowired
    private ProductRepository repository;

    public List<Product> getAllProducts() {
        return repository.getAllProducts();
    }

    public Product getProductById(int id) {
        return repository.getProductById(id);
    }

    public void insertProduct(Product product) {

        repository.insertProduct(
                product.getNombre(),
                product.getMarca(),
                product.getDescripcion(),
                product.getPrecio(),
                product.getDimensiones(),
                product.getFoto(),
                product.getIdProveedor(),
                product.getIdCategoria()
                );
    }

    public void updateProduct(Product product) {
        repository.updateProduct(
                product.getProductId(),
                product.getNombre(),
                product.getMarca(),
                product.getDescripcion(),
                product.getPrecio(),
                product.getDimensiones(),
                product.getFoto(),
                product.getIdProveedor(),
                product.getIdCategoria()
        );
    }

    public void deleteProduct(int id) {
        repository.deleteProduct(id);
    }

}