using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopLightStrategy.Interfaces;

namespace StopLightStrategy
{
	public class NumberGenerator
	{
		private readonly Random _random = new Random();

		public int GetRandomNumber()
		{
			return Convert.ToInt32(_random.Next(1, 4));
		}
	}
}
