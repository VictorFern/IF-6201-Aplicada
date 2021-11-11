package com.api_pumba.service;

import com.api_pumba.domain.Categoria;
import com.api_pumba.repository.CategoriaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;
import java.util.List;

@Service
@Transactional
public class CategoriaService {

    @Autowired
    private CategoriaRepository repository;

    public List<Categoria> getAllCategorias() {
        return repository.getAllCategorias();
    }

    public Categoria getCategoriaById(int id) {
        return repository.getCategoriaById(id);
    }

    public void insertCategoria(Categoria categoria) {

        repository.insertCategoria(
                categoria.getNombre()
        );
    }

    public void updateCategoria(Categoria categoria) {
        repository.updateCategoria(
                categoria.getId(),
                categoria.getNombre()
        );
    }

    public void deleteCategoria(int id) {
        repository.deleteCategoria(id);
    }

}