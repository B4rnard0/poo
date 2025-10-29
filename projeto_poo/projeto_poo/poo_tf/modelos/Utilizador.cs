namespace ProjetoFinancas.Models
{
    public class Utilizador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void SetNome(string nome) => Nome = nome;
        public void SetEmail(string email) => Email = email;
        public void SetPassword(string password) => Password = password;

        public bool VerificarCredenciais(string email, string password)
        {
            return Email == email && Password == password;
        }
    }
}
