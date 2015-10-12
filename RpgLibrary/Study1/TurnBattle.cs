using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgLibrary.Study1
{
	class TurnBattle
	{
		IActor[] actors;
		ITurnRule rule;

		public TurnBattle(IActor[] actors, ITurnRule rule)
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
