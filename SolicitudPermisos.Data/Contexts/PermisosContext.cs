using SolicitudPermisos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudPermisos.Data.Contexts
{
    public class PermisosContext : DbContext
    {
        public PermisosContext() : base("name=ConnectionDefault")
        {

        }

        DbSet<Permiso> Permisos { get; set; }
        DbSet<TipoPermiso> TipoPermisos { get; set; }
    }
}
