using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopLightStrategy.Classes
{
	public class RuleBook
	{
		public string GetTrafficRule(SignalReaction reaction)
		{
			StringBuilder trafficRule = new StringBuilder();
			trafficRule.AppendLine(string.Format("The light is {0}", reaction.LightColor));
			trafficRule.AppendLine(string.Format("You should {0}", reaction.Reaction));

			return trafficRule.ToString();
		}
	}
}
