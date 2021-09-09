using System;
using System.Collections.Generic;
using System.Text;

namespace Centro_Eduacativo
{
    public class Padre: ICloneable
    {
        //Atributos y sus metodos getters y setters
        public String nombrep { get; set; }
        public String apellidop { get; set; }
        public String sexop { get; set; }
        public int edadp { get; set; }
        public double telefono { get; set; }


        //private static Padre padre; //Instancia de la clase

        ////Implementacion del Singleton....
        //public static Padre getInstance()
        //{
        //    //Este condicional evaluara si existe una instancia de la clase Impresora
        //    if (null == padre) //Si es null, es decir, que no existe...

        //        padre = new Padre(); //Pues, procedera a crear una

        //    return padre;//Aqui se retorna la instancia ya sea creada o ya existente
        //}


        //Constructor de la clase...
        public Padre(){}

        //Metodo inscribir 
        public void Inscribir()
        {
            Console.WriteLine("Inscripto");
        }

        public void Desincribir()
        {
            Console.WriteLine("Cancelar inscripcion ._.");

        }

        public override string ToString()
        {
            return $"Nombre: {nombrep} \n Apellido: {apellidop} \n Sexo: {sexop} \n Edad: {edadp} " +
                $"\n Telefono: {telefono}";
        }

        public object Clone()
        {
            return (Padre)this.MemberwiseClone();
        }
    }
}
