using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clase20_08
{
    public class Pila : ICollection

    {  
        public int contador { get; set; }
        object[] elementos = new Object[0];
        int tamaño = 0;
     
        public Pila(int tamaño)
        {
            elementos = new object[tamaño];
            contador = 0;
        }

        public bool añadir(object objeto)
        {

            if (objeto[] = null)
            {
                return false;
            }
            else
            {
                elementos[contador] = objeto;
                contador++;
                return true;
            }
          
        }

        public bool estaVacia()
        {
          if (elementos.Length == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public object extraer()
        {
            contador = 0;
            Object primerElemento = elementos [contador];
            return primerElemento;
            primerElemento = null;
            contador ++; 
        }

        public object primero()
        {
            contador = 0;
            Object primerElemento = elementos[contador];
            return primerElemento;
            
        }
    }
}
