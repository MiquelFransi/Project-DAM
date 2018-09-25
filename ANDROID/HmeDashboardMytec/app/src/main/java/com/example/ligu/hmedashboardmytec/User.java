package com.example.ligu.hmedashboardmytec;

/**
 * Created by maik on 16/05/2018.
 */

public class User {

    public  String  dni;
    public  String nom;
    public String cognoms;
     public  String userName;

public User( String dni , String nom, String cognoms, String userName){
    this.dni = dni;
    this.nom = nom;
    this.nom = cognoms;
    this.userName = userName;

}
    public void setDni(String dni) {
        this.dni = dni;
    }
    public String getDni() {
        return dni;
    }

    public void setNom(String Nom) {
        this.nom = Nom;
    }

    public String getNom() {
        return nom;
    }
    public void setCognoms(String cognoms) {
        this.cognoms = cognoms;
    }
    public String getognoms() {
        return cognoms;
    }

    public void setUserName(String UserName) {
        this.userName = userName;
    }
    public String setUserName() {
        return userName;
    }

}
