using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIVERSIDAD.Modelos;

namespace Modelos
{
   public class Sesiones_Modelos
    {

        public int Id { get; set; }

        public MEmpleados Empleados { get; set; }

        public DateAndTime Inicio { get; set; }

        public DateAndTime fin { get; set; }

        public string Ip { get; set; }

        public string PCName { get; set; }
    }
}
