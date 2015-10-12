using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgLibrary.Study1.Command;

namespace RpgLibrary.Study1
{
	class CommandActor : Actor
	{
		public CommandActor(string name, int hp, ICommand[] commands)
			: base(name, hp)
		{
			Commands = commands;
		}

		public ICommand[] Commands { get; private set; }

		public override void OnTurn()
		{
			Console.WriteLine("コマンド？");
			while(true)
			{
				int input;
				if(int.TryParse(Console.ReadLine(), out input))
				{
					if(input < Commands.Length)
					{
						Commands[input].Execute(this);
						break;
					}
				}
			}
			Console.WriteLine($"{Name}:{Hp}");
		}
	}
}
