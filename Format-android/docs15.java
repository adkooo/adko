package com.example.myapplicationza;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class TSS extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tss);


        String l = getIntent().getStringExtra("textView");


        EditText editText = findViewById(R.id.ts);
        Button button = findViewById(R.id.TSs);

        editText.setText(l);

        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String a = editText.getText().toString();
                Intent intent  = new Intent();
                intent.putExtra("p"  , a);
                setResult(Activity.RESULT_OK , intent);
                finish();
            }
        });


    }


}
