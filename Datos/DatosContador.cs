using Entidades;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;
using System.Linq;
namespace Datos
{
    //
    public class DatosContador : ICrud<t_Persona>
    {
        public bool eliminar(t_Persona e)
        {
            //throw new NotImplementedException();
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.Entry<t_Persona>(e).State = System.Data.Entity.EntityState.Modified;
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



        //Metodo de Guardar un contador
        public bool guardar(t_Persona e)
        {
            using (var db = new BD_JuntasEntities())
            {
                try
                {
                    db.t_Persona.Add(e);
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



        public bool modificar(t_Persona e)
        {
            //throw new NotImplementedException();
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    db.Entry<t_Persona>(e).State = System.Data.Entity.EntityState.Modified;
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



        //Metodo de obtener contador por cedula
        public t_Persona obtenerPorId(t_Persona e)
        {
            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    return (from query in db.t_Persona where query.Cedula == e.Cedula select query).FirstOrDefault();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }



        //Metodo que para obtener la lista de los contadores
        public IEnumerable<t_Persona> obtenerTodo(t_Persona e)
        {

            try
            {
                using (var db = new BD_JuntasEntities())
                {
                    return (from query in db.t_Persona select query).ToList();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public int CantidadContadores()
        {
            return obtenerTodo(new t_Persona()).Count();
        }
    }
}
