using SolicitudPermisos.Data.Contexts;
using SolicitudPermisos.Domain.Entities;
using SolicitudPermisos.Domain.Interfaces;
using SolicitudPermisos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SolicitudPermisos.Data.Repositories
{
    public class SolicitudPermisosRepository : ISolicitudPermisosRepository
    {
        readonly PermisosContext permisosContext;

        public SolicitudPermisosRepository()
        {
            permisosContext = new PermisosContext();
        }

        public List<TipoPermisosModel> CatalogoDePermisos()
        {
            try
            {
                var catalogo = (from t in permisosContext.TipoPermisos
                                select new TipoPermisosModel
                                {
                                    id = t.id,
                                    descripcion = t.descripcion
                                }).ToList();

                return catalogo;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public PermisosModel RegistroDePermiso(int id = 0)
        {
            try
            {
                var permiso = (from p in permisosContext.Permisos
                                join t in permisosContext.TipoPermisos
                                on p.tipo equals t.id
                                where p.id == id
                                select new PermisosModel
                                {
                                    id = p.id,
                                    nombre = p.nombre,
                                    apellidos = p.apellidos,
                                    tipo = t.descripcion,
                                    tipo_id = t.id,
                                    fecha = p.fecha
                                }).FirstOrDefault();

                return permiso;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<PermisosModel> ListaDePermisos()
        {
            try
            {
                var permisos = (from p in permisosContext.Permisos
                               join t in permisosContext.TipoPermisos
                               on p.tipo equals t.id

                               select new PermisosModel
                               {
                                   id = p.id,
                                   nombre = p.nombre,
                                   apellidos = p.apellidos,
                                   tipo = t.descripcion,
                                   fecha = p.fecha
                               }).ToList();

                return permisos;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public void InsertarPermiso(PermisosModel nuevoRegistro = null)
        {
            try
            {
                var nuevoPermiso = new Permiso()
                {
                    nombre = nuevoRegistro.nombre,
                    apellidos = nuevoRegistro.apellidos,
                    tipo = nuevoRegistro.tipo_id,
                    fecha = nuevoRegistro.fecha
                };

                permisosContext.Permisos.Add(nuevoPermiso);
                permisosContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void ActualizarPermiso(PermisosModel registro = null)
        {
            try
            {
                var permiso = permisosContext.Permisos.Find(registro.id);


                permiso.nombre = registro.nombre;
                permiso.apellidos = registro.apellidos;
                permiso.tipo = registro.tipo_id;
                permiso.fecha = registro.fecha;
                
                permisosContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void EliminarPermiso(int id = 0)
        {
            try
            {
                var permiso = permisosContext.Permisos.Find(id);

                permisosContext.Permisos.Remove(permiso);
                permisosContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
