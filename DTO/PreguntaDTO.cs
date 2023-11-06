using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModels.Models;

namespace LibraryModels.DTO
{
    public class PreguntaDTO
    {
        public string Pregunta { get; set; }=null!;
        public int IdTipoPregunta { get; set; }
        public int IdCategoria { get; set; }
        public int IdEncuesta { get; set; }
        public static PreguntaDTO PreguntaToDTO(Preguntum pregunta)
        {
            return new PreguntaDTO
            {
                Pregunta = pregunta.Pregunta,
                IdTipoPregunta = pregunta.IdTipoPregunta,
                IdCategoria = pregunta.IdCategoria,
                IdEncuesta = pregunta.IdEncuesta
            };
        }
    }
}
