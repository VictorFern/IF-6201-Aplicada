package com.api_pumba.repository;

import com.api_pumba.domain.Product;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.jpa.repository.query.Procedure;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface ProductRepository extends JpaRepository<Product, Integer>{

    @Query(value = "SelectProduct", nativeQuery = true)
    List<Product> getAllProducts();

    @Query(value = "{ call SelectProductById(:Product_Id)}", nativeQuery = true)
    Product getProductById(@Param("Product_Id") Integer productId);

    @Procedure(value = "Product.insertProduct")
    void insertProduct(@Param("nombre") String nombre,
                       @Param("marca") String marca,
                       @Param("descripcion") String descripcion,
                       @Param("precio") int precio,
                       @Param("dimensiones") String dimensiones,
                       @Param("foto") String foto,
                       @Param("Id_Proveedor") int IdProveedor,
                       @Param("Id_Categoria") int IdCategoria
   );

    @Procedure(value = "Product.updateProduct")
    void updateProduct(@Param("Product_Id") Integer productId,
                       @Param("nombre") String nombre,
                       @Param("marca") String marca,
                       @Param("descripcion") String descripcion,
                       @Param("precio") int precio,
                       @Param("dimensiones") String dimensiones,
                       @Param("foto") String foto,
                       @Param("Id_Proveedor") int IdProveedor,
                       @Param("Id_Categoria") int IdCategoria
     );

    @Procedure(value = "Product.deleteProduct")
    void deleteProduct(@Param("Product_Id") Integer productId);

}
