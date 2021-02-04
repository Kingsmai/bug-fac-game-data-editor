using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

using BugEngine.Data;

namespace BugEngine.Editor
{
	/// <summary>
	/// 负责引擎的所有逻辑和全局变量
	/// </summary>
	public static class Editor
	{
		#region 所有游戏物品List
		public static List<Actor> Actors = new List<Actor>();
		public static List<Class> Classes = new List<Class>();
		public static List<Skill> Skills = new List<Skill>();
		public static List<Item> Items = new List<Item>();
		public static List<Weapon> Weapons = new List<Weapon>();
		public static List<Armor> Armors = new List<Armor>();
		public static List<Enemy> Enemies = new List<Enemy>();
		public static List<Troop> Troops = new List<Troop>();
		public static List<State> States = new List<State>();
		#endregion

		#region 变量值
		private static int currentSelectedId = 1;
		#endregion

		#region 常规类：默认设置
		private const int DefaultSelectedId = 1;
		private const int DefaultSize = 20; // 默认都有20个数据
		#endregion

		#region 常量类：数据保存路径
		private const string DataPath = "./data/";
		private const string ActorsPath = DataPath + "actors.xml"; // 人物
		private const string ClassesPath = DataPath + "classes.xml"; // 职业
		private const string SkillsPath = DataPath + "skills.xml"; // 技能
		private const string ItemsPath = DataPath + "items.xml"; // 道具
		private const string WeaponsPath = DataPath + "weapons.xml"; // 武器
		private const string ArmorsPath = DataPath + "armors.xml"; // 防具
		private const string EnemiesPath = DataPath + "enemies.xml"; // 敌人
		private const string TroopsPath = DataPath + "troops.xml"; // 敌群
		private const string StatesPath = DataPath + "states.xml"; // 状态
		#endregion

		/// <summary>
		/// 导出XML文件
		/// </summary>
		/// <param name="path">导出路径</param>
		/// <param name="type">数据类型（包含主要数据的最大类型，如：保存物品列表就用List<Item>而不是<Item>）</param>
		/// <param name="data">要导出的数据</param>
		private static void ExportXml(string path, Type type, object data)
		{
			// 如果找不到路径，则创建目录
			if (!Directory.Exists(DataPath))
			{
				Directory.CreateDirectory(DataPath);
			}
			// 导出文件
			XmlSerializer serializer = new XmlSerializer(type);
			using (FileStream stream = new FileStream(path, FileMode.Create))
			{
				serializer.Serialize(stream, data);
			}
		}

		/// <summary>
		/// 读取XML文件
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="path"></param>
		/// <param name="type"></param>
		/// <returns></returns>
		private static List<T> ReadXml<T>(string path, Type type)
		{
			List<T> list = new List<T>();
			// 如果找不到路径，则创建目录
			if (!Directory.Exists(DataPath))
			{
				Directory.CreateDirectory(DataPath);
			}
			if (File.Exists(path))
			{
				// 导入文件
				XmlSerializer serializer = new XmlSerializer(type);
				using (FileStream stream = new FileStream(path, FileMode.Open))
				{
					list = serializer.Deserialize(stream) as List<T>;
				}
			}
			return list;
		}

		public static void SaveData()
		{
			// 保存所有数据
			ExportXml(ActorsPath, typeof(List<Actor>), Actors);
			ExportXml(ClassesPath, typeof(List<Class>), Classes);
		}

		public static void LoadData()
		{
			Actors = ReadXml<Actor>(ActorsPath, typeof(List<Actor>));
			Classes = ReadXml<Class>(ClassesPath, typeof(List<Class>));
		}

		/// <summary>
		/// 测试功能
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public static void Test(object sender, EventArgs e)
		{
			Console.WriteLine("Testing Btn");
		}
	}
}
