package com.api_pumba.repository;

import com.api_pumba.domain.Categoria;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.jpa.repository.query.Procedure;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface CategoriaRepository extends JpaRepository<Categoria, Integer>{

    @Query(value = "SelectCategoria", nativeQuery = true)
    List<Categoria> getAllCategorias();

    @Query(value = "{ call SelectCategoriaById(:id)}", nativeQuery = true)
    Categoria getCategoriaById(@Param("id") Integer id);

    @Procedure(value = "Product.insertCategoria")
    void insertCategoria(@Param("nombre") String nombre
    );

    @Procedure(value = "Product.updateCategoria")
    void updateCategoria(@Param("id") Integer id,
                       @Param("nombre") String nombre
    );

    @Procedure(value = "Product.deleteCategoria")
    void deleteCategoria(@Param("id") Integer id);

}
