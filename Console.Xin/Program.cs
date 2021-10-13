using System;
using Projeto1;

namespace Projeto.Xin
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {

            string OpcaoUser = Opcao();

            while (OpcaoUser.ToUpper() != "X")
            {//ler opcaouser se for diferente de X
                switch (OpcaoUser)
                {// le a opcaouser e da prosseguimento com a opc. do usuario
                    case "1":
                        listaSeries();
                        break;

                    case "2":
                        InserirSerie();
                        break;

                    case "3":
                        AtualizarSerie();
                        break;

                    case "4":
                        ExcluirSerie();
                        break;

                    case "5":
                        // VizualizarSerie();
                        break;

                    case "C":
                        // Console.Clear();
                        break;

                    default: // mensagem de erro
                        throw new ArgumentOutOfRangeException();
                }
                OpcaoUser = Opcao();
            }
        }

        private static void listaSeries()
        {
            Console.WriteLine("Lista de Séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Série Cadastrada");
                Console.WriteLine("");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();

                Console.WriteLine("-COD {0} - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "Excluido" : "Disponivel"));
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Adicione uma nova série:");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            { // vai entrar no Enum escrevendo todos os valores e o gatename irá mostrar todos os nomes listados
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine(" ");
            Console.Write("digite o Genero da Série: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            // o parse irá transformar a string em inteiro

            Console.Write("Digite o Titulo da Série: ");
            string entradaTitulo = Console.ReadLine();
            // recebe o titulo da série

            Console.Write("Dgite o Ano que a série foi lançada: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Adicione a Descrição ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(Id: repositorio.ProximoId(), Genero: (Genero)entradaGenero, Titulo: entradaTitulo, Ano: entradaAno, Descricao: entradaDescricao);

            repositorio.Insere(novaSerie);

        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o Código da série que você deseja Atualizar: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine(" ");
            Console.Write("digite o Genero da Série: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Dgite o Ano que a série foi lançada: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Adicione a Descrição ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(Id: indiceSerie, Genero: (Genero)entradaGenero, Titulo: entradaTitulo, Ano: entradaAno, Descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine(" Digite o Código da Série que deseja excluir:");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);
        }

        private static string Opcao()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Projeto Séries - Seja Bem vindo!");
            Console.WriteLine("Escolha uma opção a seguir");

            Console.WriteLine("1 - Listar todas as Séries");
            Console.WriteLine("2 - Adicionar uma série");
            Console.WriteLine("3 - Atualizar Série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("X - Sair do Programa ");
            Console.WriteLine("");

            string OpcaoUser = Console.ReadLine().ToUpper();
            Console.WriteLine(" ");
            return OpcaoUser;
        }


    }
}
