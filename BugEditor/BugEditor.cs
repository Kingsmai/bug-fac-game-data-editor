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
		// TODO: 从List获取数据，挂到设置上
		// TODO: 无论修改哪个值，直接视为添加新的物件
		// TODO: 退出保存确认
		// TODO: 每次退出都会保存一份备份
		private int CurrentSelectedIndex;

		public BugEditor()
		{
			InitializeComponent();
			SetEventHandlers();

			Editor.LoadData();
			if (Editor.Actors.Count > 0)
			{
				for (int i = 0; i < Editor.Actors.Count; i++)
				{
					DataList.Rows.Add(i, Editor.Actors[i].Name);
				}
				DataList.Rows[0].Selected = true;
			}
			else
			{
				for (int i = 1; i <= 20; i++)
				{
					DataList.Rows.Add(i, "");
					Editor.Actors.Add(new Actor(i));
				}
			}
		}

		/// <summary>
		/// 设置监听事件
		/// </summary>
		private void SetEventHandlers()
		{
			DataList.SelectionChanged += ReadRowData;
			tbActorName.Leave += UpdateRowData;
			tbActorNickname.Leave += UpdateRowData;
			tbActorProfile.Leave += UpdateRowData;
			btnTest.Click += Editor.Test;
		}

		// 点击列表之后，在对应信息框中显示数据
		private void ReadRowData(object sender, EventArgs e)
		{
			CurrentSelectedIndex = DataList.SelectedRows[0].Index;
			Actor currentActor = Editor.Actors[CurrentSelectedIndex];
			tbActorName.Text = currentActor.Name;
			tbActorNickname.Text = currentActor.Nickname;
			tbActorProfile.Text = currentActor.Profile;
		}

		private void UpdateRowData(object sender, EventArgs e)
		{
			// 更新数据
			Editor.Actors[CurrentSelectedIndex].Name = tbActorName.Text;
			Editor.Actors[CurrentSelectedIndex].Nickname = tbActorNickname.Text;
			Editor.Actors[CurrentSelectedIndex].Profile = tbActorProfile.Text;

			// 更新侧边栏文本内容
			DataList.SelectedRows[0].Cells["ItemName"].Value = tbActorName.Text;
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			Editor.SaveData();
		}
	}
}
