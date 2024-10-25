/*
 *      Clase Personal
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
    public class Personal
    {
        public int IdPersonal { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaDeIngreso { get; set; }
    }
}
