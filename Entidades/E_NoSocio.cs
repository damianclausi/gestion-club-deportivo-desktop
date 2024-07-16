using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
     class E_NoSocio : E_Cliente
    {
        public int IdClienteNoSocio { get => IdCliente; set => IdCliente = value; }
     
        public string NombreNoSocio { get => Nombre; set => Nombre = value; }
        public int DniNoSocio { get => Dni; set => Dni = value; }
        public string DireccionNoSocio { get => Direccion; set => Direccion = value; }
        public DateTime FechaNacimientoNoSocio { get => FechaNacimiento; set => FechaNacimiento = value; }
        public DateTime FechaAltaNoSocio { get => FechaAlta; set => FechaAlta = value; }
        public bool FichaMedicaNoSocio { get => FichaMedica; set => FichaMedica = value; }
    }
}
