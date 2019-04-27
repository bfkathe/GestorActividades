package com.example.andre.proyectogestoractividades;

import android.os.StrictMode;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

public class RegistrarParticipante extends AppCompatActivity {

    Spinner spinnerTipo,spinnerCursos;
    EditText edNombre,edApellido1,edApellido2,edCorreo,edNumeroCurso,edIdentificacion;
    Button btnAceptar;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registrar_participante);
        spinnerTipo = (Spinner)findViewById(R.id.spinnerTipo);
        spinnerCursos = (Spinner)findViewById(R.id.spinnerGrupo);
        edNombre = (EditText) findViewById(R.id.edtNombre);
        edApellido1 = (EditText) findViewById(R.id.edtApellido1);
        edApellido2 = (EditText) findViewById(R.id.edtApellido2);
        edCorreo = (EditText) findViewById(R.id.edtCorreo);
        edNumeroCurso = (EditText) findViewById(R.id.edtNumeroCurso);
        edIdentificacion = (EditText) findViewById(R.id.edtIdentificacion);
        btnAceptar = (Button)findViewById(R.id.btRegistrar);

        btnAceptar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                agregarParticipante();
            }
        });
    }

    public Connection conexionBD(){
        Connection conexion = null;
        try{
            StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
            StrictMode.setThreadPolicy(policy);
            Class.forName("net.sourceforge.jtds.jdbc.Driver").newInstance();
            conexion = DriverManager.getConnection("jdbc:jtds:sqlserver://192.168.100.2;datebaseName=ProyectoGestorActividades;user=ANDRE\\SQLEXPRESS;");

        }catch(Exception e){
            Toast.makeText(getApplicationContext(),e.getMessage(),Toast.LENGTH_SHORT).show();

        }
        return conexion;
    }

    public void agregarParticipante(){
        try{
            PreparedStatement pst = conexionBD().prepareStatement("insert into Pruebas values(?)");
            pst.setString(1,edApellido1.getText().toString());
            //pst.setString(2,edApellido2.getText().toString());
            //pst.setString(3,edNombre.getText().toString());
            //pst.setInt(4,Integer.parseInt(edIdentificacion.getText().toString()));
            //pst.setString(5,edCorreo.getText().toString());
            //pst.executeUpdate();
            Toast.makeText(getApplicationContext(),"Registro Exitoso",Toast.LENGTH_SHORT).show();

        }catch (SQLException e){
            Toast.makeText(getApplicationContext(),e.getMessage(),Toast.LENGTH_SHORT).show();

        }
    }
}
