using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Mpagos
    {

        public int id { get; set; }

        public string origen { get; set; }
        public string concepto { get; set; }
        public int monto { get; set; }
        public DateAndTime Fecha { get; set; }
        public string moneda{ get; set; }
        public decimal tipocambio { get; set; }








    }
}
