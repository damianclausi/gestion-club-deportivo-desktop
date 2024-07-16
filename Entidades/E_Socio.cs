using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
     class E_Socio : E_Cliente
    {
        public int IdClienteSocio { get => IdCliente; set => IdCliente = value; }      
        
        public string NombreSocio { get => Nombre; set => Nombre = value; }
        public int DniSocio { get => Dni; set => Dni = value; }
        public string DireccionSocio { get => Direccion; set => Direccion = value; }
        public DateTime FechaNacimientoSocio { get => FechaNacimiento; set => FechaNacimiento = value; }
        public DateTime FechaAltaSocio { get => FechaAlta; set => FechaAlta = value; }   
        public int IdCarnet { get; set; }
        public bool FichaMedicaSocio { get => FichaMedica; set => FichaMedica = value; }
    }
}
