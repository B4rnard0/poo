namespace ProjetoFinancas.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public void SetNome(string nome) => Nome = nome;

        public bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nome);
        }
    }
}
