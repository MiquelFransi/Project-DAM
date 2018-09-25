package com.example.ligu.hmedashboardmytec;

import android.content.Intent;
import android.support.design.widget.CollapsingToolbarLayout;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.CardView;
import android.util.Log;
import android.view.View;

public class Home extends AppCompatActivity implements View.OnClickListener{
    private CardView faqs,chat,crear,meves,sortir;
    String nom,dni,cogn,user;
    CollapsingToolbarLayout toolbar;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home);
        faqs = (CardView) findViewById(R.id.faqs);
        chat = (CardView) findViewById(R.id.chat);
        crear = (CardView) findViewById(R.id.crear);
        meves = (CardView) findViewById(R.id.meves);
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
        crear.setOnClickListener(this);
        meves.setOnClickListener(this);
        sortir.setOnClickListener(this);
    }




    @Override
    public void onClick(View v) {
        Intent i =new Intent();
/*
        i.putExtra("nom", nom );
        i.putExtra("dni", dni );
        i.putExtra("user", user );
        i.putExtra("cognoms", cogn );
*/
        switch (v.getId()) {
            case R.id.faqs: i = new Intent (this,faqs.class);startActivity(i);break;
           case R.id.chat: i = new Intent (this,chat.class);i.putExtra("dni", dni );i.putExtra("user", user );startActivity(i);break;
            //case R.id.chat: i = new Intent (getPackageManager().getLaunchIntentForPackage("com.example.usuari.mytecchat"));i.putExtra("user", user );startActivity(i);break;

            case R.id.crear: i = new Intent (this,crear.class);i.putExtra("dni", dni );startActivity(i);break;
            case R.id.meves: i = new Intent (this,meves.class);i.putExtra("dni", dni ); startActivity(i);break;
            case R.id.sortir: i = new Intent (this,Login.class);startActivity(i);break;

            default:break;
        }




    }

}
