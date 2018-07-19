namespace WebAPI.Models
{
    public class UsuarioModel
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }

        public UsuarioModel(int codigo, string nome, string login)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Login = login;
        }

    }
}