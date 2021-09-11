using SolicitudPermisos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudPermisos.Domain.Interfaces
{
    public interface ISolicitudPermisosRepository
    {
        List<TipoPermisosModel> CatalogoDePermisos();
        List<PermisosModel> ListaDePermisos();
        PermisosModel RegistroDePermiso(int id = 0);
        void InsertarPermiso(PermisosModel nuevoRegistro = null);
        void ActualizarPermiso(PermisosModel registro = null);
        void EliminarPermiso(int id = 0);
    }
}
