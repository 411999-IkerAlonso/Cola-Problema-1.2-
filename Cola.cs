using Problema_1._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._2
{
    public class Cola : IColleccion
    {
        public List<object> objetos { get; set; }
        public int Contador { get; set; }
        public Cola()
        {
            objetos = new List<object>();
            Contador = 0;
        }
        public bool Añadir(object objeto)
        {
            objetos.Add(objeto);
            Contador++;
            return true;
        }

        public bool EstaVacia()
        {
            if(objetos.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Extraer()
        {
            object primero = objetos.First();
            if(!EstaVacia())
            {
                objetos.Remove(objetos.First());
            }
            return primero;
        }

        public object Primero()
        {
            return objetos.First(); 
        }
    }
}
