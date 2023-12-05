using PatronCommand.Command.Interfaces;
using PatronCommand.Recived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCommand.Command
{
    public class ComandoComplejo : IComando
    {
        private bool _mayus, _numlock;
        private Receptor _receptor;
        public ComandoComplejo(bool mayus, bool numlock, Receptor receptor)
        {
            _mayus = mayus;
            _numlock = numlock;
            _receptor = receptor;
        }


        public void Ejecutar()
        {
            Console.WriteLine($"Comando complejo: Introduzca la tecla presionada...");
            char keycap = Console.ReadLine().FirstOrDefault();
            Console.WriteLine($"Comando complejo: Vamos a ver si la tecla {keycap} sera afectada");
            _receptor.MayusculasActivadas(_mayus, keycap);
            this._receptor.NumLockActivado(_numlock);
        }
    }
}
