
namespace BugEditor
{
	partial class BugEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnTest = new System.Windows.Forms.Button();
			this.DataList = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPanel = new System.Windows.Forms.TabControl();
			this.tpActors = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.cbClasses = new System.Windows.Forms.ComboBox();
			this.tbActorProfile = new System.Windows.Forms.TextBox();
			this.tbActorNickname = new System.Windows.Forms.TextBox();
			this.tbActorName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tpClasses = new System.Windows.Forms.TabPage();
			this.tpSkills = new System.Windows.Forms.TabPage();
			this.tpItems = new System.Windows.Forms.TabPage();
			this.tpWeapons = new System.Windows.Forms.TabPage();
			this.tpArmors = new System.Windows.Forms.TabPage();
			this.tpEnemies = new System.Windows.Forms.TabPage();
			this.tpTroops = new System.Windows.Forms.TabPage();
			this.tpStates = new System.Windows.Forms.TabPage();
			this.tabDevBlog = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnChangeSize = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabSystem = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.DataList)).BeginInit();
			this.tabPanel.SuspendLayout();
			this.tpActors.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(6, 28);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 2;
			this.btnTest.Text = "Debug: Test";
			this.btnTest.UseVisualStyleBackColor = true;
			// 
			// DataList
			// 
			this.DataList.AllowUserToAddRows = false;
			this.DataList.AllowUserToResizeColumns = false;
			this.DataList.AllowUserToResizeRows = false;
			this.DataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataList.ColumnHeadersVisible = false;
			this.DataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ItemName});
			this.DataList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DataList.Location = new System.Drawing.Point(12, 27);
			this.DataList.MultiSelect = false;
			this.DataList.Name = "DataList";
			this.DataList.ReadOnly = true;
			this.DataList.RowHeadersVisible = false;
			this.DataList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataList.Size = new System.Drawing.Size(193, 530);
			this.DataList.TabIndex = 4;
			// 
			// Id
			// 
			this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Id.Frozen = true;
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Id.Width = 5;
			// 
			// ItemName
			// 
			this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ItemName.HeaderText = "Name";
			this.ItemName.Name = "ItemName";
			this.ItemName.ReadOnly = true;
			this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// tabPanel
			// 
			this.tabPanel.Controls.Add(this.tpActors);
			this.tabPanel.Controls.Add(this.tpClasses);
			this.tabPanel.Controls.Add(this.tpSkills);
			this.tabPanel.Controls.Add(this.tpItems);
			this.tabPanel.Controls.Add(this.tpWeapons);
			this.tabPanel.Controls.Add(this.tpArmors);
			this.tabPanel.Controls.Add(this.tpEnemies);
			this.tabPanel.Controls.Add(this.tpTroops);
			this.tabPanel.Controls.Add(this.tpStates);
			this.tabPanel.Controls.Add(this.tabSystem);
			this.tabPanel.Controls.Add(this.tabDevBlog);
			this.tabPanel.ItemSize = new System.Drawing.Size(64, 18);
			this.tabPanel.Location = new System.Drawing.Point(211, 27);
			this.tabPanel.Multiline = true;
			this.tabPanel.Name = "tabPanel";
			this.tabPanel.SelectedIndex = 0;
			this.tabPanel.Size = new System.Drawing.Size(660, 559);
			this.tabPanel.TabIndex = 8;
			// 
			// tpActors
			// 
			this.tpActors.Controls.Add(this.groupBox1);
			this.tpActors.Location = new System.Drawing.Point(4, 22);
			this.tpActors.Name = "tpActors";
			this.tpActors.Padding = new System.Windows.Forms.Padding(3);
			this.tpActors.Size = new System.Drawing.Size(652, 533);
			this.tpActors.TabIndex = 0;
			this.tpActors.Text = "角色";
			this.tpActors.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown3);
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.cbClasses);
			this.groupBox1.Controls.Add(this.tbActorProfile);
			this.groupBox1.Controls.Add(this.tbActorNickname);
			this.groupBox1.Controls.Add(this.tbActorName);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(322, 214);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "基础设置";
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(236, 95);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(80, 25);
			this.numericUpDown3.TabIndex = 12;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(150, 95);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(80, 25);
			this.numericUpDown2.TabIndex = 12;
			// 
			// cbClasses
			// 
			this.cbClasses.FormattingEnabled = true;
			this.cbClasses.Items.AddRange(new object[] {
            "World",
            "Hello"});
			this.cbClasses.Location = new System.Drawing.Point(10, 95);
			this.cbClasses.Name = "cbClasses";
			this.cbClasses.Size = new System.Drawing.Size(121, 27);
			this.cbClasses.TabIndex = 4;
			// 
			// tbActorProfile
			// 
			this.tbActorProfile.Location = new System.Drawing.Point(10, 147);
			this.tbActorProfile.Multiline = true;
			this.tbActorProfile.Name = "tbActorProfile";
			this.tbActorProfile.Size = new System.Drawing.Size(306, 48);
			this.tbActorProfile.TabIndex = 3;
			// 
			// tbActorNickname
			// 
			this.tbActorNickname.Location = new System.Drawing.Point(166, 45);
			this.tbActorNickname.Name = "tbActorNickname";
			this.tbActorNickname.Size = new System.Drawing.Size(150, 25);
			this.tbActorNickname.TabIndex = 2;
			// 
			// tbActorName
			// 
			this.tbActorName.Location = new System.Drawing.Point(10, 45);
			this.tbActorName.Name = "tbActorName";
			this.tbActorName.Size = new System.Drawing.Size(150, 25);
			this.tbActorName.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(232, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 19);
			this.label6.TabIndex = 2;
			this.label6.Text = "最大等级";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(146, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 19);
			this.label5.TabIndex = 2;
			this.label5.Text = "初始等级";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 19);
			this.label4.TabIndex = 2;
			this.label4.Text = "职业";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "人物描述";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(161, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "昵称";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "名称";
			// 
			// tpClasses
			// 
			this.tpClasses.Location = new System.Drawing.Point(4, 22);
			this.tpClasses.Name = "tpClasses";
			this.tpClasses.Padding = new System.Windows.Forms.Padding(3);
			this.tpClasses.Size = new System.Drawing.Size(652, 533);
			this.tpClasses.TabIndex = 1;
			this.tpClasses.Text = "职业";
			this.tpClasses.UseVisualStyleBackColor = true;
			// 
			// tpSkills
			// 
			this.tpSkills.Location = new System.Drawing.Point(4, 22);
			this.tpSkills.Name = "tpSkills";
			this.tpSkills.Padding = new System.Windows.Forms.Padding(3);
			this.tpSkills.Size = new System.Drawing.Size(652, 533);
			this.tpSkills.TabIndex = 2;
			this.tpSkills.Text = "技能";
			this.tpSkills.UseVisualStyleBackColor = true;
			// 
			// tpItems
			// 
			this.tpItems.Location = new System.Drawing.Point(4, 22);
			this.tpItems.Name = "tpItems";
			this.tpItems.Padding = new System.Windows.Forms.Padding(3);
			this.tpItems.Size = new System.Drawing.Size(652, 533);
			this.tpItems.TabIndex = 3;
			this.tpItems.Text = "物品";
			this.tpItems.UseVisualStyleBackColor = true;
			// 
			// tpWeapons
			// 
			this.tpWeapons.Location = new System.Drawing.Point(4, 22);
			this.tpWeapons.Name = "tpWeapons";
			this.tpWeapons.Padding = new System.Windows.Forms.Padding(3);
			this.tpWeapons.Size = new System.Drawing.Size(652, 533);
			this.tpWeapons.TabIndex = 4;
			this.tpWeapons.Text = "武器";
			this.tpWeapons.UseVisualStyleBackColor = true;
			// 
			// tpArmors
			// 
			this.tpArmors.Location = new System.Drawing.Point(4, 22);
			this.tpArmors.Name = "tpArmors";
			this.tpArmors.Padding = new System.Windows.Forms.Padding(3);
			this.tpArmors.Size = new System.Drawing.Size(652, 533);
			this.tpArmors.TabIndex = 5;
			this.tpArmors.Text = "防具";
			this.tpArmors.UseVisualStyleBackColor = true;
			// 
			// tpEnemies
			// 
			this.tpEnemies.Location = new System.Drawing.Point(4, 22);
			this.tpEnemies.Name = "tpEnemies";
			this.tpEnemies.Padding = new System.Windows.Forms.Padding(3);
			this.tpEnemies.Size = new System.Drawing.Size(652, 533);
			this.tpEnemies.TabIndex = 6;
			this.tpEnemies.Text = "敌人";
			this.tpEnemies.UseVisualStyleBackColor = true;
			// 
			// tpTroops
			// 
			this.tpTroops.Location = new System.Drawing.Point(4, 22);
			this.tpTroops.Name = "tpTroops";
			this.tpTroops.Padding = new System.Windows.Forms.Padding(3);
			this.tpTroops.Size = new System.Drawing.Size(652, 533);
			this.tpTroops.TabIndex = 7;
			this.tpTroops.Text = "敌群";
			this.tpTroops.UseVisualStyleBackColor = true;
			// 
			// tpStates
			// 
			this.tpStates.Location = new System.Drawing.Point(4, 22);
			this.tpStates.Name = "tpStates";
			this.tpStates.Padding = new System.Windows.Forms.Padding(3);
			this.tpStates.Size = new System.Drawing.Size(652, 533);
			this.tpStates.TabIndex = 8;
			this.tpStates.Text = "状态";
			this.tpStates.UseVisualStyleBackColor = true;
			// 
			// tabDevBlog
			// 
			this.tabDevBlog.Location = new System.Drawing.Point(4, 22);
			this.tabDevBlog.Name = "tabDevBlog";
			this.tabDevBlog.Padding = new System.Windows.Forms.Padding(3);
			this.tabDevBlog.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tabDevBlog.Size = new System.Drawing.Size(652, 533);
			this.tabDevBlog.TabIndex = 9;
			this.tabDevBlog.Text = "开发日志";
			this.tabDevBlog.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnTest);
			this.groupBox2.Location = new System.Drawing.Point(877, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(195, 555);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "开发者专用控制台";
			// 
			// btnChangeSize
			// 
			this.btnChangeSize.Location = new System.Drawing.Point(123, 563);
			this.btnChangeSize.Name = "btnChangeSize";
			this.btnChangeSize.Size = new System.Drawing.Size(82, 23);
			this.btnChangeSize.TabIndex = 12;
			this.btnChangeSize.Text = "修改最大项";
			this.btnChangeSize.UseVisualStyleBackColor = true;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(12, 563);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(105, 20);
			this.numericUpDown1.TabIndex = 13;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
			this.menuStrip1.TabIndex = 14;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 589);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 15;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(124, 17);
			this.toolStripStatusLabel1.Text = "Bug Editor by Xiaomai";
			// 
			// tabSystem
			// 
			this.tabSystem.Location = new System.Drawing.Point(4, 22);
			this.tabSystem.Name = "tabSystem";
			this.tabSystem.Padding = new System.Windows.Forms.Padding(3);
			this.tabSystem.Size = new System.Drawing.Size(652, 533);
			this.tabSystem.TabIndex = 10;
			this.tabSystem.Text = "系统设置";
			this.tabSystem.UseVisualStyleBackColor = true;
			// 
			// BugEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1084, 611);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnChangeSize);
			this.Controls.Add(this.tabPanel);
			this.Controls.Add(this.DataList);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "BugEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bug Editor V0.1";
			((System.ComponentModel.ISupportInitialize)(this.DataList)).EndInit();
			this.tabPanel.ResumeLayout(false);
			this.tpActors.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.DataGridView DataList;
		private System.Windows.Forms.TabControl tabPanel;
		private System.Windows.Forms.TabPage tpActors;
		private System.Windows.Forms.TabPage tpClasses;
		private System.Windows.Forms.TabPage tpSkills;
		private System.Windows.Forms.TabPage tpItems;
		private System.Windows.Forms.TabPage tpWeapons;
		private System.Windows.Forms.TabPage tpArmors;
		private System.Windows.Forms.TabPage tpEnemies;
		private System.Windows.Forms.TabPage tpTroops;
		private System.Windows.Forms.TabPage tpStates;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbActorProfile;
		private System.Windows.Forms.TextBox tbActorName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbActorNickname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnChangeSize;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbClasses;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TabPage tabDevBlog;
		private System.Windows.Forms.TabPage tabSystem;
	}
}