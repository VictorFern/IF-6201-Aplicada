package com.api_pumba.domain;

import com.fasterxml.jackson.annotation.JsonProperty;

import javax.persistence.*;

@Entity
@Table(name = "Categoria")
@NamedStoredProcedureQuery(name = "Categoria.getAllCategorias", procedureName = "SelectCategoria")

@NamedStoredProcedureQuery(name = "Categoria.getCategoriaById", procedureName = "SelectCategoriaById",
        parameters = {
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "id", type = Integer.class)}
)

@NamedStoredProcedureQuery(name = "Categoria.deleteCategoria", procedureName = "DeleteCategoriaById",
        parameters = {
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "id", type = Integer.class)}
)

@NamedStoredProcedureQuery(name = "Categoria.insertCategoria", procedureName = "InsertCategoria",
        parameters = {
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "nombre", type = String.class)}
)

@NamedStoredProcedureQuery(name = "Categoria.updateCategoria", procedureName = "UpdateCategoriaById",
        parameters = {
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "id", type = Integer.class),
                @StoredProcedureParameter(mode = ParameterMode.IN, name = "nombre", type = String.class)}
)



public class Categoria {
    @JsonProperty
    private int id;
    @JsonProperty
    @Column
    private String Nombre;


    public Categoria() {
    }

    public Categoria(int id, String nombre) {
        id = id;
        Nombre = nombre;

    }

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String nombre) {
        Nombre = nombre;
    }

}

