using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jornadas.Models.ViewModels
{
    public class ListJornadaViewModel
    {
        public int id { get; set; }
        public int jornada { get; set; }
        public string equipoLocal { get; set; }
        public string equipoVisitante { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public string Resultado { get; set; }
        public char empate { get; set; }
        public string colocada { get; set; }
        public decimal LineaDinero { get; set; }
        public string Momio { get; set; }
        public decimal Ganancia { get; set; }
        public decimal GananciaTotal { get; set; }
    }
}