package com.example.ligu.hmedashboardmytec;

import android.annotation.SuppressLint;
import android.os.AsyncTask;
import android.os.StrictMode;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
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

public class crear extends AppCompatActivity {

    ConnectionClass connectionClass;
    Button crearii;
    EditText titol,descrip,provin,pobla;
    Spinner categoria;

    RadioButton alt,baix,mitja;
    String usuari="54645645W";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_crear);

        connectionClass = new ConnectionClass();

        usuari = getIntent().getStringExtra("dni");

        crearii = (Button) findViewById(R.id.crear);
        titol = (EditText) findViewById(R.id.titol);

        descrip = (EditText) findViewById(R.id.descripcio);

        provin = (EditText) findViewById(R.id.provincia);

        pobla = (EditText) findViewById(R.id.poblacio);
        categoria = (Spinner) findViewById(R.id.categoria);


        alt = (RadioButton)findViewById(R.id.alt);
        baix = (RadioButton)findViewById(R.id.baix);

        mitja = (RadioButton)findViewById(R.id.mitja);

        Connection con2 = connectionClass.CONN();

        Categoria(categoria, con2);

        String z;
        try {
            Connection con = connectionClass.CONN();
            if (con == null) {
                z = "Error in connection with SQL server";
            } else {
                String query = "select nom from categoria";
                Statement stmt = con.createStatement();
                ResultSet rs = stmt.executeQuery(query);

                // Spinner Drop down elements
                ArrayList<String> labels;
                labels = new ArrayList<>();

                while(rs.next())
                {

                    labels.add(rs.getString("nom"));
                                                                                                                                                                                                                                                                                                                                                                                                                               z = rs.getString("nom");


                }


                ArrayAdapter<String> dataAdapter = new ArrayAdapter<String>(getApplicationContext(),
                        android.R.layout.simple_spinner_dropdown_item, labels);
                // Drop down layout style - list view with radio button
                // attaching data adapter to spinner



            }
        }
        catch (Exception ex)
        {


        }


        crearii.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                DoLogin  doLogin = new DoLogin();

                doLogin.execute("");


            }
        });

    }


    public class DoLogin extends AsyncTask<String,String,String>
    {
        String z = "";
        Boolean isSuccess = false;


        String TitiolI = titol.getText().toString();

        String descripI = descrip.getText().toString();
        String provinciaI = provin.getText().toString();

        String poblacioI = pobla.getText().toString();


        @Override
        protected void onPreExecute() {
            //pbbar.setVisibility(View.VISIBLE);
        }

        @Override
        protected void onPostExecute(String r) {
            //pbbar.setVisibility(View.GONE);
            Toast.makeText(crear.this,r,Toast.LENGTH_SHORT).show();

            if(isSuccess) {
                Toast.makeText(crear.this,r,Toast.LENGTH_SHORT).show();
            }

        }

        @Override
        protected String doInBackground(String... params) {

            try {
                Connection con = connectionClass.CONN();
                if (con == null) {
                    z = "Error in connection with SQL server";
                } else {
                    //String query = "select * from usuaris where NomUsuari='" + userid + "' and Contrasenya='" + password + "'";
                    // Statement stmt = con.createStatement();
                    //ResultSet rs = stmt.executeQuery(query);


                    TextView textView = (TextView)categoria.getSelectedView();
                    String cate = textView.getText().toString();

                    int dificul=0;

                    if(baix.isChecked()){
                        dificul=0;
                    }else if(alt.isChecked()){
                        dificul=1;
                    }else if(mitja.isChecked()){
                        dificul = 2;
                    }

                        if (!TitiolI.equals("") &&  !descripI.equals("") &&  !provinciaI.equals("") &&  !poblacioI.equals("") ){


                    PreparedStatement pst = con.prepareStatement("insert into incidencies (nom,DNIUsuari,descripcio,poblacio,provincia,categoria,nivell) values(?,?,?,?,?,?,?) ");
                    pst.setString(1, TitiolI);
                    pst.setString(2, usuari);
                    pst.setString(3, descripI);
                    pst.setString(4, poblacioI);
                    pst.setString(5, provinciaI);
                    pst.setString(6, cate);
                    pst.setInt(7, dificul);
                    pst.executeUpdate();
                    z="Incidencia Creada";
                        }else{
                            z="Omple els Camps";
                        }
                   // Toast.makeText(getApplicationContext(), "Incidencia Creada", Toast.LENGTH_LONG).show();


                }
            }
            catch (Exception ex)
            {
                isSuccess = false;
                z = "Exceptions";
            }

            return z;
        }
    }


    public void Categoria(Spinner categoria, Connection con){

        String z;
        try {
            if (con == null) {
                z = "Error in connection with SQL server";
            } else {

                /******CATEGORAI***************/

                String query2 = "select nom from categoria";
                Statement stmt2 = con.createStatement();
                ResultSet rs2 = stmt2.executeQuery(query2);
                // Spinner Drop down elements
                ArrayList<String> cate;
                cate = new ArrayList<>();
                int a=0;

                while (rs2.next()) {

                    cate.add(rs2.getString("nom"));
                    a++;

                }
                //categories adapter
                ArrayAdapter<String> dataAdapter = new ArrayAdapter<String>(getApplicationContext(),
                        android.R.layout.simple_spinner_dropdown_item, cate);

                categoria.setAdapter(dataAdapter);


            }
        } catch (Exception ex) {


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
