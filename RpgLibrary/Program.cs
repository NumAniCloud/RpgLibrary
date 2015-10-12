using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgLibrary.Study1;
using RpgLibrary.Study1.Command;

namespace RpgLibrary
{
	class Program
	{
		static void Main(string[] args)
		{
			ICommand[] commands = new ICommand[]
			{
				new HealCommand(),
				new DamageCommand(),
			};

			var battle = new TurnBattle<IActor>()
			{
				Actors = new IActor[]
				{
					new CommandActor("A", 10, commands),
					new Actor("B", 15),
				},
				TurnRule = new SimpleTurnRule(),
			};
			battle.Run();
		}

		private static void Test2()
		{
			var battle = new TurnBattle<IActor>()
			{
				Actors = new Actor[]
				{
					new Actor("A", 10),
					new Actor("B", 12),
				},	
				TurnRule = new SimpleTurnRule(),
			};
			battle.Run();
		}

		private static void Test1()
		{
			var battle = new TurnBattle<IActorHavingSpeed>()
			{
				Actors = new ActorHavingSpeed[]
				{
					new ActorHavingSpeed("A", 10, 2),
					new ActorHavingSpeed("B", 12, 4),
				},
				TurnRule = new TurnRuleSpeedProvideTurn(),
			};

			battle.Run();
		}
	}
}
