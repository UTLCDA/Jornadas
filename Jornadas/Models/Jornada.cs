//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jornadas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jornada
    {
        public int id { get; set; }
        public int IdLiga { get; set; }
        public int jornada1 { get; set; }
        public string equipoLocal { get; set; }
        public string equipoVisitante { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.TimeSpan> Hora { get; set; }
        public string Resultado { get; set; }
        public Nullable<bool> Empate { get; set; }
        public string Colocada { get; set; }
        public Nullable<decimal> LineaDinero { get; set; }
        public string Momio { get; set; }
        public Nullable<decimal> Ganancia { get; set; }
        public Nullable<decimal> GananciaTotal { get; set; }
    }
}
