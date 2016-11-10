using Juego_Preguntas.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Interaccion i = new Interaccion();
            i.leerArchivo("C:\\Temp\\preguntas.csv");
            i.asignarPreguntasRandom(5);
        }
    }
}
