using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudPermisos.Domain.Entities
{
    [Table("Permiso")]
    public class Permiso
    {
        [Key]
        [Column("p_id")]
        public int id { get; set; }

        [Column("p_nombre")]
        public string nombre { get; set; }

        [Column("p_apellidos")]
        public string apellidos { get; set; }

        [Column("p_tipo")]
        public byte tipo { get; set; }

        [Column("p_fecha")]
        public DateTime fecha { get; set; }
    }
}
