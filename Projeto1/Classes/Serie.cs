namespace Projeto1
{
    public class Serie : EntidadeBase
    { // atributos
        private Genero Genero { get ; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano {get; set; }

        private bool Excluido {get; set; } //true or false

        public Serie(int Id, Genero Genero, string Titulo, string Descricao, int Ano)
        { //metodo construtor
            this.Id = Id;
            this.Genero = Genero; 
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Excluido = false;
        }
        public override string ToString()
        { //converte o objeto para string - "\r\n" pula linha
            string retorno = "";
            retorno += "Gênero: " + this.Genero + "\r\n";
            retorno += "Titulo: " + this.Titulo + "\r\n";
            retorno += "Descrição: " + this.Descricao + "\r\n";
            retorno += "Ano de Início: " + this.Ano + "\r\n";
            retorno += "Excluido: " + this.Excluido;
			return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

    }   
}