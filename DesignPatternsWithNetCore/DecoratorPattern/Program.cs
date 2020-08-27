using DecoratorPattern.BaseDecorators;
using DecoratorPattern.ConcreteDecorators;
using DecoratorPattern.Domain;
using DecoratorPattern.Interfaces;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IConta conta = new Conta();
            Console.WriteLine(conta.BuscarTipoConta());

            IConta contaPoupanca = new ContaPoupancaDecorator(conta);
            IConta contaFisica = new ContaPessoaFisicaDecorator(conta);
            IConta pessoaJuridica = new ContaPessoaJuridicaDecorator(conta);
            Console.WriteLine(contaPoupanca.BuscarTipoConta());
            Console.WriteLine(contaFisica.BuscarTipoConta());
            Console.WriteLine(pessoaJuridica.BuscarTipoConta());

            Console.ReadLine();
        }
    }
}
