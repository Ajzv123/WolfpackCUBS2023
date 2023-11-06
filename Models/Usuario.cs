using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }=null!;
        public string ApellidoPaterno { get; set; }=null!;
        public string ApellidoMaterno { get; set; }=null!;
        public string? NumeroTelefono { get; set; }
        public string? Nss { get; set; }
        public string Correo { get; set; }=null!;
        public string Password { get; set; }=null!;
        public DateTime? FechaNacimiento { get; set; }
        public int IdTipoUsuario { get; set; }
        public int IdRegion { get; set; }
        public virtual Region IdRegionNavigation { get; set; }=null!;
        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }=null!;
        public virtual ICollection<Respuestum> Respuesta { get; set; }=new List <Respuestum>();
    } 
}
