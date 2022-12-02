using MonkeyFinancesMVC.Models;

namespace MonkeyFinancesMVC.Repositorio
{
    public interface IRegistroRepositorio
    {
        RegistroModel ListarPorId(int id);
        List<RegistroModel> BuscarTodos();
        RegistroModel Adicionar(RegistroModel registro);

        RegistroModel Atualizar(RegistroModel registro);

        bool Apagar(int id);
    }
}
