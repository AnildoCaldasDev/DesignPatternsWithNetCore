
using DecoratorPattern.BaseDecorators;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.ConcreteDecorators
{
    public class ContaPessoaJuridicaDecorator : ContaDecorator
    {
        public ContaPessoaJuridicaDecorator(IConta conta) : base(conta) { }

        public override string BuscarTipoConta()
        {
            string conta = base.BuscarTipoConta();

            conta += " ---> Com pacotes de Beneficios para conta de Pessoa Jurídica";
            return conta;
        }
    }
}
