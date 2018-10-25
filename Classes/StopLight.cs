using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopLightStrategy.Classes;
using StopLightStrategy.Enum;
using StopLightStrategy.Interfaces;

namespace StopLightStrategy
{
	public class StopLight
	{
		private List<ILight> builders { get; }

		public StopLight()
		{
			builders = new List<ILight>()
			{
				new RedLight(),
				new YellowLight(),
				new GreenLight()
			};
		}

		public SignalReaction ReactionToSignal(int signalId)
		{
			return builders.First(b => b.CanBuild(signalId)).BuildSignalReaction();
		}
	}
}
