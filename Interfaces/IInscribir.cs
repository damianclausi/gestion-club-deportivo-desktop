using ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Interfaces
{
    internal interface IInscribir<T>// definir una interfaz genérica que acepte un parámetro de tipo genérico.
    {
        string Inscribir(T Cliente);
        // Esto permite que cada implementación especifique el tipo de parámetro que necesita.
    }
}
