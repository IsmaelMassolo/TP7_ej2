/*Realizar un sistema para realizar una encuesta para determinar estudiantes de colegios
públicos y privados. Al finalizar el sistema debe determinar cantidad total de alumnos
encuestados, cantidad y porcentaje para asistentes a colegios privados y públicos.*/
using System;
namespace TP7_ej2
{
    class Program
    {   
        static void Main(string[] args)
        {
            string evalua = "";
            int cantAlumno = 0, privados = 0, publicos = 0;
            float porcentajePri = 0, porcentajePub = 0;
            titular ();
            instruccion (cantAlumno);
            evalua = Console.ReadLine();
            while (evalua == "B" || evalua =="V" || evalua == "b" || evalua =="v")
            {
                switch (evalua)
                {
                    case "B" or "b":
                        publicos ++;
                        cantAlumno ++;
                        titular ();
                        instruccion (cantAlumno);
                        evalua = Console.ReadLine();
                    break;
                    case "V" or "v":
                        privados ++;
                        cantAlumno ++;
                        titular ();
                        instruccion (cantAlumno);
                        evalua = Console.ReadLine();
                    break;
                }
            }
            titular ();
            Console.WriteLine("Ha seleccionado la tecla "+evalua+"\n");
            porcentajePri= (privados*100)/cantAlumno;
            porcentajePub= (publicos*100)/cantAlumno;
            Console.WriteLine("Cantidad de alumnos encuestados:  " +cantAlumno);
            Console.WriteLine("Cantidad de alumnos en Escuelas Públicas: " +publicos);
            Console.WriteLine("Cantidad de alumnos en Escuelas Privadas: " +privados);
            Console.WriteLine("Porcentaje de alumnos que asisten a Escuelas Públicas: " +porcentajePub +"%");
            Console.WriteLine("Porcentaje de alumnos que asisten a Escuelas Privadas: " +porcentajePri +"%\n");
            Console.WriteLine("Gracias por utilizar el sistema...");
            Console.WriteLine("***********************************************************");
        }
        static void titular ()
        {
            string titulo = "******[[[SISTEMA DE ESTUDIANTES PUBLICOS Y PRIVADOS]]]******";
            Console.Clear();
            Console.WriteLine (titulo + "\n");
        }
        static int instruccion (int alumnoNumero)
        {
            Console.WriteLine ("A continuación ingrese el tipo de colegio del alumno " + (alumnoNumero+1) +"\n");
            Console.WriteLine ("(Tecla [B] para colegio público - Tecla [V] para colegio privado)");
            Console.WriteLine ("(Cualquier otra tecla seleccionada cierra el sistema)\n");
            return alumnoNumero;
        }
    }
}