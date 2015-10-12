using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgLibrary.Study1
{
	class Actor : IActor
	{
		public bool IsAlive => Hp > 0;

		public string Name { get; private set; }
		public int Hp { get; private set; }

		public Actor(string name, int hp)
		{
			Name = name;
			Hp = hp;
		}

		public void OnTurn()
		{
			Hp -= 1;
			Console.WriteLine($"{Name}:{Hp}");
			Console.ReadKey();
		}
	}
}
