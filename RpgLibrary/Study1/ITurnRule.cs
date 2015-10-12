using System.Collections.Generic;

namespace RpgLibrary.Study1
{
	public interface ITurnRule<TActor> where TActor : IActor
	{
		IEnumerable<IActor> GetTurnOrder(TActor[] actors);
	}
}