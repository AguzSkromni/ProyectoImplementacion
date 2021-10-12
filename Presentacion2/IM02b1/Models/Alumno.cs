using System;

public class Alumno{

    //ATRIBUTOS
    private static int contadorAlumno;
    public int idAlumno;
    public string nombre;
    public int cuenta;
    public double promedio;

    //CONSTRUCTORES
    public Alumno(string nombre, int cuenta, double promedio){
        this.idAlumno = ++contadorAlumno;
        this.nombre = nombre;
        this.cuenta = cuenta;
        this.promedio = promedio;
    }
}