namespace RpgLibrary.Study1.Command
{
	interface ICommand
	{
		void Execute(CommandActor commandActor);
	}
}