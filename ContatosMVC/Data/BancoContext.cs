using ContatosMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ContatosMVC.Data
{
    public class BancoContext : DbContext
    {
        //COnstrutor
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        //Definir os DbSet - Configurar as tabelas (entidades)
        //Classe ContatoModel servirá de base

        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

    }
}
