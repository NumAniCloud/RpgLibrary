using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgLibrary.Study1.Command
{
	class DamageCommand : ICommand
	{
		public void Execute(CommandActor commandActor)
		{
			commandActor.Hp -= 1;
		}
	}
}
