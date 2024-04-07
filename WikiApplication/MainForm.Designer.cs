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
			bottomStatusStrip = new StatusStrip();
			feedbackStatusLabel = new ToolStripStatusLabel();
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
			searchPanel = new Panel();
			searchTextBox = new TextBox();
			searchButton = new FontAwesome.Sharp.IconButton();
			structureDataPanel = new Panel();
			structureGroupBox = new GroupBox();
			linearRadioButton = new RadioButton();
			nonLinearRadioButton = new RadioButton();
			structureLabel = new Label();
			structureLabelIcon = new FontAwesome.Sharp.IconPictureBox();
			categoryLabel = new Label();
			categoryLabelIcon = new FontAwesome.Sharp.IconPictureBox();
			editButton = new FontAwesome.Sharp.IconButton();
			nameLabel = new Label();
			nameLabelIcon = new FontAwesome.Sharp.IconPictureBox();
			descriptionLabel = new Label();
			descriptionLabelIcon = new FontAwesome.Sharp.IconPictureBox();
			descriptionTextBox = new TextBox();
			categoryComboBox = new ComboBox();
			nameTextBox = new TextBox();
			structureEditButtonsPanel = new Panel();
			deleteItemButton = new FontAwesome.Sharp.IconButton();
			loadButton = new FontAwesome.Sharp.IconButton();
			saveButton = new FontAwesome.Sharp.IconButton();
			clearButton = new FontAwesome.Sharp.IconButton();
			addNewButton = new FontAwesome.Sharp.IconButton();
			bottomStatusStrip.SuspendLayout();
			topMenuStrip.SuspendLayout();
			searchPanel.SuspendLayout();
			structureDataPanel.SuspendLayout();
			structureGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)structureLabelIcon).BeginInit();
			((System.ComponentModel.ISupportInitialize)categoryLabelIcon).BeginInit();
			((System.ComponentModel.ISupportInitialize)nameLabelIcon).BeginInit();
			((System.ComponentModel.ISupportInitialize)descriptionLabelIcon).BeginInit();
			structureEditButtonsPanel.SuspendLayout();
			SuspendLayout();
			// 
			// bottomStatusStrip
			// 
			bottomStatusStrip.Items.AddRange(new ToolStripItem[] { feedbackStatusLabel });
			bottomStatusStrip.Location = new Point(0, 689);
			bottomStatusStrip.Name = "bottomStatusStrip";
			bottomStatusStrip.Size = new Size(1002, 22);
			bottomStatusStrip.TabIndex = 0;
			bottomStatusStrip.Text = "statusStrip1";
			// 
			// feedbackStatusLabel
			// 
			feedbackStatusLabel.Name = "feedbackStatusLabel";
			feedbackStatusLabel.Size = new Size(987, 17);
			feedbackStatusLabel.Spring = true;
			feedbackStatusLabel.Text = "Status: Uninitialized";
			feedbackStatusLabel.TextAlign = ContentAlignment.BottomLeft;
			// 
			// topMenuStrip
			// 
			topMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			topMenuStrip.Location = new Point(0, 0);
			topMenuStrip.Name = "topMenuStrip";
			topMenuStrip.RenderMode = ToolStripRenderMode.Professional;
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
			structuresListView.Location = new Point(523, 32);
			structuresListView.Margin = new Padding(8);
			structuresListView.MultiSelect = false;
			structuresListView.Name = "structuresListView";
			structuresListView.Size = new Size(464, 643);
			structuresListView.TabIndex = 3;
			structuresListView.UseCompatibleStateImageBehavior = false;
			structuresListView.View = View.Details;
			structuresListView.SelectedIndexChanged += OnWikiItemSelectionChanged;
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
			// searchPanel
			// 
			searchPanel.BackColor = SystemColors.ControlLight;
			searchPanel.BorderStyle = BorderStyle.Fixed3D;
			searchPanel.Controls.Add(searchTextBox);
			searchPanel.Controls.Add(searchButton);
			searchPanel.Location = new Point(14, 32);
			searchPanel.Name = "searchPanel";
			searchPanel.Size = new Size(498, 93);
			searchPanel.TabIndex = 4;
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
			searchTextBox.KeyPress += OnSearchTextBoxKeyPress;
			// 
			// searchButton
			// 
			searchButton.BackColor = SystemColors.Control;
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
			searchButton.UseVisualStyleBackColor = false;
			searchButton.Click += OnSearchEvent;
			// 
			// structureDataPanel
			// 
			structureDataPanel.BackColor = SystemColors.ControlLight;
			structureDataPanel.BorderStyle = BorderStyle.Fixed3D;
			structureDataPanel.Controls.Add(structureGroupBox);
			structureDataPanel.Controls.Add(structureLabel);
			structureDataPanel.Controls.Add(structureLabelIcon);
			structureDataPanel.Controls.Add(categoryLabel);
			structureDataPanel.Controls.Add(categoryLabelIcon);
			structureDataPanel.Controls.Add(editButton);
			structureDataPanel.Controls.Add(nameLabel);
			structureDataPanel.Controls.Add(nameLabelIcon);
			structureDataPanel.Controls.Add(descriptionLabel);
			structureDataPanel.Controls.Add(descriptionLabelIcon);
			structureDataPanel.Controls.Add(descriptionTextBox);
			structureDataPanel.Controls.Add(categoryComboBox);
			structureDataPanel.Controls.Add(nameTextBox);
			structureDataPanel.Location = new Point(14, 131);
			structureDataPanel.Name = "structureDataPanel";
			structureDataPanel.Size = new Size(498, 406);
			structureDataPanel.TabIndex = 5;
			// 
			// structureGroupBox
			// 
			structureGroupBox.BackColor = SystemColors.Window;
			structureGroupBox.Controls.Add(linearRadioButton);
			structureGroupBox.Controls.Add(nonLinearRadioButton);
			structureGroupBox.FlatStyle = FlatStyle.System;
			structureGroupBox.Location = new Point(300, 169);
			structureGroupBox.Name = "structureGroupBox";
			structureGroupBox.Size = new Size(185, 167);
			structureGroupBox.TabIndex = 14;
			structureGroupBox.TabStop = false;
			// 
			// linearRadioButton
			// 
			linearRadioButton.AutoSize = true;
			linearRadioButton.Checked = true;
			linearRadioButton.Font = new Font("Segoe UI", 20F);
			linearRadioButton.ForeColor = SystemColors.GrayText;
			linearRadioButton.Location = new Point(10, 69);
			linearRadioButton.Name = "linearRadioButton";
			linearRadioButton.Size = new Size(107, 41);
			linearRadioButton.TabIndex = 1;
			linearRadioButton.TabStop = true;
			linearRadioButton.Text = "Linear";
			linearRadioButton.UseVisualStyleBackColor = true;
			// 
			// nonLinearRadioButton
			// 
			nonLinearRadioButton.AutoSize = true;
			nonLinearRadioButton.Font = new Font("Segoe UI", 20F);
			nonLinearRadioButton.ForeColor = SystemColors.GrayText;
			nonLinearRadioButton.Location = new Point(10, 22);
			nonLinearRadioButton.Name = "nonLinearRadioButton";
			nonLinearRadioButton.Size = new Size(169, 41);
			nonLinearRadioButton.TabIndex = 0;
			nonLinearRadioButton.Text = "Non-Linear";
			nonLinearRadioButton.UseVisualStyleBackColor = true;
			// 
			// structureLabel
			// 
			structureLabel.AutoSize = true;
			structureLabel.Font = new Font("Segoe UI", 16F);
			structureLabel.Location = new Point(328, 130);
			structureLabel.Name = "structureLabel";
			structureLabel.Size = new Size(100, 30);
			structureLabel.TabIndex = 13;
			structureLabel.Text = "Structure";
			// 
			// structureLabelIcon
			// 
			structureLabelIcon.BackColor = SystemColors.ControlLight;
			structureLabelIcon.ForeColor = SystemColors.ControlText;
			structureLabelIcon.IconChar = FontAwesome.Sharp.IconChar.ObjectUngroup;
			structureLabelIcon.IconColor = SystemColors.ControlText;
			structureLabelIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
			structureLabelIcon.Location = new Point(300, 131);
			structureLabelIcon.Name = "structureLabelIcon";
			structureLabelIcon.Size = new Size(32, 32);
			structureLabelIcon.TabIndex = 12;
			structureLabelIcon.TabStop = false;
			// 
			// categoryLabel
			// 
			categoryLabel.AutoSize = true;
			categoryLabel.Font = new Font("Segoe UI", 16F);
			categoryLabel.Location = new Point(328, 17);
			categoryLabel.Name = "categoryLabel";
			categoryLabel.Size = new Size(102, 30);
			categoryLabel.TabIndex = 11;
			categoryLabel.Text = "Category";
			// 
			// categoryLabelIcon
			// 
			categoryLabelIcon.BackColor = SystemColors.ControlLight;
			categoryLabelIcon.ForeColor = SystemColors.ControlText;
			categoryLabelIcon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
			categoryLabelIcon.IconColor = SystemColors.ControlText;
			categoryLabelIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
			categoryLabelIcon.Location = new Point(300, 18);
			categoryLabelIcon.Name = "categoryLabelIcon";
			categoryLabelIcon.Size = new Size(32, 32);
			categoryLabelIcon.TabIndex = 10;
			categoryLabelIcon.TabStop = false;
			// 
			// editButton
			// 
			editButton.BackColor = SystemColors.Control;
			editButton.FlatAppearance.BorderSize = 3;
			editButton.FlatStyle = FlatStyle.Popup;
			editButton.Font = new Font("Segoe UI", 15F);
			editButton.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
			editButton.IconColor = Color.Black;
			editButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			editButton.IconSize = 30;
			editButton.Location = new Point(300, 340);
			editButton.Margin = new Padding(16);
			editButton.Name = "editButton";
			editButton.Size = new Size(183, 50);
			editButton.TabIndex = 3;
			editButton.Text = "Apply Changes";
			editButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			editButton.UseVisualStyleBackColor = false;
			editButton.Click += OnEditEvent;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Font = new Font("Segoe UI", 16F);
			nameLabel.Location = new Point(39, 17);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(71, 30);
			nameLabel.TabIndex = 9;
			nameLabel.Text = "Name";
			// 
			// nameLabelIcon
			// 
			nameLabelIcon.BackColor = SystemColors.ControlLight;
			nameLabelIcon.ForeColor = SystemColors.ControlText;
			nameLabelIcon.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
			nameLabelIcon.IconColor = SystemColors.ControlText;
			nameLabelIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
			nameLabelIcon.Location = new Point(11, 18);
			nameLabelIcon.Name = "nameLabelIcon";
			nameLabelIcon.Size = new Size(32, 32);
			nameLabelIcon.TabIndex = 8;
			nameLabelIcon.TabStop = false;
			// 
			// descriptionLabel
			// 
			descriptionLabel.AutoSize = true;
			descriptionLabel.Font = new Font("Segoe UI", 16F);
			descriptionLabel.Location = new Point(39, 130);
			descriptionLabel.Name = "descriptionLabel";
			descriptionLabel.Size = new Size(122, 30);
			descriptionLabel.TabIndex = 7;
			descriptionLabel.Text = "Description";
			// 
			// descriptionLabelIcon
			// 
			descriptionLabelIcon.BackColor = SystemColors.ControlLight;
			descriptionLabelIcon.ForeColor = SystemColors.ControlText;
			descriptionLabelIcon.IconChar = FontAwesome.Sharp.IconChar.QuoteLeft;
			descriptionLabelIcon.IconColor = SystemColors.ControlText;
			descriptionLabelIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
			descriptionLabelIcon.Location = new Point(11, 131);
			descriptionLabelIcon.Name = "descriptionLabelIcon";
			descriptionLabelIcon.Size = new Size(32, 32);
			descriptionLabelIcon.TabIndex = 6;
			descriptionLabelIcon.TabStop = false;
			// 
			// descriptionTextBox
			// 
			descriptionTextBox.Font = new Font("Segoe UI", 10F);
			descriptionTextBox.Location = new Point(11, 169);
			descriptionTextBox.Multiline = true;
			descriptionTextBox.Name = "descriptionTextBox";
			descriptionTextBox.PlaceholderText = "Lorem ipsum dolor sit amet...";
			descriptionTextBox.Size = new Size(285, 221);
			descriptionTextBox.TabIndex = 4;
			// 
			// categoryComboBox
			// 
			categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			categoryComboBox.Font = new Font("Segoe UI", 20F);
			categoryComboBox.FormattingEnabled = true;
			categoryComboBox.ItemHeight = 37;
			categoryComboBox.Location = new Point(300, 55);
			categoryComboBox.Name = "categoryComboBox";
			categoryComboBox.Size = new Size(184, 45);
			categoryComboBox.TabIndex = 3;
			// 
			// nameTextBox
			// 
			nameTextBox.Font = new Font("Segoe UI", 20F);
			nameTextBox.Location = new Point(11, 55);
			nameTextBox.Margin = new Padding(16);
			nameTextBox.Multiline = true;
			nameTextBox.Name = "nameTextBox";
			nameTextBox.PlaceholderText = "Data Structure";
			nameTextBox.Size = new Size(283, 46);
			nameTextBox.TabIndex = 2;
			nameTextBox.KeyPress += OnNameTextBoxKeyPress;
			nameTextBox.MouseDoubleClick += OnClearEvent;
			// 
			// structureEditButtonsPanel
			// 
			structureEditButtonsPanel.BackColor = SystemColors.ControlLight;
			structureEditButtonsPanel.BorderStyle = BorderStyle.Fixed3D;
			structureEditButtonsPanel.Controls.Add(deleteItemButton);
			structureEditButtonsPanel.Controls.Add(loadButton);
			structureEditButtonsPanel.Controls.Add(saveButton);
			structureEditButtonsPanel.Controls.Add(clearButton);
			structureEditButtonsPanel.Controls.Add(addNewButton);
			structureEditButtonsPanel.Location = new Point(14, 543);
			structureEditButtonsPanel.Name = "structureEditButtonsPanel";
			structureEditButtonsPanel.Size = new Size(498, 132);
			structureEditButtonsPanel.TabIndex = 6;
			// 
			// deleteItemButton
			// 
			deleteItemButton.BackColor = SystemColors.Control;
			deleteItemButton.FlatAppearance.BorderSize = 3;
			deleteItemButton.FlatStyle = FlatStyle.Popup;
			deleteItemButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
			deleteItemButton.Font = new Font("Segoe UI", 20F);
			deleteItemButton.IconChar = FontAwesome.Sharp.IconChar.TrashCan;
			deleteItemButton.IconColor = Color.Black;
			deleteItemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			deleteItemButton.IconSize = 30;
			deleteItemButton.Location = new Point(330, 70);
			deleteItemButton.Margin = new Padding(16);
			deleteItemButton.Name = "deleteItemButton";
			deleteItemButton.Size = new Size(155, 46);
			deleteItemButton.TabIndex = 7;
			deleteItemButton.Text = "Delete";
			deleteItemButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			deleteItemButton.UseVisualStyleBackColor = false;
			deleteItemButton.Click += OnDeleteEvent;
			// 
			// loadButton
			// 
			loadButton.BackColor = SystemColors.Control;
			loadButton.FlatAppearance.BorderSize = 3;
			loadButton.FlatStyle = FlatStyle.Popup;
			loadButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
			loadButton.Font = new Font("Segoe UI", 20F);
			loadButton.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
			loadButton.IconColor = Color.Black;
			loadButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			loadButton.IconSize = 30;
			loadButton.Location = new Point(171, 70);
			loadButton.Margin = new Padding(16);
			loadButton.Name = "loadButton";
			loadButton.Size = new Size(155, 46);
			loadButton.TabIndex = 6;
			loadButton.Text = "Load";
			loadButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			loadButton.UseVisualStyleBackColor = false;
			// 
			// saveButton
			// 
			saveButton.BackColor = SystemColors.Control;
			saveButton.FlatAppearance.BorderSize = 3;
			saveButton.FlatStyle = FlatStyle.Popup;
			saveButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
			saveButton.Font = new Font("Segoe UI", 20F);
			saveButton.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
			saveButton.IconColor = Color.Black;
			saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			saveButton.IconSize = 30;
			saveButton.Location = new Point(12, 70);
			saveButton.Margin = new Padding(16);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(155, 46);
			saveButton.TabIndex = 5;
			saveButton.Text = "Save";
			saveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			saveButton.UseVisualStyleBackColor = false;
			// 
			// clearButton
			// 
			clearButton.BackColor = SystemColors.Control;
			clearButton.FlatAppearance.BorderSize = 3;
			clearButton.FlatStyle = FlatStyle.Popup;
			clearButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
			clearButton.Font = new Font("Segoe UI", 20F);
			clearButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
			clearButton.IconColor = Color.Black;
			clearButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			clearButton.IconSize = 30;
			clearButton.Location = new Point(330, 13);
			clearButton.Margin = new Padding(16);
			clearButton.Name = "clearButton";
			clearButton.Size = new Size(155, 46);
			clearButton.TabIndex = 4;
			clearButton.Text = "Clear";
			clearButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			clearButton.UseVisualStyleBackColor = false;
			clearButton.Click += OnClearEvent;
			// 
			// addNewButton
			// 
			addNewButton.BackColor = SystemColors.Control;
			addNewButton.FlatAppearance.BorderSize = 3;
			addNewButton.FlatStyle = FlatStyle.Popup;
			addNewButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
			addNewButton.Font = new Font("Segoe UI", 20F);
			addNewButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
			addNewButton.IconColor = Color.Black;
			addNewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			addNewButton.IconSize = 30;
			addNewButton.Location = new Point(12, 13);
			addNewButton.Margin = new Padding(16);
			addNewButton.Name = "addNewButton";
			addNewButton.Size = new Size(314, 46);
			addNewButton.TabIndex = 2;
			addNewButton.Text = "Add";
			addNewButton.TextAlign = ContentAlignment.MiddleRight;
			addNewButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			addNewButton.UseVisualStyleBackColor = false;
			addNewButton.Click += OnAddEvent;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(1002, 711);
			Controls.Add(structureEditButtonsPanel);
			Controls.Add(structureDataPanel);
			Controls.Add(searchPanel);
			Controls.Add(structuresListView);
			Controls.Add(bottomStatusStrip);
			Controls.Add(topMenuStrip);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = topMenuStrip;
			Name = "MainForm";
			Text = "Data Structure Wiki";
			Load += OnFormLoad;
			bottomStatusStrip.ResumeLayout(false);
			bottomStatusStrip.PerformLayout();
			topMenuStrip.ResumeLayout(false);
			topMenuStrip.PerformLayout();
			searchPanel.ResumeLayout(false);
			searchPanel.PerformLayout();
			structureDataPanel.ResumeLayout(false);
			structureDataPanel.PerformLayout();
			structureGroupBox.ResumeLayout(false);
			structureGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)structureLabelIcon).EndInit();
			((System.ComponentModel.ISupportInitialize)categoryLabelIcon).EndInit();
			((System.ComponentModel.ISupportInitialize)nameLabelIcon).EndInit();
			((System.ComponentModel.ISupportInitialize)descriptionLabelIcon).EndInit();
			structureEditButtonsPanel.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private StatusStrip bottomStatusStrip;
		private MenuStrip topMenuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem clearAllToolStripMenuItem;
		private ToolStripMenuItem loadToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator;
		private ToolStripMenuItem saveFileToolStripMenuItem;
		private ToolStripMenuItem saveAsToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripStatusLabel feedbackStatusLabel;
		private ListView structuresListView;
		private ColumnHeader nameColumnHeader;
		private ColumnHeader categoryColumnHeader;
		private Panel searchPanel;
		private TextBox searchTextBox;
		private FontAwesome.Sharp.IconButton searchButton;
		private Panel structureDataPanel;
		private Panel structureEditButtonsPanel;
		private FontAwesome.Sharp.IconButton deleteItemButton;
		private FontAwesome.Sharp.IconButton loadButton;
		private FontAwesome.Sharp.IconButton saveButton;
		private FontAwesome.Sharp.IconButton clearButton;
		private FontAwesome.Sharp.IconButton editButton;
		private FontAwesome.Sharp.IconButton addNewButton;
		private TextBox nameTextBox;
		private ComboBox categoryComboBox;
		private RadioButton linearRadioButton;
		private RadioButton nonLinearRadioButton;
		private TextBox descriptionTextBox;
		private Label descriptionLabel;
		private FontAwesome.Sharp.IconPictureBox descriptionLabelIcon;
		private Label nameLabel;
		private FontAwesome.Sharp.IconPictureBox nameLabelIcon;
		private Label structureLabel;
		private FontAwesome.Sharp.IconPictureBox structureLabelIcon;
		private Label categoryLabel;
		private FontAwesome.Sharp.IconPictureBox categoryLabelIcon;
		private GroupBox structureGroupBox;
	}
}
