namespace CadastroCliente.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string Senha { get; set; }

        public UsuarioModel(int id, string Nome, string Senha, string Email)
        {
            Id = id;
            this.Nome = Nome;
            this.Email = Email;
            this.Senha = ValidarSenha(Senha);
        }

        //caso a senha não seja validada, uma exceção será lançada
        public string ValidarSenha(string senha)
        {
            if (senha.Length < 6)
            {
                throw new ArgumentException("A senha deve ter pelo menos 6 caracteres.");
            }
            return senha;
        }
    }
}
