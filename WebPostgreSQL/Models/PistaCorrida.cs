using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("PistaCorrida")]
    public class PistaCorrida
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}
