using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Api_Jogo.Domains
{
    [Table("Usuarios")]
    [Index(nameof(NomeUsuario), IsUnique = true)]
    public class Usuarios
    {
        [Key]

        public Guid IdUsuario { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string? NomeUsuario { get; set; }

        [Column(TypeName = "varchar(80)")]
        [Required(ErrorMessage = "O NickName é obrigatório")]
        public string? NickName { get; set; }

        [ForeignKey("JogosId")]
        public Jogos? Jogos { get; set; }
    }
}
