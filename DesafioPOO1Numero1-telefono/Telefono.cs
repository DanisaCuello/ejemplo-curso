using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO1Numero1_telefono
{
    internal class Telefono
    {
        //atributos
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperados;

        //constructor

        public Telefono (string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        //propiedades

        public string Modelo { get { return modelo; } }

        public string Marca { get { return marca; } }

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value;}
        }

       // public void setNumeroTelefonico (string nT)  { numeroTelefonico = nT; }
       // public string getNumeroTelefonico() { return numeroTelefonico; }

        

        public int  CodigoOperador
        {
            get { return codigoOperados;}
            set
            {
                if (value > 0 && value <= 3 )
                {
                    codigoOperados = value;
                }
                else
                {
                    codigoOperados = 0;
                }
            }
        }

        //metodo
        //public string llamar()
       // {
         //   return "Realizando llamada";

       // }

        //sobrecarga de metodo
        public string llamar(string contacto)
        {
            return "realizando llamada" + contacto;
        }

    }

}
