using System;

namespace ProjetoFinancas.Models
{
    public abstract class Transacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public DateTime Data { get; set; }

        // Composição
        public Categoria Categoria { get; private set; }
        public Utilizador Utilizador { get; private set; }

        public void SetDescricao(string descricao) => Descricao = descricao;
        public void SetValor(float valor) => Valor = valor;
        public void SetData(DateTime data) => Data = data;
        public void SetCategoria(Categoria categoria) => Categoria = categoria;

        public void SetUtilizador(Utilizador utilizador) => Utilizador = utilizador;
    }
}
