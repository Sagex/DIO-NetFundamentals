using System;
using System.Collections.Generic;

namespace Projeto_02
{
    class Program
    {
        static SerieRepositorio repositorio = new();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcao();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSeries();
                        break;
                    case "4":
                        DeleteSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcao();
            }
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o ID da serie que deseja visualizar: ");
            int idTemp = int.Parse(Console.ReadLine());

            var serieInfos = repositorio.RetornaPorId(idTemp);

            Console.WriteLine(serieInfos);
        }

        private static void DeleteSerie()
        {
            Console.WriteLine("Qual ID que você deseja excluir?: ");
            int idTemp = int.Parse(Console.ReadLine());

            repositorio.Excluir(idTemp);
        }

        private static void AtualizarSeries()
        {
            Console.WriteLine("ID da serie: ");
            int idSerie = int.Parse(Console.ReadLine());

            foreach (int x in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{x} | {Enum.GetName(typeof(Genero), x)}");
            }
            

            Console.WriteLine("Digite a opcao do genero");
            int opcaoGenero = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome da serie: ");
            string nomeDaSerie = Console.ReadLine();
            Console.WriteLine("Ano da serie: ");
            int inputAno = int.Parse(Console.ReadLine());
            Console.WriteLine("Descricao da serie: ");
            string descriDaSerie = Console.ReadLine();
            Series novaSerie = new Series(id: idSerie, genero: (Genero)opcaoGenero, titulo: nomeDaSerie, descricao: descriDaSerie, ano: inputAno);

            repositorio.Atualizar(idSerie, novaSerie);
            Console.WriteLine("SERIE ATUALIZADA");
        }

        private static void InserirSeries()
        {
            Console.WriteLine();

            foreach(int x in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{x} | {Enum.GetName(typeof(Genero), x)}");
            }

            Console.WriteLine("Digite a opcao do genero");
            int opcaoGenero = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome da serie: ");
            string nomeDaSerie = Console.ReadLine();
            Console.WriteLine("Ano da serie: ");
            int inputAno = int.Parse(Console.ReadLine());
            Console.WriteLine("Descricao da serie: ");
            string descriDaSerie = Console.ReadLine();

            //Caso o new se mantenha na ordem, não é obrigatorio expecificar as opcoes do contrutor, caso contrario, é preciso.
            Series novaSerie = new Series(id: repositorio.ProximoId(), genero: (Genero)opcaoGenero, titulo: nomeDaSerie, descricao: descriDaSerie, ano: inputAno);

            repositorio.Insere(novaSerie);
            Console.WriteLine("SERIE CRIADA");
        }

        private static void ListarSeries()
        {
            Console.WriteLine();
            var serieLista = repositorio.Lista();
            

            if (serieLista.Count == 0)
            {
                Console.WriteLine("Nenhuma Lista Cadastrada");
                return;
            }

            foreach(var s in serieLista)
            {
                Console.WriteLine($"ID: {s.RetornarID()} | Titulo: {s.RetornarTitulo()} | Excluido?: {(s.RetornaDeleteEstado() ? "++|Sim|++" : "--|Nao|--")}");
            }

        }

        private static string ObterOpcao()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opcao desejada");
            Console.WriteLine();

            Console.WriteLine("1 - Listar Series");
            Console.WriteLine("2 - Inserir nova serie");
            Console.WriteLine("3 - Atualizar serie");
            Console.WriteLine("4 - Deletar Serie");
            Console.WriteLine("5 - Visualizar Serie");
            Console.WriteLine("C - Limpar Console");
            Console.WriteLine("X - Sair");

            Console.WriteLine();

            string opcao = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return opcao;
        }
    }
}
