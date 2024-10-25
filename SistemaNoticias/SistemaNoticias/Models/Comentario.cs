/*
 *      Clase Comentario
 * 
 * Fehca inicial: 24/10/2024
 * Realizado por: Roberto Ortiz
 * Contacto: roberto.ortizrodriguez99@gmail.com
 * 
 * Fecha de modificación: 24/10/2024
 * Modifico: [Nombre y contacto]
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaNoticias.Models
{
    public class Comentario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdComentario { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha_Comentario { get; set; }
        public bool Es_Interno { get; set; }

        public int IdNota { get; set; }
        public Nota? Nota { get; set; }

        public int IdUsuario { get; set; }
        public Usuario? Usuario { get; set; }
    }

}