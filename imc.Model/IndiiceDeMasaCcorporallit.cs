using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc.Model
{
    public static class IndiiceDeMasaCcorporallit
    {
        public static decimal IndiceDeMasaCorporal(decimal peso, decimal estatura)
        {
            return peso / (estatura * estatura);
        }
        public static string DeterminaEstadoNutericional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return "peso bajo";
            }
            if (imc < 25.00m)
            {
                return "peso normal";
            }
            if (imc < 30m)
            {
                return "sobre peso";
            }
            if (imc < 40)
            {
                return "Obesidad";
            }
            return "Obesidad extrema";




        }







    }
}
