namespace CadastroCliente.Repositorios
{
    using CadastroCliente.Models;
    using CadastroCliente.Repositorios.Interface;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        //BUSCAR POR EMAIL
        public Task<UsuarioModel> BuscarPorEmail(string email)
        {

            throw new NotImplementedException();
        }
        //BUSCAR TODOS
        public async Task<List<UsuarioModel>> BuscarTodos()
        {
            
            List<UsuarioModel> usuarios = new List<UsuarioModel>();

            return await Task.FromResult(usuarios); 
        }
        //BUSCAR POR ID
        public Task<UsuarioModel> BuscarPorID(int id)
        {
            return DbContext.Usuarios.FirstOrDefault(x => x.Id == id);
            
        }
        //ADICIONAR
        public Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            usuario.DataCadastro = DateTime.Now;
            usuario.SetSenhaHash();
            DbContext.Usuarios.Add(usuario);
            DbContext.SaveChanges();
            return usuario;

        }
        //ATUALIZAR
        public Task<UsuarioModel> Atualizar(UsuarioModel usuario, UsuarioModel usuarioDB)
        {
            UsuarioModel usuarioDB = BuscarPorID(usuario.Id);

            if (usuarioDB == null) throw new Exception("Houve um erro na atualização do usuário!");
            usuarioDB.Nome = usuario.Nome;
            usuarioDB.Email = usuario.Email;
            usuarioDB.Login = usuario.Login;
            usuarioDB.Perfil = usuario.Perfil;
            usuarioDB.DataAtualizacao = DateTime.Now;

            DbContext.Usuarios.Update(usuarioDB);
            DbContext.SaveChanges();

            return usuarioDB;

        }
        //APAGAR
        public Task<bool> ApagarAsync(int id)
        {

            throw new NotImplementedException();

        }
    }
}