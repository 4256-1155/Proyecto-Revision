//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_EntregaCasos
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public int Recepcion { get; set; }
        public int Id_Caso { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public string Observacion { get; set; }
        public int Pago { get; set; }
    
        public virtual t_Mensajero t_Mensajero { get; set; }
        public virtual t_Revision t_Revision { get; set; }
        public virtual t_Recepcion t_Recepcion { get; set; }
    }
}
