using System.ComponentModel.DataAnnotations;
using ContatosMVC.Enums;

namespace ContatosMVC.Models
{
    public class UsuarioModel
    {
        [Key]
        public int UsuarioID { get; set; }
        public string UsuarioNome { get; set; }
        public string Login { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }
        public PerfilEnum Perfil { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualização { get; set; }
    }
}




