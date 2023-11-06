using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Models
{
    public partial class Respuestum
    {
        public int Id { get; set; }
        public string Respuesta { get; set; }=null!;
        public int IdPregunta { get; set; }
        public int IdUsuario { get; set; }
        public virtual Preguntum IdPreguntaNavigation { get; set; }=null!;
        public virtual Usuario IdUsuarioNavigation { get; set; }=null!;
    }
}
