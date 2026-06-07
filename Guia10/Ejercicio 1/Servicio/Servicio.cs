using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    internal class Servicio
    {
        #region DECLARAR CLASE RANDOM
        Random azar = new Random();
        #endregion

        #region GENERAR NUMERO RANDOM
        public int GenerarNumeroRandom()
        {
            int numeroRandom = azar.Next(1,101);
            return numeroRandom;
        #endregion
        }
    }
}