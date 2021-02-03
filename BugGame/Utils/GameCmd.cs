using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGJ2021.Utils
{

	public class GameCmd
	{
		public MainPanel mainPanel;

		public GameCmd(MainPanel mp)
		{
			this.mainPanel = mp;
		}

		/**
		 * 参数不足
		 * @param req 所需要的参数
		 * @param get 实际给的参数
		 */
		private bool Not_Enough_Param(int req, int given)
		{
			if (given < req)
			{
				mainPanel.Log("Expected " + req + " parameter for command /gold but " + given + " is given");
				return true;
			}
			return false;
		}

		public void RunCommand(string text)
		{
			// 获取带参数的指令，去掉斜杠
			string[] root = text.TrimStart('/').Split();
			// 获取指令
			string command = root[0];
			// 获取参数
			List<string> args = new List<string>(root);
			args.RemoveAt(0);
			int argsLen = args.Count;
			switch(command)
			{
				case "gold": // 增加金币
					int amount; // 需要增加的数额
					if (!Not_Enough_Param(1, argsLen))
					{
						if (int.TryParse(args[0], out amount))
						{
							// 尝试转换，如果用户输入的是整数
							mainPanel.modGold(amount);
							mainPanel.Log("Gold Modified: " + amount);
						} else
						{
							mainPanel.Log("Unknown Parameters: " + args[0]);
						}
					}
					break;
				case "level":
					if (!Not_Enough_Param(1, argsLen))
					{
						if (int.TryParse(args[0], out amount))
						{
							mainPanel.modLevel(amount);
							mainPanel.Log("Level Modified: " + amount);
						} else
						{
							mainPanel.Log("Unknown Parameters: " + args[0]);
						}
					}
					break;
				default:
					mainPanel.Log("Command not found: " + command + ". Use /help to read usable command.");
					break;
			}
		}
	}
}
