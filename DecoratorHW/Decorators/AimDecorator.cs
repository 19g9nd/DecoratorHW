using DecoratorHW.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DecoratorHW.Decorators
{
    public class AimDecorator : BaseDecorator
    {
        public AimDecorator(Equipment wrapper) : base(wrapper)
        {
            accuracy = 30;
            mobility = -3;
            name = "aim";
        }
    }
}
