using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{   
    [Table("Histórico de corridas")]
    public class HistoricoCorrida
     {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("CompetidorId")]
        [Display(Name = "Código")]
        public int CompetidorId { get; set; }

        [Column("PistaCorridaId")]
        [Display(Name = "ID da pista")]
        public int PistaCorridaId { get; set; }

        [Column("DataCorrida")]
        [Display(Name = "DataCorrida")]
        public DateTime DataCorrida { get; set; }

        [Column("TempoGasto")]
        [Display(Name = "TempoGasto")]
        public Decimal TempoGasto { get; set; }
    }
    
}
