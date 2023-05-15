using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion02PatronesDeDiseño
{
    class TarjetaPago
    {
        public virtual void pagaCompra(int importe)
        {

        }

        public virtual bool autorizaPago(int importe)
        {
            return false;
        }
    }
}
