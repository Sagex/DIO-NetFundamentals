using System;

namespace NewProjectSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcaoUser;
            MostrarOpcoes();

            opcaoUser = Console.ReadLine();
            Aluno[] alunos = new Aluno[5];
            int count = 0;

            while (opcaoUser.ToUpper() != "X")
            {
                
                
                switch (opcaoUser)
                {
                    case "1":
                        Aluno aluno = new();
                        Console.WriteLine("Informe o nome: ");
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Nota: ");

                        if(decimal.TryParse(Console.ReadLine(), out decimal notaTemp))
                        {
                            aluno.Nota = notaTemp;
                        }
                        else
                        {
                            throw new ArgumentException("Valor invalido, insira somente decimal");
                        }

                        alunos[count] = aluno;
                        count++;

                        break;

                    case "2":
                        foreach(var x in alunos)
                        {
                            if (!string.IsNullOrEmpty(x.Nome))
                            {
                                Console.WriteLine($"Aluno: {x.Nome} Nota: {x.Nota}");
                            }
                        }

                        break;

                    case "3":

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                
                MostrarOpcoes();
                opcaoUser = Console.ReadLine();
            }

        }

        private static void MostrarOpcoes()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opcao: ");
            Console.WriteLine("1 - Novo aluno");
            Console.WriteLine("2 - Listar aluno");
            Console.WriteLine("3 - Media geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
        }
    }
}
