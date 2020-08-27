using DecoratorPattern.BaseDecorators;
using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.ConcreteDecorators
{
    public class ContaPoupancaDecorator : ContaDecorator
    {
        public ContaPoupancaDecorator(IConta conta) : base(conta) { }

        public override string BuscarTipoConta()
        {
            string conta = base.BuscarTipoConta();

            conta += " ---> Com pacotes de Beneficios para conta Poupança";
            return conta;
        }
    }
}
