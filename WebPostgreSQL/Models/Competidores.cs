using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Competidores")]
    public class Competidores
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Sexo")]
        [Display(Name = "Sexo")]
        public char Sexo { get; set; }

        [Column("TemperaturaMediaCorpo")]
        [Display(Name = "Temperatura média do corpo")]
        public Double TemperaturaMediaCorpo { get; set; }

        [Column("Peso")]
        [Display(Name = "Peso")]
        public Double Peso { get; set; }

        [Column("Altura")]
        [Display(Name = "Altura")]
        public Double Altura { get; set; }
    }
}
