using SolicitudPermisos.Data.Repositories;
using SolicitudPermisos.Domain.Interfaces;
using SolicitudPermisos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudPermisos.Application.UseCases
{
    public class SolicitudPermisosUseCase
    {
        readonly ISolicitudPermisosRepository _solicitudPermisosRepository;

        public SolicitudPermisosUseCase()
        {
            _solicitudPermisosRepository = new SolicitudPermisosRepository();
        }

        public List<TipoPermisosModel> ObtenerCatalogoDeTiposDePermiso()
        {
            return _solicitudPermisosRepository.CatalogoDePermisos();
        }
        public List<PermisosModel> ObtenerListaDePermisos()
        {
            return _solicitudPermisosRepository.ListaDePermisos();
        }

        public PermisosModel ObtenerRegistroDePermiso(int id = 0)
        {
            return _solicitudPermisosRepository.RegistroDePermiso(id);
        }

        public void InsertarNuevoPermiso(PermisosModel nuevoRegistro = null)
        {
            _solicitudPermisosRepository.InsertarPermiso(nuevoRegistro);
        }

        public void ActualizarPermiso(PermisosModel nuevoRegistro = null)
        {
            _solicitudPermisosRepository.ActualizarPermiso(nuevoRegistro);
        }

        public void EliminarPermiso(int id = 0)
        {
            _solicitudPermisosRepository.EliminarPermiso(id);
        }

    }
}
