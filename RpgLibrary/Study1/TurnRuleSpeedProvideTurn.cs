using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgLibrary.Study1
{
	class TurnRuleSpeedProvideTurn : ITurnRule<IActorHavingSpeed>
	{
		class TurnCount
		{
			public IActorHavingSpeed Actor { get; set; }
			public int Count { get; set; }
		}

		public IEnumerable<IActor> GetTurnOrder(IActorHavingSpeed[] actors)
		{
			TurnCount[] actorHaveSpeed = actors.Select(x => new TurnCount() { Actor = x, Count = 0 })
				.ToArray();

			while(true)
			{
				foreach(var item in actorHaveSpeed)
				{
					if(item.Actor.IsAlive)
					{
						item.Count += item.Actor.Speed;
						if(item.Count >= 10)
						{
							yield return item.Actor;
							item.Count -= 10;
						}
					}
				}
			}
		}
	}
}
