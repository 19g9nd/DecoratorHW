using System;
using DecoratorHW.Decorators;
namespace DecoratorHW.Weapons
{
	public class Gun : Equipment
	{
		public Gun()
		{
			this.Name = "Gun";
			this.Damage = 10;
			this.Mobility = 30;
			this.Accuracy = 5;
			this.Image = "https://atelier3infrastructuresofautonomy.files.wordpress.com/2017/11/1200px-gp_k100_target.jpg";
		}

    }
}
