using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DesafioPOO1Numero1_telefono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono telefono1 = new Telefono("redmi","xiaomi");
            //forma larga de cargar propiedades
            //telefono1.setNumeroTelefonico("2622444192");
            // Console.WriteLine("El numero de telefono es: " + telefono1.getNumeroTelefonico());
            //forma corta de cargar propiedades
            telefono1.NumeroTelefonico = "2622444192";
             Console.WriteLine("El numero de telefono es: " + telefono1.NumeroTelefonico);
            //metodo
            
            //Console.WriteLine(telefono1.llamar());
            //sobrecarga de metodo
            Console.WriteLine(telefono1.llamar("juan"));
            Console.ReadKey();


        }
    }
}
