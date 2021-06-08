using System;
using System.Collections.Generic;
using System;

namespace JAAB2021YExamen3EV_NS
{
    public class EstadisticaNotas  // esta clase nos calcula las estadísticas de un conjunto de notas 
    {
        private int suspensos;  // Suspensos
        private int aprobados;  // Aprobados
        private int notables;  // Notables
        private int sobresalientes;  // Sobresalientes

        public double notamedia; // Nota media

       
        public int Suspensos
        {
            get => suspensos;
            set
            {
                if (suspensos < 5)
                {
                    suspensos = value;
                }
                else
                {
                    throw new Exception("Nota no válida");
                }

            }
        }
        public int Aprobados
        {
            get => aprobados;
            set
            {
                if (aprobados >= 5)
                {
                    aprobados = value;
                }
                else
                {
                    throw new Exception("Nota no válida");
                }

            }
        }
        public int Notables
        {
            get => notables;
            set
            {
                if (notables >=7  )
                {
                    notables = value;
                }
                else
                {
                    throw new Exception("Nota no válida");
                }

            }
        }

        public int Sobresalientes 
        {
            get => sobresalientes;
            set
            {
                if (sobresalientes >= 9)
                {
                    sobresalientes = value;
                }
                else
                {
                    throw new Exception("Nota no válida");
                }

            }
        }

       

        // Constructor vacío
        public EstadisticaNotas()
        {
            Suspensos = Aprobados = Notables = Sobresalientes = 0;  // inicializamos las variables
            notamedia = 0.0;
        }

        // Constructor a partir de un array, calcula las estadísticas al crear el objeto
        private EstadisticaNotas(List<int> listanotas)
        {
            CrearEstadisticadeNotas(listanotas);
        }
        /// <summary>
        /// Clase que crea la estadisticas de notas de una lista pasada por parámetro
        /// </summary>
        /// <param name="listanotas"></param>
        
        
        public void CrearEstadisticadeNotas(List<int> listanotas)
        {
            notamedia = 0.0;

            for (int i = 0; i < listanotas.Count; i++)
            {
                if (listanotas[i] < 5) Suspensos++;              // Por debajo de 5 suspenso
                else if (listanotas[i] > 5 && listanotas[i] < 7) Aprobados++;// Nota para aprobar: 5
                else if (listanotas[i] > 7 && listanotas[i] < 9) Notables++;// Nota para notable: 7
                else if (listanotas[i] > 9) Sobresalientes++;         // Nota para sobresaliente: 9

                notamedia = notamedia + listanotas[i];
            }

            notamedia = notamedia / listanotas.Count;
        }


        // Para un conjunto de listnot, calculamos las estadísticas
        // calcula la media y el número de suspensos/aprobados/notables/sobresalientes
        //
        // El método devuelve -1 si ha habido algún problema, la media en caso contrario	
        public double CalcularEstadisticas(List<int> listnot)
        {                                 
            notamedia = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (listnot.Count <= 0)  // Si la lista no contiene elementos, devolvemos un error
                return -1;

            for (int i=0;i<10;i++)
                if (listnot[i] < 0 || listnot[i] > 10)      // comprobamos que las not están entre 0 y 10 (mínimo y máximo), si no, error
                return -1;

            for (int i = 0; i < listnot.Count; i++)
            {
                if (listnot[i] < 5) Suspensos++;              // Por debajo de 5 suspenso
                else if (listnot[i] >= 5 && listnot[i] < 7) Aprobados++;// Nota para aprobar: 5
                else if (listnot[i] >= 7 && listnot[i] < 9) Notables++;// Nota para notable: 7
                else if (listnot[i] > 9) Sobresalientes++;         // Nota para sobresaliente: 9

                notamedia = notamedia + listnot[i];
            }

            notamedia = notamedia / listnot.Count;

            return notamedia;
        }
    }
}
