﻿using Entidades;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;
using System.Linq;
namespace Datos
{
    public class DatosInstitucion : ICrud<t_Institucion>
    {
        public bool eliminar(t_Institucion e)
        {
            //throw new NotImplementedException();
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.Entry<t_Institucion>(e).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool guardar(t_Institucion e)
        {
            using (var db = new BD_JuntasEntities())
            {
                try
                {
                    db.t_Institucion.Add(e);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public bool modificar(t_Institucion e)
        {
            //throw new NotImplementedException();
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.Entry<t_Institucion>(e).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public t_Institucion obtenerPorId(t_Institucion e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    IQueryable<t_Institucion> consulta = (IQueryable<t_Institucion>)db.t_Institucion.Find(e.Codigo);
                    if (consulta != null)
                    {
                        return (t_Institucion)consulta;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public IEnumerable<t_Institucion> obtenerTodo(t_Institucion e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    IQueryable<t_Institucion> consulta = (IQueryable<t_Institucion>)db.t_Institucion.ToList();
                    if (consulta != null)
                    {
                        return consulta;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
