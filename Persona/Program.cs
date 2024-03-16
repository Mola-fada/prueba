using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    internal class Program
    {
        
    static void Main(string[] args)
        {
            Persona1 per = new Persona1("", new DateTime(), "", "", "", 0, 0);

            Console.WriteLine("Nombre: " + per.Nombre);
            Console.WriteLine("Sexo: " + per.Sexo);
            Console.WriteLine("Color de piel: " + per.ColorPiel);
            Console.WriteLine("Color de ojos: " + per.ColorOjos);
            Console.WriteLine("Estatura: " + per.Estatura + " Cm");
            Console.WriteLine("Peso: " + per.Peso + " Kg");

            bool salir = false;
                while(!salir){

                Console.WriteLine("Seleccione la Accion que desea realizar");
                Console.WriteLine("1.Comer");
                Console.WriteLine("2.Hablar");
                Console.WriteLine("3.Caminar");
                Console.WriteLine("4.Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        per.Comer();
                        break;
                    case "2":
                        per.Hablar();
                        break;
                    case "3":
                        per.Caminar();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Digite una opcion valida");
                        break;
                }

            }
            




        }
    }


}


