﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Entidades;
    public partial class BD_JuntasEntities : DbContext
    {
        public BD_JuntasEntities()
            : base("name=BD_JuntasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<t_Boleta> t_Boleta { get; set; }
        public virtual DbSet<t_Direccion_Regional> t_Direccion_Regional { get; set; }
        public virtual DbSet<t_EntregaCasos> t_EntregaCasos { get; set; }
        public virtual DbSet<t_Institucion> t_Institucion { get; set; }
        public virtual DbSet<t_Mensajeria> t_Mensajeria { get; set; }
        public virtual DbSet<t_Persona> t_Persona { get; set; }
        public virtual DbSet<t_Recepcion> t_Recepcion { get; set; }
        public virtual DbSet<t_Revision> t_Revision { get; set; }
        public virtual DbSet<t_Tipo_Institucion> t_Tipo_Institucion { get; set; }
        public virtual DbSet<t_Trabajador> t_Trabajador { get; set; }
        public virtual DbSet<t_Usuario> t_Usuario { get; set; }
    }
}
