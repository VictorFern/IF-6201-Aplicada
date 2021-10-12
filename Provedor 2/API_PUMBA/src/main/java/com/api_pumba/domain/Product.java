package com.api_pumba.domain;

import com.fasterxml.jackson.annotation.JsonProperty;

import javax.persistence.*;

@Entity
@Table(name = "Product")
@NamedStoredProcedureQuery(name = "Product.getAllProducts", procedureName = "SelectProduct")

@NamedStoredProcedureQuery(name = "Product.getProductById", procedureName = "SelectProductById",
        parameters = {
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "Product_Id", type = Integer.class)}
)

@NamedStoredProcedureQuery(name = "Product.deleteProduct", procedureName = "DeleteProductById",
        parameters = {
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "Product_Id", type = Integer.class)}
)

@NamedStoredProcedureQuery(name = "Product.insertProduct", procedureName = "InsertProduct",
        parameters = {
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "nombre", type = String.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "marca", type = String.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "descripcion", type = String.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "precio", type = Integer.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "dimensiones", type = String.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "foto", type = String.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "Id_Proveedor", type = Integer.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "Id_Categoria", type = Integer.class)}
)

@NamedStoredProcedureQuery(name = "Product.updateProduct", procedureName = "UpdateProductById",
        parameters = {
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "Product_Id", type = Integer.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "nombre", type = String.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "marca", type = String.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "descripcion", type = String.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "precio", type = Integer.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "dimensiones", type = String.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "foto", type = String.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "Id_Proveedor", type = Integer.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "Id_Categoria", type = Integer.class)}
)



public class Product {
    @JsonProperty
    private int ProductId;
    @JsonProperty
    @Column
    private String Nombre;
    @JsonProperty
    @Column
    private String Marca;
    @JsonProperty
    @Column
    private String Descripcion;
    @JsonProperty
    @Column
    private int Precio;
    @JsonProperty
    @Column
    private String Dimensiones;
    @JsonProperty
    @Column
    private String Foto;
    @JsonProperty
    @Column
    private int IdProveedor;
    @JsonProperty
    @Column
    private int IdCategoria;

    public Product() {
    }

    public Product(int productId, String nombre, String marca, String descripcion, int precio, String dimensiones, String foto, int idProveedor, int idCategoria) {
        ProductId = productId;
        Nombre = nombre;
        Marca = marca;
        Descripcion = descripcion;
        Precio = precio;
        Dimensiones = dimensiones;
        Foto = foto;
        IdProveedor = idProveedor;
        IdCategoria = idCategoria;
    }

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public int getProductId() {
        return ProductId;
    }

    public void setProductId(int studentId) {
        this.ProductId = studentId;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String nombre) {
        Nombre = nombre;
    }

    public String getMarca() {
        return Marca;
    }

    public void setMarca(String marca) {
        Marca = marca;
    }

    public String getDescripcion() {
        return Descripcion;
    }

    public void setDescripcion(String descripcion) {
        Descripcion = descripcion;
    }

    public int getPrecio() {
        return Precio;
    }

    public void setPrecio(int precio) {
        Precio = precio;
    }

    public String getDimensiones() {
        return Dimensiones;
    }

    public void setDimensiones(String dimensiones) {
        Dimensiones = dimensiones;
    }

    public String getFoto() {
        return Foto;
    }

    public void setFoto(String foto) {
        Foto = foto;
    }

    public int getIdProveedor() {
        return IdProveedor;
    }

    public void setIdProveedor(int idProveedor) {
        IdProveedor = idProveedor;
    }

    public int getIdCategoria() {
        return IdCategoria;
    }

    public void setIdCategoria(int idCategoria) {
        IdCategoria = idCategoria;
    }
}

//comment
