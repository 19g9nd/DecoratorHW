using DecoratorHW.Weapons;

namespace DecoratorHW.Decorators
{
    public class ButtDecorator : BaseDecorator
    {
        public ButtDecorator(Equipment wrapper) : base(wrapper)
        {
            accuracy = 9;
            mobility = -7;
        }
    }
}
