using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Api_Jogo.Domains
{
    [Table("Jogos")]
    [Index(nameof(NomeJogo), IsUnique = true)]
    public class Jogos
    {
        [Key]

        public Guid JogosId { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "O nome do jogo é obrigatório")]
        public string? NomeJogo { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "A plataforma é obrigatória")]

        public string? Plataforma { get; set; }


    }
}
