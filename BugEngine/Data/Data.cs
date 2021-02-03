using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugEngine.Data
{
	public class Data
	{
		/// <summary>
		/// 数据唯一ID
		/// </summary>
		public int ID { get; set; }
		/// <summary>
		/// 数据的名称
		/// </summary>
		public string Name { get; set; }

		public Data(int id, string name)
		{
			ID = id;
			Name = name;
		}
	}
}
