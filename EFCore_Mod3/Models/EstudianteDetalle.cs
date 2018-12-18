using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Mod3.Models
{
    public class EstudianteDetalle
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public int EstudianteId { get; set; }
    }
}
