using ContatosMVC.Models;

namespace ContatosMVC.Repositorio
{
    public interface IContatoRepositorio
    {
        //um contrato que vai receber como parametro um objeto contrato
        //e que vai retornar ele mesmo deve ser usado na classe ContatoRepositorio
        //por injeção
        ContatoModel Adicionar(ContatoModel contato);

        List<ContatoModel> BuscarTodos();

        ContatoModel Atualizar(ContatoModel contato);

        ContatoModel ListarPorId(int id);

        bool Apagar(int id);
    }

}
