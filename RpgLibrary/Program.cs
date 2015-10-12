using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgLibrary.Study1;

namespace RpgLibrary
{
	class Program
	{
		static void Main(string[] args)
		{
			Actor[] actors = new Actor[]
			{
				new Actor("A", 10),
				new Actor("B", 12),
			};
			var battle = new TurnBattle<IActor>(actors, new SimpleTurnRule());
			battle.Run();
		}

		private static void Test1()
		{
			ActorHavingSpeed[] actors = new ActorHavingSpeed[]
			{
				new ActorHavingSpeed("A", 10, 2),
				new ActorHavingSpeed("B", 12, 4),
			};
			var battle = new TurnBattle<IActorHavingSpeed>(actors, new TurnRuleSpeedProvideTurn());

			battle.Run();
		}
	}
}
