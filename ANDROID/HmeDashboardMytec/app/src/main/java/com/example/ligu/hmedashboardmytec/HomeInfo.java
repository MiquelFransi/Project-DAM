package com.example.ligu.hmedashboardmytec;

import android.content.Intent;
import android.support.design.widget.CollapsingToolbarLayout;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.CardView;
import android.util.Log;
import android.view.View;

public class HomeInfo extends AppCompatActivity implements View.OnClickListener {
    String nom,dni,cogn,user;
    private CardView faqs,chat,MevesInfo,sortir;
    CollapsingToolbarLayout toolbar;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_home_info);
        faqs = (CardView) findViewById(R.id.faqs);
        chat = (CardView) findViewById(R.id.chat);
        MevesInfo = (CardView) findViewById(R.id.meves);
        sortir = (CardView) findViewById(R.id.sortir);


        toolbar = (CollapsingToolbarLayout) findViewById(R.id.colappsingtoolbar);
        // User user;

        // String nom = User.getNom();
        //String cogn = User.getognoms();

        nom = getIntent().getStringExtra("nom");
        cogn = getIntent().getStringExtra("cognoms");
        dni = getIntent().getStringExtra("dni");
        user = getIntent().getStringExtra("user");
        Log.d("nom", "nom=" + dni);


        toolbar.setTitle(nom);
        faqs.setOnClickListener(this);
        chat.setOnClickListener(this);
        MevesInfo.setOnClickListener(this);
        sortir.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        Intent i =new Intent();

        i.putExtra("nom", nom );
        i.putExtra("dni", dni );
        i.putExtra("user", user );
        i.putExtra("cognoms", cogn );

        switch (v.getId()) {
            case R.id.faqs: i = new Intent (this,faqs.class);startActivity(i);break;
           // case R.id.chat: i = new Intent (this,chat.class);startActivity(i);break;
            case R.id.chat: i = new Intent (this,chatInfor.class);i.putExtra("dni", dni );i.putExtra("user", user );startActivity(i);break;

            //case R.id.chat: i = new Intent (getPackageManager().getLaunchIntentForPackage("com.example.usuari.mytecchat"));i.putExtra("user", user );startActivity(i);break;
            case R.id.meves: i = new Intent (this,MevesInfo.class);i.putExtra("dni", dni ); startActivity(i);break;
            //case R.id.sortir: i = new Intent (this,sortir.class);startActivity(i);break;
            case R.id.sortir: i = new Intent (this,Login.class);startActivity(i);break;
            default:break;
        }




    }



}
