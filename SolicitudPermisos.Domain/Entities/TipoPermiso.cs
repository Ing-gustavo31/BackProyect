using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudPermisos.Domain.Entities
{
    [Table("TipoPermiso")]
    public class TipoPermiso
    {
        [Key]
        [Column("tp_id")]
        public int id { get; set; }
        
        [Column("tp_descripcion")]
        public string descripcion { get; set; }
    }
}
