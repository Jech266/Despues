using System;

namespace CajeroCoodigoLimpio
{
    internal class operaciones
    {
        
        public operaciones()
        {

        }
        public int OperacionSaldoDisponible(int cartera)
        {
            return cartera;
        }
        public int OperacionRetiroEfectivo(int monto, int cartera)
        {
            cartera = cartera - monto;
            return cartera;
        }
        public int OperacionDepositoCuentas(int monto, int cartera)
        {
            cartera = cartera - monto;
            return cartera;
        }
    }
}
