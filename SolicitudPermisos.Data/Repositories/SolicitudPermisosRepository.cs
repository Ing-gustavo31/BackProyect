using SolicitudPermisos.Data.Contexts;
using SolicitudPermisos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudPermisos.Data.Repositories
{
    public class SolicitudPermisosRepository : ISolicitudPermisosRepository
    {
        readonly PermisosContext permisoContext;

        public SolicitudPermisosRepository()
        {
            permisoContext = new PermisosContext();
        }


        

    }
}
