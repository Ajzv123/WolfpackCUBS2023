﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Models
{
    public partial class Encuestum
    {
        public int Id { get; set; }
        public string NombreEncuesta { get; set; }=null!;
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaExpiracion { get; set; }
        public int IdRegion { get; set; }
        public virtual Region IdRegionNavigation { get; set; }=null!;
        public virtual ICollection<Preguntum> Pregunta { get; set; }=new List <Preguntum>();
    }
}
