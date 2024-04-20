using System.ComponentModel.DataAnnotations;
namespace L02P02_2023PH651_2020VV602.Models
{
    public class departamentos
    {
        [Key]

        [Display(Name = "Id de departamento")]
        public int id { get; set; }

        [Display(Name = "Nombre del departamento")]
        public string departamento { get; set; }

        [Display(Name = "Estado del departamento")]
        public char? estado { get; set; }

        [Display(Name = "Creado en")]
        public DateTime? created_at { get; set; }
    }
}
