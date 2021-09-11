using SolicitudPermisos.Application.UseCases;
using SolicitudPermisos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SolicitudPermisos.Api.Controllers
{
    public class PermisosController : ApiController
    {

        readonly SolicitudPermisosUseCase _solicitudPermisosUseCase;

        public PermisosController()
        {
            _solicitudPermisosUseCase = new SolicitudPermisosUseCase();
        }


        public List<PermisosModel> Get() {
            return _solicitudPermisosUseCase.ObtenerListaDePermisos();
        }

        [HttpGet]
        public PermisosModel Search(int id = 0)
        {
            return _solicitudPermisosUseCase.ObtenerRegistroDePermiso(id);
        }

        [HttpGet]
        public IHttpActionResult Insert(string nombre, string apellidos, int tipo, DateTime fecha)
        {
            var nuevoRegistro = new PermisosModel()
            {
                nombre = nombre,
                apellidos = apellidos,
                tipo_id = tipo,
                fecha = fecha
            };
            _solicitudPermisosUseCase.InsertarNuevoPermiso(nuevoRegistro);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Edit(int id, string nombre, string apellidos, int tipo, DateTime fecha)
        {
            var actualizarRegistro = new PermisosModel()
            {
                id = id,
                nombre = nombre,
                apellidos = apellidos,
                tipo_id = tipo,
                fecha = fecha
            };

            _solicitudPermisosUseCase.ActualizarPermiso(actualizarRegistro);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Delete(int id = 0)
        {
            _solicitudPermisosUseCase.EliminarPermiso(id);
            return Ok();
        }

    }
}
