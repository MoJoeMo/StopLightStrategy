using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopLightStrategy.Classes;

namespace StopLightStrategy.Interfaces
{
	public interface ILight
	{
		bool CanBuild(int signalId);
		SignalReaction BuildSignalReaction();
	}
}
