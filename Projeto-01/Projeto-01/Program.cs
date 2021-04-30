using System;
using System.Collections.Generic;
using Projeto_01.Classes;
using Projeto_01.Enum;


namespace Projeto_01
{
    class Program
    {
        static List<Conta> _usuario = new();
        static void Main(string[] args)
        {               

            string _opcaoUsuario = ObterOpcaoUsuario();
            
            while(_opcaoUsuario != "X")
            {
                switch (_opcaoUsuario)
                {
                    case "1":
                        Lista();
                        break;
                    case "2":
                        InserirNovaConta();
                        break;
                        Console.WriteLine();
                    case "3":
                        TransferirValor();
                        break;
                    case "4":
                        RetirarValor();
                        break;
                    case "5":
                        DepositarValor();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                _opcaoUsuario = ObterOpcaoUsuario();
            }
            
        }


        private static void Lista()
        {
            int _tempCount = 0;
            if(_usuario.Count == 0)
            {
                Console.WriteLine("Não existe conta(as) cadastradas");
                Console.WriteLine();
                return;
            }
            foreach (var x in _usuario)
            {
                Console.WriteLine($"ID: #{_tempCount} | {x.ToString()}");
                Console.WriteLine();
                Console.WriteLine("===========================================");
                Console.WriteLine();
                _tempCount++;
            }
            
        }

        private static void InserirNovaConta()
        {
            Console.WriteLine("Insida os dados pedidos abaixo: ");

            Console.Write("Tipo da conta, 1 fisica, 2 juridica: \n");
            int _tipoTemp = int.Parse(Console.ReadLine());

            Console.Write("Nome: \n");
            string _nomeTemp = Console.ReadLine();

            Console.Write("Saldo: \n");
            double _tempSaldo = double.Parse(Console.ReadLine());

            Console.Write("Credito: \n");
            double _tempCredito = double.Parse(Console.ReadLine());

            _usuario.Add(new Conta((TipoDeConta)_tipoTemp, _nomeTemp, _tempSaldo, _tempCredito));

            Console.WriteLine("Novo usuario adicionado.");
            Console.WriteLine();
        }

        private static void TransferirValor()
        {
            int _idTemporario;
            int _idDestinoTemporario;
            double _valorTemporario;

            Console.WriteLine();
            Lista();
            Console.WriteLine("Insira o ID que da conta a ser retirada: ");
            _idTemporario = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Agora, digite o valor a ser transferido: ");
            _valorTemporario = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora, para qual conta deseja transferir?: ");
            _idDestinoTemporario = int.Parse(Console.ReadLine());

            _usuario[_idTemporario].Transferir(_valorTemporario, _usuario[_idDestinoTemporario]);
        }

        private static void RetirarValor()
        {
            int _idTemporario;
            double _valorTemporario;
            Console.WriteLine();
            Lista();
            Console.WriteLine("Insira o ID que da conta a ser retirada: ");
            _idTemporario = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Agora, digite o valor a ser retirado: ");
            _valorTemporario = double.Parse(Console.ReadLine());

            _usuario[_idTemporario].Sacar(_valorTemporario);
        }

        private static void DepositarValor()
        {
            int _idTemporario;
            double _valorTemporario;
            Console.WriteLine();
            Lista();
            Console.WriteLine("Insira o ID que da conta a ser depositada: ");
            _idTemporario = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Agora, digite o valor a ser depositado: ");
            _valorTemporario = double.Parse(Console.ReadLine());

            _usuario[_idTemporario].Depositar(_valorTemporario);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opcao desejada: ");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir Conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string _opcao = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return _opcao;
        }
    }
}
