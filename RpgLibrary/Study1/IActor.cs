namespace RpgLibrary.Study1
{
	public interface IActor
	{
		bool IsAlive { get; }

		void OnTurn();
	}
}