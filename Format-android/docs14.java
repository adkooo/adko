package com.example.myapplicationza;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);




        Button button2 = findViewById(R.id.button2);
        button2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Intent.ACTION_VIEW , Uri.parse("https://github.com/"));
                startActivity(intent);
            }
        });


        // دسترسی به چک‌باکس و تنظیم Listener برای تغییرات چک‌باکس
        CheckBox checkBox = findViewById(R.id.checkBox);
        checkBox.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if (isChecked) {
                    Toast.makeText(MainActivity.this, "چک‌باکس انتخاب شد!", Toast.LENGTH_SHORT).show();
                } else {
                    Toast.makeText(MainActivity.this, "چک‌باکس انتخاب نشده!", Toast.LENGTH_SHORT).show();
                }
            }
        });

        // دسترسی به دکمه button3 برای شروع Activity جدید با انتظار برای نتیجه
        Button button3 = findViewById(R.id.button3);
        button3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MainActivity.this, TSS.class);
                startActivityForResult(intent, 1001);
            }
        });




    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data); // فراخوانی متد پدر برای مدیریت نتایج

        if (requestCode == 1001 && resultCode == Activity.RESULT_OK && data != null) {
            String m = data.getStringExtra("p");
            TextView textView = findViewById(R.id.textView);
            textView.setText(m);
        }
    }
}
