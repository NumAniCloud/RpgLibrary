using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgLibrary.Study1
{
	class SimpleTurnRule : ITurnRule
	{
		public IEnumerable<IActor> GetTurnOrder(IActor[] actors)
		{
			while(true)
			{
				foreach(var item in actors)
				{
					if(item.IsAlive)
					{
						yield return item;
					}
				}
			}
		}
	}
}
