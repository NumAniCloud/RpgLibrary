using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgLibrary.Study1
{
	class TurnBattle<TActor> where TActor : IActor
	{
		public TActor[] Actors { get; set; }
		public ITurnRule<TActor> TurnRule { get; set; }

		public TurnBattle()
		{
			Actors = new TActor[0];
			TurnRule = (ITurnRule<TActor>)new SimpleTurnRule();
		}

		public void Run()
		{
			foreach(IActor item in TurnRule.GetTurnOrder(Actors))
			{
				item.OnTurn();
				if(Actors.All(x => !x.IsAlive))
				{
					break;
				}
			}
		}
	}
}
