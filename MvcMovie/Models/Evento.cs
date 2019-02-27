using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Evento
    {
        [Key]
        public string solicitud { get; set; }

        public string tipoEvento { get; set; }
        public string lugar { get; set; }
        public int invitados { get; set; }
        public string detalles { get; set; }

    }
}
