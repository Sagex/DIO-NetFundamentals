using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_01.Enum;

namespace Projeto_01.Classes
{
    class Conta
    {
        private TipoDeConta _tipoDeConta { get; set; }

        private string _nome { get; set; }

        private double _saldo { get; set; }

        private double _credito { get; set; }

        public Conta(TipoDeConta tipoDeConta, string nome, double saldo, double credito)
        {
            this._tipoDeConta = tipoDeConta;
            this._nome = nome;
            this._saldo = saldo;
            this._credito = credito;
        }

        public bool Sacar(double valorDoSaque)
        {
            if (this._saldo - valorDoSaque < this._credito * -1)
            {
                Console.WriteLine("Voce nao possui saldo. Insira um novo valor.");
                return false;
            }

            this._saldo -= valorDoSaque;
            Console.WriteLine("Saque realizado com sucesso.");
            Console.WriteLine($"Seu saldo atual da conta: Conta: {this._tipoDeConta} | {this._nome} | {this._saldo}");

            return true;
        }

        public void Depositar(double valorDoDeposito)
        {
            this._saldo += valorDoDeposito;

            Console.WriteLine("Valor depositado com sucesso.");
            Console.WriteLine($"Seu saldo atual da conta: Conta: {this._tipoDeConta} | {this._nome} | {this._saldo}");
        }

        public void Transferir(double valorDaTransferencia, Conta destino)
        {
            if (this.Sacar(valorDaTransferencia))
            {
                destino.Depositar(valorDaTransferencia);
            }
        }

        public override string ToString()
        {
            string _tipoTemp;

            if (ReturnTipoConta() == "PessoaFisica")
            {
                _tipoTemp = "Pessoa Fisica";
            }
            else
            {
                _tipoTemp = "Pessoa Juridica";
            }

            string dados = $"Cliente: {_nome} || Tipo: {_tipoTemp} || Saldo: {_saldo} || Credito: {_credito}";

            return dados;
        }

        private string ReturnTipoConta()
        {
            string tempNome = _tipoDeConta.ToString();
            return tempNome;
        }

    }

    
}
