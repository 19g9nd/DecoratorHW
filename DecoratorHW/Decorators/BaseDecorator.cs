using DecoratorHW.Weapons;

namespace DecoratorHW.Decorators
{
    public class BaseDecorator : Equipment
    {
        Equipment wrapper;

        protected int damage;
        protected int accuracy;
        protected int mobility;
        protected string name;
        public override int Mobility { get => wrapper.Mobility + mobility; }
        public override int Damage { get => wrapper.Damage + damage; }
        public override int Accuracy { get => wrapper.Accuracy + accuracy; }
        public override string Image { get => wrapper.Image; }
        public override string Name { get => wrapper.Name + $" with {name} "; }
        public BaseDecorator(Equipment wrapper)
        {
            this.wrapper = wrapper;
        }



    }
}
