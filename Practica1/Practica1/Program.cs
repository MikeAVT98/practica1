using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno _alumno = new Alumno();
            Profesor _profesor = new Profesor();

            _alumno.Edad = 18;
            _alumno.Nombre = "Mike";
            _alumno.NoControl = 170414;

            _profesor.Edad = 23;
            _profesor.Nombre = "Erick";
            _profesor.Sueldo = 3000;

            Console.WriteLine("La edad del alumno es: {0} su nombre es: {1} y su No. de Control es: {2}", _alumno.Edad, _alumno.Nombre, _alumno.NoControl);
            Console.WriteLine("La edad del profesor es: {0} su nombre es: {1} y su sueldo es: {2}", _profesor.Edad, _profesor.Nombre, _profesor.Sueldo);
            Console.ReadKey();
        }
    }
}
