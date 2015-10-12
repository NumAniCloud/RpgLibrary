using System;

namespace RpgLibrary.Study1
{
	internal class ActorHavingSpeed : IActorHavingSpeed
	{
		public string Name { get; private set; }
		public int Hp { get; private set; }
		public int Speed { get; private set; }

		public bool IsAlive
		{
			get { return Hp > 0; }
		}

		public ActorHavingSpeed(string name, int hp, int speed)
		{
			Name = name;
			Hp = hp;
			Speed = speed;
		}

		public void OnTurn()
		{
			Hp -= 1;
			Console.WriteLine($"{Name}:{Hp}");
			Console.ReadKey();
		}
	}
}