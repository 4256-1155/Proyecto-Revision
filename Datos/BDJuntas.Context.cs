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
    public partial class BDJuntasEntities : DbContext
    {
        public BDJuntasEntities()
            : base("name=BDJuntasEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<tBoleta> tBoleta { get; set; }
        public virtual DbSet<tEntregaCasos> tEntregaCasos { get; set; }
        public virtual DbSet<tEstado> tEstado { get; set; }
        public virtual DbSet<tInstitucion> tInstitucion { get; set; }
        public virtual DbSet<tMensajero> tMensajero { get; set; }
        public virtual DbSet<tPersona> tPersona { get; set; }
        public virtual DbSet<tRecepcion> tRecepcion { get; set; }
        public virtual DbSet<tRevision> tRevision { get; set; }
        public virtual DbSet<tTipoInstitucion> tTipoInstitucion { get; set; }
        public virtual DbSet<tTrabajador> tTrabajador { get; set; }
        public virtual DbSet<tUsuario> tUsuario { get; set; }
        public virtual DbSet<viewBoleta> viewBoleta { get; set; }
        public virtual DbSet<viewCasosAsignados> viewCasosAsignados { get; set; }
        public virtual DbSet<viewContadores> viewContadores { get; set; }
        public virtual DbSet<viewEntregaCasos> viewEntregaCasos { get; set; }
        public virtual DbSet<viewJuntas> viewJuntas { get; set; }
        public virtual DbSet<viewTrabajador> viewTrabajador { get; set; }
    }
}
