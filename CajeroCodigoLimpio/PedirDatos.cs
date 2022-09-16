using System;

namespace CajeroCoodigoLimpio
{
    internal class PedirDatos
    {
        public PedirDatos()
        { 

        }
        public void solicitarNIP()  
        {
            int NIP = 1234; 
           
            for (int intentosNIP = 0; intentosNIP <= 3;)
            
            {  
                Console.Clear();
                Console.WriteLine("Ingresar tu tarjeta y NIP");
                NIP = int.Parse(Console.ReadLine());
                if (NIP == 1234)
                {
                    Console.Clear();
                    intentosNIP = 5;
                }
                if (NIP != 1234)
                {
                    Console.Clear();
                    Console.WriteLine("NIP incorrecto, intentelo denuevo");
                    intentosNIP++;
                }
                if (intentosNIP == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Haz superado tus intentos, regresa en una hora");
                    Environment.Exit(0);
                }
            }
        }
        operaciones opcion = new operaciones();
        public int Operaciones()
        {
            string OperacionRealizar, RealizarOtraOperacion;
            int  MontoTransaccion = 0, SaldoDisponibleCartera = 2500, SaldoNuevoCartera = 0, CuentaReferenciaEnvio;
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccionar operacion a realizar");
                Console.WriteLine("1 consulta saldo");
                Console.WriteLine("2 retira efectivo");
                Console.WriteLine("3 deposito");
                OperacionRealizar = Console.ReadLine();

                switch (OperacionRealizar)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Consulta de saldo");
                        SaldoNuevoCartera = opcion.OperacionSaldoDisponible(SaldoDisponibleCartera);
                        Console.WriteLine("Tu cartera: $ {0}", SaldoNuevoCartera);
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("dinero a retira");
                        MontoTransaccion = int.Parse(Console.ReadLine());
                        SaldoNuevoCartera = opcion.OperacionRetiroEfectivo(MontoTransaccion, SaldoDisponibleCartera);
                        Console.WriteLine("Transaccion exitosa su saldo es: ${0} ", SaldoNuevoCartera);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("dinero a depositar");
                        MontoTransaccion = int.Parse(Console.ReadLine());
                        Console.WriteLine("Numero de cuenta a depositar");
                        CuentaReferenciaEnvio = int.Parse(Console.ReadLine());
                        SaldoNuevoCartera = opcion.OperacionDepositoCuentas(MontoTransaccion, SaldoDisponibleCartera);
                        Console.WriteLine("Transaccion exitosa deposito a la cuenta: ", CuentaReferenciaEnvio);
                        Console.WriteLine("su saldo es de: ${0}", SaldoNuevoCartera);
                        break;
                    default:
                        Console.WriteLine("Operacion no encontrada.");
                        break;
                }
                Console.WriteLine("Desea realizar otra operacion");
                RealizarOtraOperacion = Console.ReadLine();
            } while (RealizarOtraOperacion == "si" || RealizarOtraOperacion == "SI");
            return SaldoDisponibleCartera;

        }
        public void despedir()
        {
            Console.Clear();
            Console.WriteLine("gracias por usar el cajero");
        }
    }
}
