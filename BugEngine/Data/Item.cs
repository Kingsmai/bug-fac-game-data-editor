using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugEngine.Data
{
	/// <summary>
	/// 游戏道具
	/// </summary>
	public class Item
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Type { get; set; }
		public decimal Price { get; set; }
		public bool IsConsumable { get; set; }

		public Item() { }

		public Item(int id)
		{
			ID = id;
		}

		public Item(int id, string name, string desc, string type, decimal price, bool isConsumable)
		{
			ID = id;
			Name = name;
			Description = desc;
			Type = type;
			Price = price;
			IsConsumable = isConsumable;
		}
	}
}
