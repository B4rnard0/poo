namespace ProjetoFinancas.Models
{
    public class Receita : Transacao
    {
        public bool Validar()
        {
            return Valor > 0 && Categoria != null;
        }
    }
}
