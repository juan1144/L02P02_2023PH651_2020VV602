using System.ComponentModel.DataAnnotations;
namespace L02P02_2023PH651_2020VV602.Models
{
    public class puestos
    {
        [Key]

        [Display(Name = "Id de puestos")]
        public int id { get; set; }

        [Display(Name = "Nombre del puesto")]
        public string puesto { get; set; }

        [Display(Name = "Estado del puesto")]
        public char? estado { get; set; }

        [Display(Name = "Id de puestos")]
        public DateTime? created_at { get; set; }
    }
}
