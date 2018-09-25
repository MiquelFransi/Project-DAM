package com.example.ligu.hmedashboardmytec;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.widget.ListView;
import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.os.StrictMode;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;


import java.sql.Connection;

public class chatInfor extends AppCompatActivity {
    ListView chats;


    ConnectionClass connectionClass;

    String [] nomchats = new String[200];


    String dni ,user;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_chat_infor);

        dni = getIntent().getStringExtra("dni");
        user = getIntent().getStringExtra("user");
        connectionClass = new ConnectionClass();

        chats = (ListView) findViewById(R.id.chats);


        Log.d("nomC", "nomChat=" + dni);
        String z="hola";
        try {
            Connection con = connectionClass.CONN();
            if (con == null) {
                z = "Error in connection with SQL server";
            } else {
                z="sql";
                String query = "select DISTINCT dniInformatic, dniUsuari from incidencies  where dniInformatic='" + dni + "' and estat = 1  ";
                Log.d("query", "queryChat=" + query);

                Statement stmt = con.createStatement();
                ResultSet rs = stmt.executeQuery(query);

                // Spinner Drop down elements
                ArrayList<String> labels;
                labels = new ArrayList<>();
                int a = 0;
                while (rs.next()) {

                    nomchats[a] = rs.getString("dniInformatic")+ rs.getString("dniUsuari");
                    //labels.add(rs.getString("dniInformatic"));


                    a++;
                    //                   Log.d("query", "result=" + rs.getString("dniInformatic"));

                    String dniI = rs.getString("dniUsuari");
                    String query2 = "select  nomUsuari   from usuaris    where  DNI='" + dniI + "'";
                    Statement stmt2 = con.createStatement();
                    ResultSet rs2 = stmt2.executeQuery(query2);
                    //Log.d("query", "queryChat2=" + query2);
                    while (rs2.next()){

                        labels.add(rs2.getString("nomUsuari"));

                    }


                }


                //indencies adater
                ArrayAdapter<String> dataAdapter2 = new ArrayAdapter<String>(getApplicationContext(),
                        android.R.layout.simple_list_item_1,labels);
                // Drop down layout style - list view with radio button
                // attaching data adapter to spinner
                chats.setAdapter(dataAdapter2);


            }
        } catch (Exception ex) {

            z="erro";

            Toast.makeText(chatInfor.this, z, Toast.LENGTH_SHORT).show();

        }



        chats.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                String nomchat = nomchats[position];

                // your code here
                Intent i = new Intent();
                i = new Intent(getPackageManager().getLaunchIntentForPackage("com.example.usuari.mytecchat"));
                i.putExtra("user", user );
                i.putExtra("chat", nomchat );

                startActivity(i);
            }
        });








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