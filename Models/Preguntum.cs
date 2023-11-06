using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Models
{
    public partial class Preguntum
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }=null!;
        public int IdTipoPregunta { get; set; }
        public int IdCategoria { get; set; }
        public int IdEncuesta { get; set; }
        public virtual CategoriaPreguntum IdCategoriaNavigation { get; set; }=null!;
        public virtual Encuestum IdEncuestaNavigation { get; set; }=null!;
        public virtual TipoPreguntum IdTipoPreguntaNavigation { get; set; }=null!;
        public virtual ICollection<Respuestum> Respuesta { get; set; }=new List <Respuestum>();
    }
}
