using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    abstract class E_Cliente

    {
        protected int IdCliente { get; set; }
        protected string Nombre { get; set; }
        protected string Direccion { get; set; }
        protected int Dni { get; set; }
        protected DateTime FechaNacimiento { get; set; }
        protected DateTime FechaAlta { get; set; }
        protected bool FichaMedica { get;set; }
    }
}
