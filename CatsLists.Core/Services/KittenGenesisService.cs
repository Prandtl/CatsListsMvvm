using System;
using System.Collections.Generic;

namespace CatsLists.Core.Services
{
	public class KittenGenesisService : IKittenGenesisService
	{
		public Kitten GenerateKitten(string extra = "")
		{
			return new Kitten()
			{
				Name = _names[Random(_names.Count)] + extra,
				ImageUrl = string.Format("http://placekitten.com/{0}/{0}", Random(20) + 300),
				Price = RandomPrice()
			};
		}

		private readonly List<string> _names = new List<string>()
			{
				"John",
				"Nicholas",
				"Ziggy Stardust",
				"Amber",
				"Loco",
				"Arvin",
				"Jesus",
				"Olaf",
				"Oglaf",
				"Doglaf",
				"Lovecraft"
			};

		private readonly System.Random _random = new System.Random();
		protected int Random(int count)
		{
			return _random.Next(count);
		}

		protected int RandomPrice()
		{
			return Random(23) + 3;
		}
	}
}
