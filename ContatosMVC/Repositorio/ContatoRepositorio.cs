using ContatosMVC.Data;
using ContatosMVC.Models;

namespace ContatosMVC.Repositorio
{
    public class ContatoRepositorio:IContatoRepositorio
    {

        private readonly BancoContext _bancoContext;

        public ContatoModel Adicionar(ContatoModel contato)
        {
            ContatoModel contatoDb = ListarPorId(contato.Id);
            if (contatoDb == null) throw new System.Exception("Houve um erro de atualização");

            contatoDb.Nome = contato.Nome;
            contatoDb.Email = contato.Email;
            contatoDb.Celular = contato.Celular;

            _bancoContext.Contatos.Update(contatoDb);
            _bancoContext.SaveChanges();
            return contatoDb;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        //ContatoModel IContatoRepositorio.Adicionar(ContatoModel contato)
        //{
        //    throw new NotImplementedException();
        //}

        ContatoModel IContatoRepositorio.Atualizar(ContatoModel contato)
        {
            throw new NotImplementedException();
        }

        List<ContatoModel> IContatoRepositorio.BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDb = ListarPorId(id);
            if (contatoDb == null) throw new System.Exception("Houve um erro de Exclusão");
            _bancoContext.Contatos.Remove(contatoDb);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
