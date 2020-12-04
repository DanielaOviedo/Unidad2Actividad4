using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidad2Practica4.Models
{
    public class ReticulaViewModel
    {
        public string Nombre { get; set; }
        public string Plan { get; set; }
        public int Creditos { get; set; }
        public IEnumerable<Materias>[] Materias { get; set; }
    }
}
