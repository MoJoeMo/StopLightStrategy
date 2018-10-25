using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopLightStrategy.Classes;

namespace StopLightStrategy
{
	class Program
	{
		static void Main(string[] args)
		{
			NumberGenerator ng = new NumberGenerator();
			StopLight stopLight = new StopLight();
			SignalReaction react = stopLight.ReactionToSignal(Convert.ToInt32(ng.GetRandomNumber()));

			RuleBook rb = new RuleBook();

			Console.WriteLine(rb.GetTrafficRule(react));
			Console.Read();
		}
	}
}
