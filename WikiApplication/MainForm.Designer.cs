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
			panel2 = new Panel();
			panel3 = new Panel();
			searchButton = new FontAwesome.Sharp.IconButton();
			searchTextBox = new TextBox();
			addNewButton = new FontAwesome.Sharp.IconButton();
			editButton = new FontAwesome.Sharp.IconButton();
			clearButton = new FontAwesome.Sharp.IconButton();
			deleteItemButton = new FontAwesome.Sharp.IconButton();
			loadButton = new FontAwesome.Sharp.IconButton();
			saveButton = new FontAwesome.Sharp.IconButton();
			statusStrip1.SuspendLayout();
			topMenuStrip.SuspendLayout();
			panel1.SuspendLayout();
			panel3.SuspendLayout();
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
			structuresListView.Location = new Point(521, 32);
			structuresListView.Margin = new Padding(8);
			structuresListView.Name = "structuresListView";
			structuresListView.Size = new Size(464, 643);
			structuresListView.TabIndex = 3;
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
			panel1.Controls.Add(searchTextBox);
			panel1.Controls.Add(searchButton);
			panel1.Location = new Point(12, 32);
			panel1.Name = "panel1";
			panel1.Size = new Size(498, 93);
			panel1.TabIndex = 4;
			// 
			// panel2
			// 
			panel2.Location = new Point(12, 150);
			panel2.Name = "panel2";
			panel2.Size = new Size(498, 387);
			panel2.TabIndex = 5;
			// 
			// panel3
			// 
			panel3.Controls.Add(deleteItemButton);
			panel3.Controls.Add(loadButton);
			panel3.Controls.Add(saveButton);
			panel3.Controls.Add(clearButton);
			panel3.Controls.Add(editButton);
			panel3.Controls.Add(addNewButton);
			panel3.Location = new Point(12, 543);
			panel3.Name = "panel3";
			panel3.Size = new Size(498, 132);
			panel3.TabIndex = 6;
			// 
			// searchButton
			// 
			searchButton.FlatAppearance.BorderSize = 3;
			searchButton.FlatStyle = FlatStyle.Popup;
			searchButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
			searchButton.Font = new Font("Segoe UI", 20F);
			searchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
			searchButton.IconColor = Color.Black;
			searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			searchButton.IconSize = 30;
			searchButton.Location = new Point(301, 24);
			searchButton.Margin = new Padding(16);
			searchButton.Name = "searchButton";
			searchButton.Size = new Size(184, 46);
			searchButton.TabIndex = 0;
			searchButton.Text = "Search";
			searchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			searchButton.UseVisualStyleBackColor = true;
			// 
			// searchTextBox
			// 
			searchTextBox.Font = new Font("Segoe UI", 20F);
			searchTextBox.Location = new Point(13, 24);
			searchTextBox.Margin = new Padding(16);
			searchTextBox.Multiline = true;
			searchTextBox.Name = "searchTextBox";
			searchTextBox.PlaceholderText = "Enter a query...";
			searchTextBox.Size = new Size(283, 46);
			searchTextBox.TabIndex = 1;
			// 
			// addNewButton
			// 
			addNewButton.FlatAppearance.BorderSize = 3;
			addNewButton.FlatStyle = FlatStyle.Popup;
			addNewButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
			addNewButton.Font = new Font("Segoe UI", 20F);
			addNewButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
			addNewButton.IconColor = Color.Black;
			addNewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			addNewButton.IconSize = 30;
			addNewButton.Location = new Point(12, 15);
			addNewButton.Margin = new Padding(16);
			addNewButton.Name = "addNewButton";
			addNewButton.Size = new Size(155, 46);
			addNewButton.TabIndex = 2;
			addNewButton.Text = "Add";
			addNewButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			addNewButton.UseVisualStyleBackColor = true;
			// 
			// editButton
			// 
			editButton.FlatAppearance.BorderSize = 3;
			editButton.FlatStyle = FlatStyle.Popup;
			editButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
			editButton.Font = new Font("Segoe UI", 20F);
			editButton.IconChar = FontAwesome.Sharp.IconChar.Search;
			editButton.IconColor = Color.Black;
			editButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			editButton.IconSize = 30;
			editButton.Location = new Point(171, 15);
			editButton.Margin = new Padding(16);
			editButton.Name = "editButton";
			editButton.Size = new Size(155, 46);
			editButton.TabIndex = 3;
			editButton.Text = "Edit";
			editButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			editButton.UseVisualStyleBackColor = true;
			// 
			// clearButton
			// 
			clearButton.FlatAppearance.BorderSize = 3;
			clearButton.FlatStyle = FlatStyle.Popup;
			clearButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
			clearButton.Font = new Font("Segoe UI", 20F);
			clearButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
			clearButton.IconColor = Color.Black;
			clearButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			clearButton.IconSize = 30;
			clearButton.Location = new Point(330, 15);
			clearButton.Margin = new Padding(16);
			clearButton.Name = "clearButton";
			clearButton.Size = new Size(155, 46);
			clearButton.TabIndex = 4;
			clearButton.Text = "Clear";
			clearButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			clearButton.UseVisualStyleBackColor = true;
			// 
			// deleteItemButton
			// 
			deleteItemButton.FlatAppearance.BorderSize = 3;
			deleteItemButton.FlatStyle = FlatStyle.Popup;
			deleteItemButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
			deleteItemButton.Font = new Font("Segoe UI", 20F);
			deleteItemButton.IconChar = FontAwesome.Sharp.IconChar.TrashCan;
			deleteItemButton.IconColor = Color.Black;
			deleteItemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			deleteItemButton.IconSize = 30;
			deleteItemButton.Location = new Point(330, 72);
			deleteItemButton.Margin = new Padding(16);
			deleteItemButton.Name = "deleteItemButton";
			deleteItemButton.Size = new Size(155, 46);
			deleteItemButton.TabIndex = 7;
			deleteItemButton.Text = "Delete";
			deleteItemButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			deleteItemButton.UseVisualStyleBackColor = true;
			// 
			// loadButton
			// 
			loadButton.FlatAppearance.BorderSize = 3;
			loadButton.FlatStyle = FlatStyle.Popup;
			loadButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
			loadButton.Font = new Font("Segoe UI", 20F);
			loadButton.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
			loadButton.IconColor = Color.Black;
			loadButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			loadButton.IconSize = 30;
			loadButton.Location = new Point(171, 72);
			loadButton.Margin = new Padding(16);
			loadButton.Name = "loadButton";
			loadButton.Size = new Size(155, 46);
			loadButton.TabIndex = 6;
			loadButton.Text = "Load";
			loadButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			loadButton.UseVisualStyleBackColor = true;
			// 
			// saveButton
			// 
			saveButton.FlatAppearance.BorderSize = 3;
			saveButton.FlatStyle = FlatStyle.Popup;
			saveButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
			saveButton.Font = new Font("Segoe UI", 20F);
			saveButton.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
			saveButton.IconColor = Color.Black;
			saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			saveButton.IconSize = 30;
			saveButton.Location = new Point(12, 72);
			saveButton.Margin = new Padding(16);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(155, 46);
			saveButton.TabIndex = 5;
			saveButton.Text = "Save";
			saveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			saveButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1002, 711);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(structuresListView);
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
			panel1.PerformLayout();
			panel3.ResumeLayout(false);
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
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ListView structuresListView;
		private ColumnHeader nameColumnHeader;
		private ColumnHeader categoryColumnHeader;
		private Panel panel1;
		private TextBox searchTextBox;
		private FontAwesome.Sharp.IconButton searchButton;
		private Panel panel2;
		private Panel panel3;
		private FontAwesome.Sharp.IconButton deleteItemButton;
		private FontAwesome.Sharp.IconButton loadButton;
		private FontAwesome.Sharp.IconButton saveButton;
		private FontAwesome.Sharp.IconButton clearButton;
		private FontAwesome.Sharp.IconButton editButton;
		private FontAwesome.Sharp.IconButton addNewButton;
		private FontAwesome.Sharp.Material.MaterialButton materialButton1;
	}
}
