using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Domain
{
    public class Conta : IConta
    {
        public string BuscarTipoConta()
        {
            return "Conta Bancaria Padrão";
        }
    }
}
