using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GGJ2021
{
	public partial class MainPanel : Form
	{
		private int gold = 0; // 玩家金币
		private int multiply = 1; // 购买乘积
		private int level = 1; // 当前等级
		private int experience = 0; // 当前经验值
		private int nextLevelExperience = 100; // 下一等级所需经验值

		public MainPanel()
		{
			InitializeComponent();
			// TODO: 读取游戏存档
		}

		delegate void SetTextCallBack(string text);

		// 显示消息
		public void Log(string msg)
		{
			// 避免线程冲突
			// https://stackoverflow.com/questions/10775367/cross-thread-operation-not-valid-control-textbox1-accessed-from-a-thread-othe
			if (TextBoxGameConsole.InvokeRequired)
			{
				SetTextCallBack d = new SetTextCallBack(Log);
				Invoke(d, new object[] { msg });
			}
			else
			{
				string time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt: ");
				TextBoxGameConsole.Text += time + msg + Environment.NewLine;
				// 将当前caret的位置移动到最下方
				TextBoxGameConsole.SelectionStart = TextBoxGameConsole.Text.Length;
				// 自动滚动到最下方
				TextBoxGameConsole.ScrollToCaret();
			}
		}

		// Template: 修改玩家持有金额
		public void modGold(int amount)
		{
			gold += amount;
			LbGold.Text = gold.ToString();
		}

		// 修改玩家等级
		public void modLevel(int amount)
		{
			// 下个等级还需经验值
			int expToNextLevel = this.nextLevelExperience - this.experience;
			// 进度条最大值 = 下等级所需经验值
			PbLevel.Maximum = this.nextLevelExperience;
			// 判断增加的数值是否大于当前还需要的经验值
			// 如果太多的话，就只需要增加当前需要的经验值
			this.experience += amount < expToNextLevel ? amount : expToNextLevel;
			PbLevel.Value = this.experience;
			Application.DoEvents();
			if (PbLevel.Value >= PbLevel.Maximum)
			{
				this.experience = 0;
				PbLevel.Value = this.experience;
				amount -= expToNextLevel;
				level += 1;
				LbLevel.Text = "Level: " + this.level;
				modLevel(amount);
			}
			return;
		}

		// 每回合需要执行的事情
		public void One_Loop(object source, ElapsedEventArgs e)
		{
			Log("One Turn");
		}

		private void MainPanel_Load(object sender, EventArgs e)
		{
			// 两秒执行一次
			System.Timers.Timer timer = new System.Timers.Timer();
			timer.Elapsed += new ElapsedEventHandler(One_Loop);
			timer.Interval = 2000;
			timer.Enabled = true;
		}

		private void BtnMineGold_Click(object sender, EventArgs e)
		{
			// 增加游戏金币
			modGold(1 * multiply);
		}

		private void BtnBuyMlp_Click(object sender, EventArgs e)
		{
			// 调整购买倍数
			switch (multiply)
			{
				case 1:
				case 10:
				case 100:
					multiply *= 10;
					break;
				default:
					multiply = 1;
					break;
			}
			BtnBuyMlp.Text = "x " + multiply.ToString();
		}

		// 指令栏输入，按下回车时触发这个函数
		private void CommandInput(object sender, KeyEventArgs e)
		{
			// 指令栏输入回车的时候
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				string userInput = CommandBar.Text;
				switch (userInput)
				{
					case "cls": // 清屏指令
						TextBoxGameConsole.Text = "";
						break;
					case "quit":
					case "exit":
						// 退出游戏
						Application.Exit();
						break;
					default:
						if (userInput.StartsWith("/"))
						{
							// 用户输入的是指令
							Utils.GameCmd gameCmd = new Utils.GameCmd(this);
							gameCmd.RunCommand(userInput);
						}
						else
						{
							Log(userInput); // 在消息列表显示信息
						}
						break;
				}
				CommandBar.Text = ""; // 清空输入框
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// 退出游戏
			Application.Exit();
		}

		// 窗口退出时，需要做的事情
		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			base.OnFormClosed(e);
			// TODO: 保存用户数据
			// 保存游戏日志
			string now = DateTime.Now.ToString("dd-MM-yyyy_HH.mm.ss") + "-game.log";
			System.IO.FileInfo logFile = new System.IO.FileInfo(@".\\log\\" + now);
			logFile.Directory.Create(); // Create directory if not exist
			string logContent = TextBoxGameConsole.Text.Replace("\n", Environment.NewLine);
			System.IO.File.WriteAllText(logFile.FullName, logContent);
		}

		private void LbLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// 保存游戏日志
			string now = DateTime.Now.ToString("dd-MM-yyyy_HH.mm.ss") + "-client.log";
			System.IO.FileInfo logFile = new System.IO.FileInfo(@".\\log\\" + now);
			logFile.Directory.Create(); // Create directory if not exist
			string logContent = TextBoxGameConsole.Text.Replace("\n", Environment.NewLine);
			System.IO.File.WriteAllText(logFile.FullName, logContent);
			TextBoxGameConsole.Text = "";
		}
	}
}
