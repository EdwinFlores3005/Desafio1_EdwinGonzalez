using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1_EdwinGonzalez
{
    internal class ArbolSistemaArchivos
    {
        //Se crea el archivo Root y se define como carpeta
        public NodoArchivo Root { get; set; }

        public ArbolSistemaArchivos()
        {
            Root = new NodoArchivo("Root", "carpeta");
        }

        //Agregar Nodo
        public void AgregarNodo(NodoArchivo root, string name, string type)
        {
           
                NodoArchivo newNode = new NodoArchivo(name, type);
                newNode.Padre = root;
                root.hijos.Add(newNode);
        }

        //Buscar nodo

        public NodoArchivo BuscarNodo(NodoArchivo nodo, string name)
        {
            if (nodo.nombre == name)
            {
                return nodo;
            }
             else
            {
                foreach(var hijo  in nodo.hijos)
                {
                    var encontrado = BuscarNodo(hijo, name);
                    if (encontrado != null)
                        return encontrado;
                }
            }
            return null;
        }

        //Crear Ruta
        public string Ruta(NodoArchivo nodo)
        {

            if (nodo == null)
                return "";

            if (nodo.Padre == null)
                return "/" + nodo.nombre;

            return Ruta(nodo.Padre) + "/" + nodo.nombre;
        }

        //Para BuscarNodo y Ruta se uso recursividad para recorrer cada lista de cada nodo que es carpeta
    }
}
