namespace ProjetoFinancas.Models
{
    public class Despesa : Transacao
    {
        public bool Validar()
        {
            return Valor > 0 && Categoria != null;
        }
    }
}
