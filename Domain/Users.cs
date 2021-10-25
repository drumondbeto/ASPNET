using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNET.Domain
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int Id { get; set;}

        [Column]
        [Required]
        public string Nome { get; set;}

        [Column]
        [Required]
        public string Email { get; set;}

        [Column]
        [Required]
        public string Senha { get; set;}

        [Column]
        public string Telefone { get; set;}
    }
}