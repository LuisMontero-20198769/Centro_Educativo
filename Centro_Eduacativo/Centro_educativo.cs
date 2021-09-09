using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Collections.Generic;

namespace Centro_Eduacativo
{
    class Centro_educativo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("*                                       *");
            Console.WriteLine("*    CENTRO EDUCATIVO SOL RADIANTE      *");
            Console.WriteLine("*                                       *");
            Console.WriteLine("*****************************************\n");

            Console.WriteLine("* Padre Original*\n");
            Padre padreOrignal = new Padre();//objeto  de la clase Padre
            Console.WriteLine("-- Digite su nombre: ");
            padreOrignal.nombrep = Console.ReadLine();
            Console.WriteLine("-- Digite su apellido: ");
            padreOrignal.apellidop = Console.ReadLine();
            Console.WriteLine("-- Digite su sexo: ");
            padreOrignal.sexop = Console.ReadLine();
            Console.WriteLine("-- Digite su edad: ");
            padreOrignal.edadp = int.Parse(Console.ReadLine());
            Console.WriteLine("-- Digite su numero telefonico: ");
            padreOrignal.telefono = double.Parse(Console.ReadLine());
            Console.WriteLine();//Salto de linea

            Console.WriteLine("* Alumno Original*\n");
            Alumno alumnoOrignal = new Alumno();//objeto  de la clase Padre
            alumnoOrignal.datos = new Padre();
            alumnoOrignal.datos.nombrep = padreOrignal.nombrep;
            alumnoOrignal.datos.telefono = padreOrignal.telefono;
            Console.WriteLine("-- Digite su nombre: ");
            alumnoOrignal.nombreA = Console.ReadLine();
            Console.WriteLine("-- Digite su apellido: ");
            alumnoOrignal.apellidoA = Console.ReadLine();
            Console.WriteLine("-- Digite su sexo: ");
            alumnoOrignal.sexoA = Console.ReadLine();
            Console.WriteLine("-- Digite su edad: ");
            alumnoOrignal.edadA = int.Parse(Console.ReadLine());
            Console.WriteLine("-- Digite su grado academico: ");
            alumnoOrignal.gradoA = Console.ReadLine();
            Console.WriteLine();//Salto de linea

            Console.WriteLine("* Padre Clon 1*\n");
            Padre padreClon1 = new Padre();//objeto  de la clase Padre
            padreClon1 = (Padre)padreOrignal.Clone();
            Console.WriteLine("-- Digite su nombre: ");
            padreClon1.nombrep = Console.ReadLine();
            Console.WriteLine("-- Digite su apellido: ");
            padreClon1.apellidop = Console.ReadLine();
            Console.WriteLine("-- Digite su sexo: ");
            padreClon1.sexop = Console.ReadLine();
            Console.WriteLine("-- Digite su edad: ");
            padreClon1.edadp = int.Parse(Console.ReadLine());
            Console.WriteLine("-- Digite su numero telefonico: ");
            padreClon1.telefono = double.Parse(Console.ReadLine());
            Console.WriteLine();//Salto de linea

            Console.WriteLine("* Alumno Clon1*\n");
            Alumno alumnoclon1 = (Alumno)alumnoOrignal.Clone();
            alumnoclon1.datos = new Padre();
            alumnoclon1.datos.nombrep = padreClon1.nombrep;
            alumnoclon1.datos.telefono = padreClon1.telefono;
            Console.WriteLine("-- Digite su nombre: ");
            alumnoclon1.nombreA = Console.ReadLine();
            Console.WriteLine("-- Digite su apellido: ");
            alumnoclon1.apellidoA = Console.ReadLine();
            Console.WriteLine("-- Digite su sexo: ");
            alumnoclon1.sexoA = Console.ReadLine();
            Console.WriteLine("-- Digite su edad: ");
            alumnoclon1.edadA = int.Parse(Console.ReadLine());
            Console.WriteLine("-- Digite su grado academico: ");
            alumnoclon1.gradoA = Console.ReadLine();
            Console.WriteLine();//Salto de linea

            Console.WriteLine("* Padre Clon 2*\n");
            Padre padreClon2 = new Padre();//objeto  de la clase Padre
            padreClon2 = (Padre)padreOrignal.Clone();
            Console.WriteLine("-- Digite su nombre: ");
            padreClon2.nombrep = Console.ReadLine();
            Console.WriteLine("-- Digite su apellido: ");
            padreClon2.apellidop = Console.ReadLine();
            Console.WriteLine("-- Digite su sexo: ");
            padreClon2.sexop = Console.ReadLine();
            Console.WriteLine("-- Digite su edad: ");
            padreClon2.edadp = int.Parse(Console.ReadLine());
            Console.WriteLine("-- Digite su numero telefonico: ");
            padreClon2.telefono = double.Parse(Console.ReadLine());
            Console.WriteLine();//Salto de linea

            Console.WriteLine("* Alumno Clon2*\n");
            Alumno alumnoclon2 = (Alumno)alumnoOrignal.Clone();
            alumnoclon2.datos = new Padre();
            alumnoclon2.datos.nombrep = padreClon2.nombrep;
            alumnoclon2.datos.telefono = padreClon2.telefono;
            Console.WriteLine("-- Digite su nombre: ");
            alumnoclon2.nombreA = Console.ReadLine();
            Console.WriteLine("-- Digite su apellido: ");
            alumnoclon2.apellidoA = Console.ReadLine();
            Console.WriteLine("-- Digite su sexo: ");
            alumnoclon2.sexoA = Console.ReadLine();
            Console.WriteLine("-- Digite su edad: ");
            alumnoclon2.edadA = int.Parse(Console.ReadLine());
            Console.WriteLine("-- Digite su grado academico: ");
            alumnoclon2.gradoA = Console.ReadLine();
            Console.WriteLine();//Salto de linea

