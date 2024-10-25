/*
 *      Clase Usuario
 * 
 * Fehca inicial: 24/10/2024
 * Realizado por: Roberto Ortiz
 * Contacto: roberto.ortizrodriguez99@gmail.com
 * 
 * Fecha de modificación: 24/10/2024
 * Modifico: [Nombre y contacto]
 */

namespace SistemaNoticias.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Tipo_Usuario { get; set; } // Cambiado para reflejar el nombre de la columna
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
    }
}
