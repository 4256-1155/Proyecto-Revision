﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace GestionCasos
{
    public static class DatosTemp
    {
        public static t_Revision t_Revision { get; set; }
        public static t_Persona t_Persona { get; set; }
        public static t_Institucion t_Institucion { get; set; }
        public static t_Boleta t_Boleta { get; set; }

        public static Form backForm { get; set; }
        public static Form Form { get; set; }
    }
}
