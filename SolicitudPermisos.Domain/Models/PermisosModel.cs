using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudPermisos.Domain.Models
{
    public class PermisosModel
    {
        public int ? id { get; set; }
        public int tipo_id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string tipo { get; set; }
        public DateTime ? fecha { get; set; }
    }
}
