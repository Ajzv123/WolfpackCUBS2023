using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Models
{
    public partial class TipoUsuario
    {
        public int Id { get; set; }
        public string Tipo { get; set; }=null!;
        public string? Descripcion { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }=new List <Usuario>();
    }
}
