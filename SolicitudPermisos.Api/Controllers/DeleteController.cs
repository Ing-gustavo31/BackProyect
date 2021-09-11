using SolicitudPermisos.Application.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SolicitudPermisos.Api.Controllers
{
    public class DeleteController : ApiController
    {
        readonly SolicitudPermisosUseCase _solicitudPermisosUseCase;

        public DeleteController()
        {
            _solicitudPermisosUseCase = new SolicitudPermisosUseCase();
        }

       

    }
}
