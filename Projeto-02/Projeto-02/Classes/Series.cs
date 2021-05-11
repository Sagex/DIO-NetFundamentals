using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_02
{
    class Series : EntidadeBase
    {
        private Genero _genero { get; set; }
        private string _titulo {get; set; }
        private string _descricao { get; set; }
        private int _ano { get; set; }
        private bool _excluido { get; set; }

        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this._genero = genero;
            this._titulo = titulo;
            this._descricao = descricao;
            this._ano = ano;
            this._excluido = false;
        }

        public override string ToString()
        {
            //VANTAGEM DO Environment.NewLine E QUE ELE SE "ADAPTA" AO SISTEMA QUE ESTA RODANDO. EVITANDO ASSIM, A PESQUISA DE COMO SE USA NOVA LINHA NO OS.

            string retorno = "";

            retorno += "Genero: " + this._genero + Environment.NewLine;
            retorno += "Titulo: " + this._titulo + Environment.NewLine;
            retorno += "Descricao " + this._descricao + Environment.NewLine;
            retorno += "Ano: " + this._ano + Environment.NewLine;
            retorno += $"Excluido: {this._excluido}";

            return retorno;
        }

        public string RetornarTitulo()
        {
            return this._titulo;
        }

        public int RetornarID()
        {
            return this.Id;
        }

        public bool RetornaDeleteEstado()
        {
            return this._excluido;
        }

        public void Delete()
        {
            this._excluido = true;
        }
    }
}
