using System.Collections.Generic;

namespace RpgLibrary.Study1
{
	public interface ITurnRule
	{
		IEnumerable<IActor> GetTurnOrder(IActor[] actors);
	}
}