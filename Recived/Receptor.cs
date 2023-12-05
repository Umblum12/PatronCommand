using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCommand.Recived
{
    public class Receptor
    {
        public void MayusculasActivadas(bool mayus, char tecla)
        {
            Console.WriteLine(
                mayus ? $"Receptor: La siguiente tecla sera {tecla} sera mayuscula"
                :
                "Receptor: (Mayus) no moy a interferir"
                );
        }
        public void NumLockActivado(bool numlock)
        {
            Console.WriteLine(
                numlock ? "El siguiuente numero de Numpad sera registrado"
                :
                "Receptor: (Numlock) no moy a interferir"
                );
        }
    }
}
