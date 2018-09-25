package com.example.ligu.hmedashboardmytec;

import android.annotation.SuppressLint;
import android.os.StrictMode;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RatingBar;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

public class MevesInfo extends AppCompatActivity {

    Spinner categoria, incidencies;
    TextView titol,descrip;
    RadioButton siFeta,noFeta;
    TextView nomInfor;
    int[] position = new int[200];

    RatingBar valoracio;


    String user;

    //  hh = infoUser.GetDni();

    int numIncidencia;
    ConnectionClass connectionClass;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_meves_info);


        user = getIntent().getStringExtra("dni");
        Log.d("nom", "nom=" + user);

        connectionClass = new ConnectionClass();

        incidencies = (Spinner) findViewById(R.id.incidencies);
        categoria = (Spinner) findViewById(R.id.categoria);
        valoracio = (RatingBar) findViewById(R.id.valoracio);
        siFeta = (RadioButton) findViewById(R.id.siFeta);
        noFeta = (RadioButton) findViewById(R.id.noFeta);

        titol = (TextView) findViewById(R.id.titol);
        descrip = (TextView) findViewById(R.id.descrip);
        nomInfor = (TextView) findViewById(R.id.informatic);




        String z;
        try {
            Connection con = connectionClass.CONN();
            if (con == null) {
                z = "Error in connection with SQL server";
            } else {
                String query = "select numIncidencia, nom from incidencies  where dniInformatic='" + user + "'";
                Statement stmt = con.createStatement();
                ResultSet rs = stmt.executeQuery(query);

                // Spinner Drop down elements
                ArrayList<String> labels;
                labels = new ArrayList<>();
                int a = 0;
                labels.add("Incidencies");
                while (rs.next()) {
                    a++;
                    position[a] = rs.getInt("numIncidencia");


                    labels.add(rs.getString("nom"));


                }

                /******CATEGORAI***************/

                String query2 = "select nom from categoria";
                Statement stmt2 = con.createStatement();
                ResultSet rs2 = stmt2.executeQuery(query2);
                // Spinner Drop down elements
                ArrayList<String> cate;
                cate = new ArrayList<>();

                while (rs2.next()) {

                    cate.add(rs2.getString("nom"));

                }
                //categories adapter
                ArrayAdapter<String> dataAdapter = new ArrayAdapter<String>(getApplicationContext(),
                        android.R.layout.simple_spinner_dropdown_item, cate);
                //indencies adater
                ArrayAdapter<String> dataAdapter2 = new ArrayAdapter<String>(getApplicationContext(),
                        android.R.layout.simple_spinner_dropdown_item, labels);
                // Drop down layout style - list view with radio button
                // attaching data adapter to spinner
                incidencies.setAdapter(dataAdapter2);
                categoria.setAdapter(dataAdapter);


            }
        } catch (Exception ex) {


        }


        /*************************INCIEDNEICES MOURE A MEVES *****************************************************/
        incidencies.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parentView, View selectedItemView, int position, long id) {

                // your code here
                if (id != 0 && position != 0) {
                    CargarIncidenciaInfor(position, id);

                }else{
                    titol.setText("");
                    descrip.setText("");
                    valoracio.setRating(0f);
                    noFeta.setChecked(true);
                    nomInfor.setText("Usuari no Assignat");


                }

            }

            @Override
            public void onNothingSelected(AdapterView<?> parentView) {
                // your code here
            }

        });







    }


    public void CargarIncidenciaInfor(int posicio, long id) {

        // edtuserid.setText("hola p "+posicio+" id: "+id);
        numIncidencia = position[posicio];
        Log.d("num", "num=" + numIncidencia);

        String z = null;
        try {
            Connection con = connectionClass.CONN();

            if (con == null) {
                z = "Error in connection with SQL server";
                Toast.makeText(MevesInfo.this, z, Toast.LENGTH_SHORT).show();

            } else {
                //z = "SQL";

                String query = "select  nom, descripcio,nivell,categoria, v.valoracio, i.dniUsuari, estat " +
                        "from incidencies i full join valoracio v on i.numIncidencia = v.numIncidencia   " +
                        "where  i.numIncidencia= '" + numIncidencia + "'";
                Log.d("query", "query=" + query);
                Statement stmt = con.createStatement();
                ResultSet rs = stmt.executeQuery(query);


                // z = Integer.toString(numIncidencia);

                int a = 0;

                //asignem variables DE LA CONSULTA
                while (rs.next()) {

                    titol.setText(rs.getString("nom"));
                    descrip.setText(rs.getString("descripcio"));

                    boolean feta = rs.getBoolean("estat");
                    //feta=true;
                    String var = rs.getString("valoracio");

                    String cate = rs.getString("categoria");
                    int pos=0;

                    if(cate.equals("firmware")){
                        pos=0;

                    }else  if(cate.equals("Hardware")){
                        pos=1;

                    }else  if(cate.equals("Network")){
                        pos=2;

                    }else  if(cate.equals("Software")){
                        pos=3;

                    }else  if(cate.equals("Virus")){
                        pos=3;
                    }


                    categoria.setSelection(pos);

                    //si  esta feta
                    if (feta==false) {

                        if (var.equals("Bé")) {
                            valoracio.setRating(5f);
                        } else if (var.equals("Regular")) {
                            valoracio.setRating(3f);
                        } else if ((var.equals("Malament"))) {
                            valoracio.setRating(1f);
                        }
                        siFeta.setChecked(true);
                        //No esta feta
                    } else {
                        valoracio.setRating(0f);
                        noFeta.setChecked(true);

                    }


                    ///cargar NOM INFORMATICS DE LA taula informaticS
                    String DNI = rs.getString("dniUsuari");
                    String query2 = "select  NomUsuari   from usuaris    where  DNI='" + DNI + "'";
                    Log.d("query2", "query2=" + query2);
                    Statement stmt2 = con.createStatement();
                    ResultSet rs2 = stmt.executeQuery(query2);
                    //asignem variables DE LA CONSULTA
                    if (rs2.next()) {

                        nomInfor.setText(rs2.getString("NomUsuari"));

                    }else{
                        nomInfor.setText("Usuari no Assignat");


                    }

                }


            }
        } catch (Exception ex) {

             //z = "EXECPOTP";
           // Toast.makeText(MevesInfo.this, z, Toast.LENGTH_SHORT).show();

        }


    }



    public static class ConnectionClass {
        String ip = "212.170.161.168";
        String classs = "net.sourceforge.jtds.jdbc.Driver";
        String db = "MYTEC";
        String un = "DAM2_MYTEC";
        String password = "LluisGili!";


        @SuppressLint("NewApi")
        public Connection CONN() {
            StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder()
                    .permitAll().build();
            StrictMode.setThreadPolicy(policy);
            Connection conn = null;
            String ConnURL = null;
            try {

                Class.forName(classs);
                ConnURL = "jdbc:jtds:sqlserver://" + ip + ";"
                        + "databaseName=" + db + ";user=" + un + ";password="
                        + password + ";";
                conn = DriverManager.getConnection(ConnURL);
            } catch (SQLException se) {
                Log.e("ERROr", se.getMessage());
            } catch (ClassNotFoundException e) {
                Log.e("ERROr", e.getMessage());
            } catch (Exception e) {
                Log.e("ERROr", e.getMessage());
            }
            return conn;
        }
    }
}
