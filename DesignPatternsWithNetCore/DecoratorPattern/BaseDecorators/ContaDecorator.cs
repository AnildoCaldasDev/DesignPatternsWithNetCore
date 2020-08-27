using DecoratorPattern.Interfaces;

namespace DecoratorPattern.BaseDecorators
{
    public class ContaDecorator : IConta
    {
        private readonly IConta _conta;

        public ContaDecorator(IConta conta)
        {
            _conta = conta;
        }


        public virtual string BuscarTipoConta()
        {
            return _conta.BuscarTipoConta();
        }
    }
}
