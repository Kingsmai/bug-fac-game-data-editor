using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugEngine.Data
{
	public class Actor : Data
	{
		public string Nickname { get; set; }
		public int ClassID { get; set; }
		public int InitialLevel { get; set; }
		public int MaximumLevel { get; set; }
		public string Profile { get; set; }

		public Actor() : base(0, "") { }

		public Actor(int id) : base(id, "")
		{
		}
	}
}
