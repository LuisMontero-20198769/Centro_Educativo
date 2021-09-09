using System;
using System.Collections.Generic;
using System.Text;

namespace Centro_Eduacativo
{
    public class Alumno: ICloneable
    {
        //Atributos y sus metodos getters y setters
        public String nombreA { get; set; }
        public String apellidoA { get; set; }
        public String sexoA { get; set; }
        public int edadA { get; set; }
        public String gradoA { get; set; }

        


        //Constructor de la clase
        public Alumno() {}

        public void Clases()
        {
            Console.WriteLine("Estoy en clases...");
        }

        public void Receso()
        {
            Console.WriteLine("Jugando...");
        }

        public override string ToString()
        {
            return $"Nombre: {nombreA} \n Apellido: {apellidoA} \n Sexo: {sexoA} \n Edad: {edadA} " +
                $"\n Grado: {gradoA} \n Padre: {this.datos.nombrep} \n Telefono Padre: {this.datos.telefono}";
        }

        public Padre datos { get; set; }//Atributo del tipo Padre...

        public object Clone()
        {
            Alumno aluClonado = this.MemberwiseClone() as Alumno;
            Padre padre = new Padre();//Obejto de la clase Padre...
            padre.nombrep = this.datos.nombrep;
            padre.telefono = this.datos.telefono;
            aluClonado.datos = padre;
            return aluClonado;
        }
    }
    
}
