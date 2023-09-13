using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codefirst.Domains
{
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome obrigatório!")]
        public string Nome { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descrição obrigatória!!")]
        public string Descricao { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data de lançamento obrigatória!!")]
        public DateTime DataLancamento { get; set; }
       
        [Column(TypeName = "DECIMAL(4,2)")]
        [Required(ErrorMessage = "Preço obrigatório!!!")]
        public Decimal Preco { get; set; }

        //Refêrencia á tabela Estúdio (Foreign Key)
        public Guid IdEstudio { get; set; }

        [ForeignKey("IdEstudio")]
        public Estudio Estudio { get; set; }
    }
}
