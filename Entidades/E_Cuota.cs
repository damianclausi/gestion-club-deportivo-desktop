using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Cuota
    {
        public int id { get; set; }
        public string Descripcion { get; set; }        
        public float Monto { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public DateTime FechaPago { get; set; }

    }
}
