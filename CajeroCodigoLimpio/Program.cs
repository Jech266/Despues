using System;

namespace CajeroCoodigoLimpio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PedirDatos seccion = new PedirDatos();

            seccion.solicitarNIP();

            seccion.Operaciones();

            seccion.despedir();

        }
    }
}
