using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    public class Pruebas_Juego
    {
        public bool extensionValida(string nombreArchivo)
        {
            if (nombreArchivo.EndsWith(".txt"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool tamanoNombre(string nombreArchivo)
        {
            if (nombreArchivo.Length <= 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class mainJuego
    {
        static void Main(string[] args)
        {
        }
    }
}
