using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Models
{
    public partial class TipoPreguntum
    {
        public int Id { get; set; }
        public string Tipo { get; set; }=null!;
        public string? Descripcion { get; set; }
        public virtual ICollection<Preguntum> Pregunta { get; set; }=new List <Preguntum>();
    }
}
