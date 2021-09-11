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
    public class CatalogoController : ApiController
    {

        public List<TipoPermisosModel> Get()
        {
            return new SolicitudPermisosUseCase().ObtenerCatalogoDeTiposDePermiso();
        }
    }
}
