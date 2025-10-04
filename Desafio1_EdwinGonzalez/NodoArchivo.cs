using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1_EdwinGonzalez
{
    internal class NodoArchivo
    {
        //Variables para cada archivo o carpeta
        public string nombre { set; get; }
        public string tipo { set; get; }
        //Lista que contiene cada archivo dentro de una carpeta
        public List<NodoArchivo> hijos { set; get; }
        //NodoArchivo que se conecta con la carpeta padre
        public NodoArchivo Padre { get; set; }

        public NodoArchivo(string nombre, string tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            hijos = new List<NodoArchivo>();
        }

        //Funcion para comprobar que es una carpeta
        public bool carpeta()
        {
            return this.tipo.ToLower() == "carpeta";
        }
    }
}
