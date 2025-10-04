using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1_EdwinGonzalez
{
    internal class NodoArchivo
    {
        public string nombre { set; get; }
        public string tipo { set; get; }
        public List<NodoArchivo> hijos { set; get; }
        public NodoArchivo Padre { get; set; }

        public NodoArchivo(string nombre, string tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            hijos = new List<NodoArchivo>();
        }

        public bool carpeta()
        {
            return this.tipo.ToLower() == "carpeta";
        }
    }
}
