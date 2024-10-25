/*
 *      Clase RespuestaComentario
 * 
 * Fehca inicial: 24/10/2024
 * Realizado por: Roberto Ortiz
 * Contacto: roberto.ortizrodriguez99@gmail.com
 * 
 * Fecha de modificación: 24/10/2024
 * Modifico: [Nombre y contacto]
 */

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaNoticias.Models
{
    public class RespuestaComentario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRespuesta { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha_Respuesta { get; set; }

        public int IdComentario { get; set; }
        public Comentario? Comentario { get; set; }

        public int IdUsuario { get; set; }
        public Usuario? Usuario { get; set; }
    }

}
