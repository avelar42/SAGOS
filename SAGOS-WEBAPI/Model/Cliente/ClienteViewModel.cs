using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cliente
{
    [Table("TB_Cliente")]
    public class ClienteViewModel
    {
        [Column("CL_ID")]
        [Display(Name = "Codigo")]
        [Key]
        public Guid ClienteId { get; set; }
        [Column("CL_NOME")]
        [Display(Name = "Nome")]
        [MaxLength(255)]
        public string Nome { get; set; }
        [Column("CL_SOBRENOME")]
        [Display(Name = "Sobrenome")]
        [MaxLength(255)]
        public string Sobrenome { get; set; }
        [Column("CL_TELEFONE")]
        [Display(Name = "Telefone")]
        public int Telefone { get; set; }
    }
}
