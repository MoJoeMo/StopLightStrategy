using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopLightStrategy.Interfaces;

namespace StopLightStrategy.Classes
{
	public class StopLightBuilder : ILight
	{
		public bool CanBuild(int signalId)
		{
			throw new NotImplementedException();
		}

		public SignalReaction BuildSignalReaction()
		{
			throw new NotImplementedException();
		}
	}
}
