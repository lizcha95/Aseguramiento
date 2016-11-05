using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPreguntas
{
    public class Juego
    {
        // Funciones que revisan el archivo y su consistencia

        // Revisa si el archivo existe en la directorio
        public bool verificarArchivoExiste(string archivo)  
        {
            throw new NotImplementedException();
        }

        public bool verificarExtension(string archivo)
        {
            throw new NotImplementedException();
        }
        public void leerArchivo(string nombreArchivo)
        {
            throw new NotImplementedException();
        }
        public bool verificarTamanoNombreArchivo()
        {
            throw new NotImplementedException();
        }
        public bool verificarTamanoArchivo(string archivo)
        {
            throw new NotImplementedException();
        }

        // Funciones que verifican que la estructura de las preguntas esté correcta
        public bool verificarEstructuraPreguntas(string archivo)
        {
            throw new NotImplementedException();
        }
        public int cantidadPreguntas()
        {
            throw new NotImplementedException();
        }

        // Funciones de interacción del usuario con 
        public bool verificarNumIngresado(int num)
        {
            throw new NotImplementedException();
        }
        public void eliminarPregunta(int idPregunta) 
        {
            throw new NotImplementedException();
        }
        public void editarPregunta(int idPregunta, Juego pregunta)
        {
            throw new NotImplementedException();
        }
        public void agregarPregunta(Juego pregunta)
        {
            throw new NotImplementedException();
        }
        public bool verificarPreguntaExiste(int idPregunta)
        {
            throw new NotImplementedException();
        }
        public int sumarPuntaje()
        {
            throw new NotImplementedException();
        }
        public int restarPuntaje()
        {
            throw new NotImplementedException();
        }
        public bool verificarRespuesta(int idPregunta, int respuesta)
        {
            throw new NotImplementedException();
        }
        public int incrementarDificultad()
        {
            throw new NotImplementedException();
        }

    }
}
