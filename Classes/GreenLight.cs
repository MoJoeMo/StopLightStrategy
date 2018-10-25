using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopLightStrategy.Enum;
using StopLightStrategy.Interfaces;

namespace StopLightStrategy.Classes
{
	public class GreenLight : ILight
	{
		public bool CanBuild(int signalId)
		{
			return signalId == (int) SignalColor.Green;
		}

		public SignalReaction BuildSignalReaction()
		{
			SignalReaction reaction = new SignalReaction
			{
				LightColor = SignalColor.Green.ToString(),
				Reaction = "Go for it!"
			};
			return reaction;
		}
	}
}
