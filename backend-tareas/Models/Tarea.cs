using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_tareas.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public required string Nombre { get; set; }
        [Required]
        public required int MyProperty { get; set; }
    }
}
