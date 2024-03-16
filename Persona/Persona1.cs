using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    internal class Persona1
    {
      
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string ColorPiel { get; set; }
        public string ColorOjos { get; set; }
        public double Estatura { get; set; }
        public double Peso { get; set; }
     


        public Persona1(string nombre, DateTime fechaNacimiento, string sexo, string colorPiel, string colorOjos, double estatura, double peso)
        {
            Console.WriteLine("Escriba el nombre de la Persona");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escriba la fecha de nacimiento(00-00-0000)");
            FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Escriba el Sexo");
            Sexo = Console.ReadLine();
            Console.WriteLine("Escriba el Color de Piel");
            ColorPiel = Console.ReadLine();
            Console.WriteLine("Escriba el Color de Ojos");

            ColorOjos = Console.ReadLine();
            Console.WriteLine("Escriba la Estatura");

            Estatura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el peso(0.00)");

            Peso = Convert.ToDouble(Console.ReadLine());

        }

        public void Comer()
        {
            Console.WriteLine(Nombre + " está comiendo.");
            
        }

        public void Hablar()
        {
            Console.WriteLine(Nombre + " está hablando.");
        }

        public void Caminar()
        {
            Console.WriteLine(Nombre + " está caminando.");
        }

    }
}

