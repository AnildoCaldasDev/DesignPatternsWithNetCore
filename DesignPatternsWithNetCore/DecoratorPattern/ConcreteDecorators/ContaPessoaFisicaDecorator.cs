using DecoratorPattern.BaseDecorators;
using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.ConcreteDecorators
{
    public class ContaPessoaFisicaDecorator : ContaDecorator
    {
        public ContaPessoaFisicaDecorator(IConta conta) : base(conta) { }

        public override string BuscarTipoConta()
        {
            string conta = base.BuscarTipoConta();

            conta += " ---> Com pacotes de Beneficios para conta de Pessoa Fisica";
            return conta;
        }
    }


}