            Console.WriteLine("* Padre Clon 2*\n");
            Padre padreClon3 = new Padre();//objeto  de la clase Padre
            padreClon3 = (Padre)padreOrignal.Clone();
            Console.WriteLine("-- Digite su nombre: ");
            padreClon3.nombrep = Console.ReadLine();
            Console.WriteLine("-- Digite su apellido: ");
            padreClon3.apellidop = Console.ReadLine();
            Console.WriteLine("-- Digite su sexo: ");
            padreClon3.sexop = Console.ReadLine();
            Console.WriteLine("-- Digite su edad: ");
            padreClon3.edadp = int.Parse(Console.ReadLine());
            Console.WriteLine("-- Digite su numero telefonico: ");
            padreClon3.telefono = double.Parse(Console.ReadLine());
            Console.WriteLine();//Salto de linea

            Console.WriteLine("* Alumno Clon3*\n");
            Alumno alumnoclon3 = (Alumno)alumnoOrignal.Clone();
            alumnoclon3.datos = new Padre();
            alumnoclon3.datos.nombrep = padreClon3.nombrep;
            alumnoclon3.datos.telefono = padreClon3.telefono;
            Console.WriteLine("-- Digite su nombre: ");
            alumnoclon3.nombreA = Console.ReadLine();
            Console.WriteLine("-- Digite su apellido: ");
            alumnoclon3.apellidoA = Console.ReadLine();
            Console.WriteLine("-- Digite su sexo: ");
            alumnoclon3.sexoA = Console.ReadLine();
            Console.WriteLine("-- Digite su edad: ");
            alumnoclon3.edadA = int.Parse(Console.ReadLine());
            Console.WriteLine("-- Digite su grado academico: ");
            alumnoclon3.gradoA = Console.ReadLine();
            Console.WriteLine();//Salto de linea


            //Console.WriteLine("*** DATOS ***");
            //Console.WriteLine(padreOrignal);
            //Console.WriteLine();//Salto de linea
            //Console.WriteLine(alumnoOrignal);
            //Console.WriteLine();//Salto de linea

            try
            {

                //Guardar datos en un archivo .txt
                StreamWriter txt = new StreamWriter(@"C:\Users\Edward Montero\Desktop\App C#\Centro_Eduacativo\" +
                    "Centro_Eduacativo\datos_guardados\datos.txt ", false);
                txt.WriteLine(padreOrignal.nombrep+"");
                txt.WriteLine(padreOrignal.apellidop);
                txt.WriteLine(padreOrignal.sexop);
                txt.WriteLine(padreOrignal.edadp);
                txt.WriteLine(padreOrignal.telefono);

                txt.WriteLine(alumnoOrignal.nombreA);
                txt.WriteLine(alumnoOrignal.apellidoA);
                txt.WriteLine(alumnoOrignal.sexoA);
                txt.WriteLine(alumnoOrignal.edadA);
                txt.WriteLine(alumnoOrignal.gradoA);
                txt.WriteLine( alumnoOrignal.datos.nombrep = padreOrignal.nombrep);
                txt.WriteLine(alumnoOrignal.datos.telefono = padreOrignal.telefono);


                txt.WriteLine(padreClon1.nombrep);
                txt.WriteLine(padreClon1.apellidop);
                txt.WriteLine(padreClon1.sexop);
                txt.WriteLine(padreClon1.edadp);
                txt.WriteLine(padreClon1.telefono);

                txt.WriteLine(alumnoclon1.nombreA);
                txt.WriteLine(alumnoclon1.apellidoA);
                txt.WriteLine(alumnoclon1.sexoA);
                txt.WriteLine(alumnoclon1.edadA);
                txt.WriteLine(alumnoclon1.gradoA);
                txt.WriteLine(alumnoclon1.datos.nombrep = padreClon1.nombrep);
                txt.WriteLine(alumnoclon1.datos.telefono = padreClon1.telefono);
   
               txt.WriteLine(padreClon2.nombrep);
               txt.WriteLine(padreClon2.apellidop);
               txt.WriteLine(padreClon2.sexop);
               txt.WriteLine(padreClon2.edadp);
               txt.WriteLine(padreClon2.telefono);

               txt.WriteLine(alumnoclon2.nombreA);
               txt.WriteLine(alumnoclon2.apellidoA);
               txt.WriteLine(alumnoclon2.sexoA);
               txt.WriteLine(alumnoclon2.edadA);
               txt.WriteLine(alumnoclon2.gradoA);
               txt.WriteLine(alumnoclon2.datos.nombrep = padreClon2.nombrep);
               txt.WriteLine(alumnoclon2.datos.telefono = padreClon2.telefono);

               txt.WriteLine(padreClon3.nombrep);
                txt.WriteLine(padreClon3.apellidop);
                txt.WriteLine(padreClon3.sexop);
                txt.WriteLine(padreClon3.edadp);
                txt.WriteLine(padreClon3.telefono);

                txt.WriteLine(alumnoclon3.nombreA);
                txt.WriteLine(alumnoclon3.apellidoA);
                txt.WriteLine(alumnoclon3.sexoA);
                txt.WriteLine(alumnoclon3.edadA);
                txt.WriteLine(alumnoclon3.gradoA);
                txt.WriteLine(alumnoclon3.datos.nombrep = padreClon3.nombrep);
                txt.WriteLine(alumnoclon3.datos.telefono = padreClon3.telefono);
                 txt.Close();//Cierre de archivo....
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
