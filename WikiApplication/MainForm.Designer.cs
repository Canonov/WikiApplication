namespace WikiApplication
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			topMenuStrip = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			clearAllToolStripMenuItem = new ToolStripMenuItem();
			loadToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator = new ToolStripSeparator();
			saveFileToolStripMenuItem = new ToolStripMenuItem();
			saveAsToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			exitToolStripMenuItem = new ToolStripMenuItem();
			structuresListView = new ListView();
			nameColumnHeader = new ColumnHeader();
			categoryColumnHeader = new ColumnHeader();
			panel1 = new Panel();
			statusStrip1.SuspendLayout();
			topMenuStrip.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
			statusStrip1.Location = new Point(0, 689);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(1002, 22);
			statusStrip1.TabIndex = 0;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(987, 17);
			toolStripStatusLabel1.Spring = true;
			toolStripStatusLabel1.Text = "Status: Ok";
			toolStripStatusLabel1.TextAlign = ContentAlignment.BottomLeft;
			// 
			// topMenuStrip
			// 
			topMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			topMenuStrip.Location = new Point(0, 0);
			topMenuStrip.Name = "topMenuStrip";
			topMenuStrip.Size = new Size(1002, 24);
			topMenuStrip.TabIndex = 1;
			topMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearAllToolStripMenuItem, loadToolStripMenuItem, toolStripSeparator, saveFileToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "&File";
			// 
			// clearAllToolStripMenuItem
			// 
			clearAllToolStripMenuItem.Image = (Image)resources.GetObject("clearAllToolStripMenuItem.Image");
			clearAllToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
			clearAllToolStripMenuItem.Size = new Size(154, 22);
			clearAllToolStripMenuItem.Text = "Clear all Entries";
			// 
			// loadToolStripMenuItem
			// 
			loadToolStripMenuItem.Image = (Image)resources.GetObject("loadToolStripMenuItem.Image");
			loadToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			loadToolStripMenuItem.Size = new Size(154, 22);
			loadToolStripMenuItem.Text = "Load from file";
			// 
			// toolStripSeparator
			// 
			toolStripSeparator.Name = "toolStripSeparator";
			toolStripSeparator.Size = new Size(151, 6);
			// 
			// saveFileToolStripMenuItem
			// 
			saveFileToolStripMenuItem.Image = (Image)resources.GetObject("saveFileToolStripMenuItem.Image");
			saveFileToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
			saveFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
			saveFileToolStripMenuItem.Size = new Size(154, 22);
			saveFileToolStripMenuItem.Text = "&Save";
			// 
			// saveAsToolStripMenuItem
			// 
			saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			saveAsToolStripMenuItem.Size = new Size(154, 22);
			saveAsToolStripMenuItem.Text = "Save &As";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(151, 6);
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(154, 22);
			exitToolStripMenuItem.Text = "E&xit";
			// 
			// structuresListView
			// 
			structuresListView.Columns.AddRange(new ColumnHeader[] { nameColumnHeader, categoryColumnHeader });
			structuresListView.FullRowSelect = true;
			structuresListView.GridLines = true;
			structuresListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			structuresListView.Location = new Point(506, 8);
			structuresListView.Margin = new Padding(8);
			structuresListView.Name = "structuresListView";
			structuresListView.Size = new Size(464, 638);
			structuresListView.TabIndex = 2;
			structuresListView.UseCompatibleStateImageBehavior = false;
			structuresListView.View = View.Details;
			// 
			// nameColumnHeader
			// 
			nameColumnHeader.Text = "Name";
			nameColumnHeader.Width = 300;
			// 
			// categoryColumnHeader
			// 
			categoryColumnHeader.Text = "Category";
			categoryColumnHeader.Width = 160;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlLight;
			panel1.Controls.Add(structuresListView);
			panel1.Location = new Point(0, 27);
			panel1.Name = "panel1";
			panel1.Size = new Size(1002, 659);
			panel1.TabIndex = 3;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1002, 711);
			Controls.Add(panel1);
			Controls.Add(statusStrip1);
			Controls.Add(topMenuStrip);
			MainMenuStrip = topMenuStrip;
			Name = "MainForm";
			Text = "Data Structure Wiki";
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			topMenuStrip.ResumeLayout(false);
			topMenuStrip.PerformLayout();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private StatusStrip statusStrip1;
		private MenuStrip topMenuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem clearAllToolStripMenuItem;
		private ToolStripMenuItem loadToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator;
		private ToolStripMenuItem saveFileToolStripMenuItem;
		private ToolStripMenuItem saveAsToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ListView structuresListView;
		private ColumnHeader nameColumnHeader;
		private ColumnHeader categoryColumnHeader;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private Panel panel1;
	}
}
