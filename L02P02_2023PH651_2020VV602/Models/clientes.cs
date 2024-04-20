using System.ComponentModel.DataAnnotations;
namespace L02P02_2023PH651_2020VV602.Models
{
    public class clientes
    {
        [Key]

        [Display(Name = "Id de cliente")]
        public int id { get; set; }

        [Display(Name = "nombre de cliente")]
        public string nombre { get; set; }

        [Display(Name = "apellido de cliente")]
        public string apellido { get; set; }

        [Display(Name = "email de cliente")]
        public string email { get; set; }

        [Display(Name = "url_imagen de imagen cliente")]
        public string url_imagen { get; set; }

        [Display(Name = "direccion de cliente")]
        public string direccion { get; set; }

        [Display(Name = "genero de cliente")]
        public char? genero { get; set; }

        [Display(Name = "Id de departamento")]
        public int? id_departamento { get; set; }

        [Display(Name = "Id de puesto")]
        public int? id_puesto { get; set; }

        [Display(Name = "Estado de registro")]
        public char? estado_registro { get; set; }

        [Display(Name = "Creado en")]
        public DateTime created_at { get; set; }

        [Display(Name = "Actualizado en")]
        public DateTime? updated_at { get; set; }
    }
}
