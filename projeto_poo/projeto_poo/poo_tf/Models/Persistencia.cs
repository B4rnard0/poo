using System.Collections.Generic;
using ProjetoFinancas.Models;

namespace ProjetoFinancas.Data
{
    public class Persistencia
    {
        private readonly List<Utilizador> utilizadores = new();
        private readonly List<Categoria> categorias = new();
        private readonly List<Transacao> transacoes = new();

        public void GuardarUtilizador(Utilizador u) => utilizadores.Add(u);
        public List<Utilizador> CarregarUtilizadores() => utilizadores;
        public void AtualizarUtilizador(Utilizador u)
        {
            // Atualiza utilizador existente
        }

        public void GuardarReceita(Receita r) => transacoes.Add(r);
        public void GuardarDespesa(Despesa d) => transacoes.Add(d);
        public void GuardarCategoria(Categoria c) => categorias.Add(c);
        public List<Categoria> CarregarCategorias() => categorias;
        public void AtualizarAdministrador(Administrador a)
        {
            // Atualiza dados do admin
        }
    }
}
