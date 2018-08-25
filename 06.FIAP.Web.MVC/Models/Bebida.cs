using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _06.FIAP.Web.MVC.Models
{
    [Table("TBebida")]
    public class Bebida
    {
        [Column("Id")]
        public int BebidaId { get; set; }
        [Required]
        [Column("Nome")]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Column("Destilada")]
        public bool Destilada { get; set; }
        [Column("Preco")]
        public decimal Preco { get; set; }
    }
}