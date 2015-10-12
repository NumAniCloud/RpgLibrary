using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgLibrary.Study1
{
	class TurnBattle<TActor> where TActor : IActor
	{
		TActor[] actors;
		ITurnRule<TActor> rule;

		public TurnBattle(TActor[] actors, ITurnRule<TActor> rule)
		{
			this.actors = actors;
			this.rule = rule;
		}

		public void Run()
		{
			foreach(IActor item in rule.GetTurnOrder(actors))
			{
				item.OnTurn();
				if(actors.All(x => !x.IsAlive))
				{
					break;
				}
			}
		}
	}
}
