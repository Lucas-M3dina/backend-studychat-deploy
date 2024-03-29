﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi_Robotica.Domains
{
    public partial class Professor
    {
        public int IdProfessor { get; set; }
        public int? IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Materia { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
