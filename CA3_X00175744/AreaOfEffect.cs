namespace CA3
{
	// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
	public class Item
	{
		public int id { get; set; }
		public int rarity { get; set; }
		public int value { get; set; }
		public int carryLimit { get; set; }
		public string name { get; set; }
		public string description { get; set; }
	}

	public class Protection
	{
		public List<Item> items { get; set; }
		public List<Skill> skills { get; set; }
	}

	public class Recovery
	{
		public List<string> actions { get; set; }
		public List<Item> items { get; set; }
	}

	public class Ailments
	{
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public Recovery recovery { get; set; }
		public Protection protection { get; set; }
	}

	public class Skill
	{
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
	}



}

