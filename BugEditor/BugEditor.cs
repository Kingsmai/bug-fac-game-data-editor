using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using BugEngine.Editor;
using BugEngine.Data;

namespace BugEditor
{
	public partial class BugEditor : Form
	{
		// TODO: 按下Delete，直接删除该Item
		// TODO: 退出保存确认
		// TODO: 每次退出都会保存一份备份
		private int CurrentSelectedIndex;

		public BugEditor()
		{
			InitializeComponent();
			SetEventHandlers();

			//Editor.LoadData();
			//InitializeAllDataList();
		}

		/// <summary>
		/// 设置监听事件
		/// </summary>
		private void SetEventHandlers()
		{
			//dgActors.SelectionChanged += ReadRowData;
			//tbActorName.Leave += UpdateRowData;
			//tbActorNickname.Leave += UpdateRowData;
			//tbActorProfile.Leave += UpdateRowData;
			//btnTest.Click += Editor.Test;
			dgActors.SelectionChanged += Test;
		}

		// 点击列表之后，在对应信息框中显示数据
		private void ReadRowData(object sender, EventArgs e)
		{
			CurrentSelectedIndex = dgActors.SelectedRows[0].Index;
			Actor currentActor = Editor.Actors[CurrentSelectedIndex];
			tbActorName.Text = currentActor.Name;
			tbActorNickname.Text = currentActor.Nickname;
			tbActorProfile.Text = currentActor.Profile;
		}

		// 更改任何组件，都会更新数据
		private void UpdateRowData(object sender, EventArgs e)
		{
			// 更新数据
			Editor.Actors[CurrentSelectedIndex].Name = tbActorName.Text;
			Editor.Actors[CurrentSelectedIndex].Nickname = tbActorNickname.Text;
			Editor.Actors[CurrentSelectedIndex].Profile = tbActorProfile.Text;

			// 更新侧边栏文本内容
			dgActors.SelectedRows[0].Cells["ItemName"].Value = tbActorName.Text;
		}

		// 更新左侧列表
		private void InitializeAllDataList()
		{
			// 先清空列表
			dgActors.Rows.Clear();
			dgClasses.Rows.Clear();
			foreach (var actor in Editor.Actors)
			{
				dgActors.Rows.Add(actor.ID, actor.Name);
			}
			foreach (var classtype in Editor.Classes)
			{
				dgClasses.Rows.Add(classtype.ID, classtype.Name);
			}
		}

		// 退出程序时，保存数据
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			//Editor.SaveData();
		}

		// 测试方法
		private void Test(object sender, EventArgs e)
		{
			int idx = dgActors.SelectedRows[0].Index;
			if (idx == Editor.Actors.Count)
			{
				Editor.Actors.Add(new Actor(idx));
				dgActors.Rows.Add(idx, Editor.Actors[idx].Name);
				dgActors.Rows[idx].Selected = true;
			}
		}
	}
}
