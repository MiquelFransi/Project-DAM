package com.example.ligu.hmedashboardmytec;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;

public class Login extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        final ConnectionClass connectionClass;
        final EditText edtuserid,edtpass;
        Button btnlogin;
        String user="54645645W";

        btnlogin = (Button) findViewById(R.id.btn_Login);
        connectionClass = new ConnectionClass();
        edtuserid = (EditText) findViewById(R.id.et_username);
        edtpass = (EditText) findViewById(R.id.et_password);


        btnlogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                String z;
                Boolean isSuccess = false;
                String userid = edtuserid.getText().toString();
                String password = edtpass.getText().toString();
                String passenc = Hash.sha1(password);
                if(userid.trim().equals("")|| password.trim().equals(""))
                    z = "Please enter User Id and Password";
                else
                {
                    try {
                        Connection con = connectionClass.CONN();

                        if (con == null) {
                            z = "Error in connection with SQL server";
                        } else {
                            String query = "select nom, cognoms, dni from usuaris where NomUsuari='" + userid + "' and Contrasenya='" + passenc + "'";
                            Statement stmt = con.createStatement();
                            ResultSet rs = stmt.executeQuery(query);

                            String query2 = "select  nom, cognoms, dni from informatics where NomInformatic='" + userid + "' and Contrasenya='" + passenc + "'";
                            Statement stmt2 = con.createStatement();
                            ResultSet rs2 = stmt2.executeQuery(query2);

                            if(rs.next()){

                                String nom = rs.getString("nom");
                                String dni = rs.getString("dni");
                                String cognoms = rs.getString("cognoms");


                                z="BENVINGUT USUARI";
                              //  User user = new User(dni,nom,cognoms,userid) ;
                                /*user.dni = dni;
                                user.nom = nom;
                                user.cognoms = cognoms;*/
                                Toast.makeText(Login.this,z,Toast.LENGTH_SHORT).show();

                                Intent tarea= new Intent(getApplicationContext(),Home.class);
                                tarea.putExtra("nom", nom );
                                tarea.putExtra("dni", dni );
                                tarea.putExtra("user", userid );
                                tarea.putExtra("cognoms", cognoms );
                                edtpass.setText("");
                                edtuserid.setText("");


                                startActivity(tarea);


                            }
                            else if  (rs2.next()){

                                z="BENVINGUT INFORMATIC";



                                String nom = rs2.getString("nom");
                                String dni = rs2.getString("dni");
                                String cognoms = rs2.getString("cognoms");


                                z="BENVINGUT INFORMATIC";
                                //  User user = new User(dni,nom,cognoms,userid) ;
                                /*user.dni = dni;
                                user.nom = nom;
                                user.cognoms = cognoms;*/
                                Toast.makeText(Login.this,z,Toast.LENGTH_SHORT).show();

                                Intent tarea= new Intent(getApplicationContext(),HomeInfo.class);
                                tarea.putExtra("nom", nom );
                                tarea.putExtra("dni", dni );
                                tarea.putExtra("user", userid );
                                tarea.putExtra("cognoms", cognoms );
                                edtpass.setText("");
                                edtuserid.setText("");


                                startActivity(tarea);

                            }else {

                                z="Usuari o contrasenya incorrectes";


                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        isSuccess = false;
                        z = "ERORO LOGIN NO USER";
                    }



                    Toast.makeText(Login.this,z,Toast.LENGTH_SHORT).show();
                }





            }
        });
    }
}
