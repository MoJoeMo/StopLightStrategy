using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopLightStrategy.Enum;
using StopLightStrategy.Interfaces;

namespace StopLightStrategy.Classes
{
	public class YellowLight : ILight
	{
		public bool CanBuild(int signalId)
		{
			return signalId == (int) SignalColor.Yellow;
		}

		public SignalReaction BuildSignalReaction()
		{
			SignalReaction reaction = new SignalReaction
			{
				LightColor = SignalColor.Yellow.ToString(),
				Reaction = "Slow down."
			};
			return reaction;
		}
	}
}
