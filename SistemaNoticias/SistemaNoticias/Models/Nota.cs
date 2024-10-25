/*
 *      Clase Nota
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
    public class Nota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNota { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha_Publicacion { get; set; } // Cambiado para reflejar el nombre de la columna
        public int IdPersonal { get; set; }
        public Personal Personal { get; set; }
    }
}