using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopLightStrategy.Enum;
using StopLightStrategy.Interfaces;

namespace StopLightStrategy.Classes
{
	public class RedLight : ILight
	{
		public bool CanBuild(int signalId)
		{
			return signalId == (int) SignalColor.Red;
		}

		public SignalReaction BuildSignalReaction()
		{
			SignalReaction reaction = new SignalReaction
			{
				LightColor = SignalColor.Red.ToString(),
				Reaction = "Stop"
			};

			return reaction;
		}
	}
}
