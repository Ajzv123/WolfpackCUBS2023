using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Models
{
    public partial class Region 
    {
        public int Id { get; set; }
        public string NombreRegion { get; set; }=null!;
        public virtual ICollection<Usuario> Usuarios { get; set; }=new List <Usuario>();
        public virtual ICollection<Encuestum> Encuesta { get; set; }=new List <Encuestum>();
    } 
}
