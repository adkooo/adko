//MainActivity.java فایل


package com.example.myapplicationza;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.RadioGroup;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // برای دسترسی به دکمه
        Button a = findViewById(R.id.button3);
        a.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Toast.makeText(MainActivity.this ,  "سلام دنیا !" , Toast.LENGTH_SHORT).show();
            }
        });

        // برای دسترسی به چک‌باکس
        CheckBox b = findViewById(R.id.checkBox);
        b.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if (isChecked) {
                    Toast.makeText(MainActivity.this, "چک‌باکس انتخاب شد!", Toast.LENGTH_SHORT).show();
                } else {
                    Toast.makeText(MainActivity.this, "چک‌باکس انتخاب نشده!", Toast.LENGTH_SHORT).show();
                }
            }
        });


        // برای دسترسی به رادیو باتن
        
        RadioGroup c = findViewById(R.id.idra);
        c.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(RadioGroup radioGroup, int i) {
                switch (i){
                    case R.id.radioButton:
                        Toast.makeText(MainActivity.this , "1" ,Toast.LENGTH_SHORT).show();
                        break;
                    case R.id.radioButton2:
                        Toast.makeText(MainActivity.this , "2" ,Toast.LENGTH_SHORT).show();
                        break;
                }
            }
        });



    }
}
