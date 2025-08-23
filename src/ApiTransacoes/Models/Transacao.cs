using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApi.Models
{
    [Table("transacoes")]
    public class Transacao
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("descricao")]
        [MaxLength(255)]
        public string Descricao { get; set; }

        [Column("valor", TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }

        [Column("data_transacao")]
        public DateTime DataTransacao { get; set; }
    }
}
