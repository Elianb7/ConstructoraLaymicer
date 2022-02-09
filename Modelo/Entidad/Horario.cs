using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Modelo.Entidades
{
    public class Horario
    {
        public int HorarioId { get; set; }
        
        [DataType(DataType.Time)]
        public DateTime Hora_Inicio { get; set; }

        [DataType(DataType.Time)]
        public DateTime Hora_Fin { get; set; }
        public int Cupos_Totales { get; set; }

        public ICollection<Dia> Dias { get; set; }
    }
}