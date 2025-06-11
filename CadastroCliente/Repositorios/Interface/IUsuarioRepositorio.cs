using CadastroCliente.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroCliente.Repositorios.Interface
{
    public interface IUsuarioRepositorio
    {
        Task<UsuarioModel> BuscarPorEmail(string email);
        Task<List<UsuarioModel>> BuscarTodos();
        Task<UsuarioModel> BuscarPorID(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario);
        Task<bool> ApagarAsync(int id);
    }
}
