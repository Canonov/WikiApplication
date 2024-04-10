using System.Diagnostics;
using System.Media;
using Microsoft.VisualBasic.Logging;

namespace WikiApplication;

public partial class MainForm : Form
{
	private readonly List<Information> wiki = new List<Information>(); // 6.2

	private List<string> categories = new List<string>();
	private InformationSaveManager saveManager; // Handles saving and loading, 6.14

	public MainForm()
	{
		InitializeComponent();
		saveManager = new InformationSaveManager(wiki);
	}

	private void OnFormLoad(object sender, EventArgs e)
	{
		InitializeCategories(); // 6.4
		UpdateStructureListView();
		this.FormClosing += AutosaveOnFormClosing;
		SetFeedbackStatus("Ok!");
	}
	
	// Only allow regular characters.
	private void OnNameTextBoxKeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
			e.Handled = true;
	}

	#region Form Management

	// 6.4 - Populates the combobox and categories list
	private void InitializeCategories()
	{
		const string categoriesFileName = "categories.txt";
		if (!File.Exists(categoriesFileName))
		{
			MessageBoxUtils.ShowFatalError($"Unable to find {categoriesFileName} in {Application.StartupPath}," +
										   $" ensure it exists and is a line separated list of categories!");
			Application.Exit();
		}

		// Read from the file and sanitize it.
		try
		{
			var fileLines = File.ReadAllLines(categoriesFileName)
				.Select(line => line.Trim())
				.Where(line => !string.IsNullOrWhiteSpace(line))
				.Distinct()
				.Order();

			categories = fileLines.ToList();
			categoryComboBox.DataSource = categories;
		}
		catch (IOException ex)
		{
			MessageBoxUtils.ShowFatalError(
				$"An Unknown IO Exception occured while reading {categoriesFileName} in {Application.StartupPath}\nMore information below:\n{ex}");
			Application.Exit();
		}
	}

	// 6.9 sort and then display the Name and Category from the wiki information in the list.
	private void UpdateStructureListView(bool skipSort = false)
	{
		structuresListView.Items.Clear();
		if (wiki.Count == 0)
			return;

		if (!skipSort)
			wiki.Sort();

		// Get a sorted array of ListViewItems from the Wiki List
		var wikiItems = wiki.Select(x => x.ToListViewItem()).ToArray(); // Convert each to a ListViewItem

		structuresListView.Items.AddRange(wikiItems);
		structuresListView.Refresh();
	}

	// 6.6 Method to get the selected structure type (Linear or Non-Linear)
	private string? GetStructureType()
	{
		foreach (var radioButton in structureGroupBox.Controls.OfType<RadioButton>())
		{
			if (radioButton.Checked)
				return radioButton.Text;
		}
		return null;
	}

	// Get the currently selected entry, or null if nothing is selected.
	private Information? GetSelectedInformation()
	{
		if (structuresListView.SelectedItems.Count == 0)
			return null;

		int index = structuresListView.SelectedItems[0].Index;
		return wiki[index];
	}

	// 6.6 Method to set the selected structure type based on an index
	private void SetStructureType(int index)
	{
		if (index < 0 || index >= structureGroupBox.Controls.OfType<RadioButton>().Count())
			throw new ArgumentOutOfRangeException(nameof(index), @"Index is out of range of available radio buttons.");

		var radioButton = structureGroupBox.Controls.OfType<RadioButton>().ElementAt(index);
		radioButton.Checked = true;
	}

	// 6.11 Copy information to the data panel from an information
	private void SetDataPanel(Information info)
	{
		nameTextBox.Text = info.GetName();
		descriptionTextBox.Text = info.GetDefinition();

		// Get the category item equal to the info 
		var categoryItem = categoryComboBox.Items.OfType<string>()
			.FirstOrDefault(item => item.Equals(info.GetCategory(), StringComparison.OrdinalIgnoreCase));

		categoryComboBox.SelectedItem = categoryItem;

		// Find a matching radio button index for the structure type
		var radioButtons = structureGroupBox.Controls.OfType<RadioButton>().ToList();

		for (int i = 0; i < radioButtons.Count; i++)
		{
			if (radioButtons.ElementAt(i).Text == info.GetStructure())
			{
				SetStructureType(i);
				break;
			}
			if (i == radioButtons.Count - 1) // No matching radiobutton was found, use a default
			{
				SetFeedbackStatus($"Unable to find structure {info.GetStructure()}", FeedbackLevel.Warning);
				SetStructureType(0);
			}
		}
	}

	// 6.12 Method to clear the Textboxes, ComboBox, and Radio Buttons
	private void ClearDataPanel()
	{
		nameTextBox.Clear();
		descriptionTextBox.Clear();

		// Clear selected structure
		foreach (var radioButton in structureGroupBox.Controls.OfType<RadioButton>())
			radioButton.Checked = false;
		SetStructureType(0);

		categoryComboBox.SelectedIndex = 0; // Set category to first
	}

	#endregion

	#region Saving & Loading
	
	// On form closing, save the file - 6.15
	private void AutosaveOnFormClosing(object? sender, FormClosingEventArgs e)
	{
		Trace.Listeners.Add(new FileLogTraceListener("WikiApplication.autosave.log"));
		var result = saveManager.SaveFile(skipPrompt: true);
		
		if (!result.Success)
			MessageBoxUtils.ShowFatalError("An error occurred while saving the file, please check the logs for more information!");
	}

	// Save button click event - 6.14 
	private void OnSaveButtonClick(object sender, EventArgs e)
	{
		var result = saveManager.SaveFile();
		
		if (result.Success)
			SetFeedbackStatus("File saved successfully");
		else
			SetFeedbackStatus(result.Message, FeedbackLevel.Error);
	}

	// Load button click event - 6.14 
	private void OnLoadButtonClick(object sender, EventArgs e)
	{
		const string warnMsg = "Are you sure you'd like to load a new file?, this will overwrite all current data!";
		if (wiki.Count > 0 && MessageBoxUtils.PromptYesNo(warnMsg) != DialogResult.Yes)
			return;
		
		var result = saveManager.LoadFile();
		
		UpdateStructureListView();
		
		if (result.Success)
			SetFeedbackStatus("File loaded successfully");
		else
			SetFeedbackStatus(result.Message, FeedbackLevel.Error);
	}

	#endregion

	#region Add-Edit-Delete / Wiki Management


	// 6.11 When the selected item is changed, update the textboxes 
	private void OnWikiItemSelectionChanged(object sender, EventArgs e)
	{
		if (structuresListView.SelectedItems.Count == 0)
		{
			ClearDataPanel();
			return;
		}

		int index = structuresListView.SelectedItems[0].Index;
		SetDataPanel(wiki[index]);
	}

	// 6.12, 6.13 Event for both clear button and the Name TextBox Double Click
	private void OnClearEvent(object sender, EventArgs e)
	{
		ClearDataPanel();
		SetFeedbackStatus("Data Cleared");
	}

	// 6.7 Event to delete the currently selected item.
	private void OnDeleteEvent(object sender, EventArgs e)
	{
		using var trace = new TextWriterTraceListener(File.Open("trace-6.7.log", FileMode.Append));
		trace.WriteLine($"Entering Method {nameof(OnDeleteEvent)}");
		trace.WriteLine($"Event sender: {nameof(sender)} / {sender}");
		trace.WriteLine($"Eventargs: {nameof(e)} / {e}");
		trace.IndentLevel++;
		
		trace.WriteLine("Getting selected information");
		var info = GetSelectedInformation();
		
		if (info == null)
		{
			trace.WriteLine($"Info was null\nExiting Method {nameof(OnDeleteEvent)}");
			SetFeedbackStatus("No selection found to delete", FeedbackLevel.Warning);
			return;
		}
		trace.WriteLine("Info wasn't null, prompting user for confirmation");
		trace.WriteLine(info);

		if (MessageBoxUtils.PromptYesNo($"Are you sure you would like to delete {info.GetName()}?") != DialogResult.Yes)
		{
			trace.WriteLine($"User did not enter yes\nExiting Method {nameof(OnDeleteEvent)}");
			return;
		}
		
		trace.WriteLine($"User confirmed, removing {info.GetName()} from the wiki list");
		wiki.Remove(info);

		trace.WriteLine("Clearing Data Panel..");
		ClearDataPanel();
		trace.WriteLine("Updating Listview..");
		UpdateStructureListView(skipSort: true);
		trace.WriteLine("Setting feedback..");
		SetFeedbackStatus($"{info.GetName()} has been deleted.");
		
		trace.WriteLine($"Exiting Method {nameof(OnDeleteEvent)}");
	}

	// Method to validate the input fields for editing and adding
	private bool ValidateInput(string name, string? structure, string category, bool editNameUnchanged = false)
	{
		if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(structure) ||
			string.IsNullOrWhiteSpace(category))
		{
			MessageBoxUtils.ShowWarning("Invalid input. Please provide a valid Name, Structure, and Category.");
			return false;
		}

		if (!ValidName(name) && !editNameUnchanged)
		{
			SetFeedbackStatus("Input already exists in list!", FeedbackLevel.Warning);
			return false;
		}

		return true;
	}

	// 6.3 Event to call the add method
	private void OnAddEvent(object sender, EventArgs e)
	{
		string name = nameTextBox.Text.Trim();
		string category = categoryComboBox.Text;
		string definition = descriptionTextBox.Text;
		string? structure = GetStructureType();

		// Validate the input fields
		if (!ValidateInput(name, structure, category))
			return;

		// Add the new Information to the wiki list
		wiki.Add(new Information(name, category, structure!, definition));

		// Clear the data panel and update the structure list view
		ClearDataPanel();
		UpdateStructureListView();

		SetFeedbackStatus($"{name} has been added.");
	}

	// 6.8 Event for apply changes button, updates the info in the list
	private void OnEditEvent(object sender, EventArgs e)
	{
		var info = GetSelectedInformation();
		if (info == null)
		{
			SetFeedbackStatus("No information selected to edit, did you mean to Add it instead?", FeedbackLevel.Warning);
			return;
		}

		string name = nameTextBox.Text.Trim();
		string category = categoryComboBox.Text;
		string definition = descriptionTextBox.Text;
		string? structure = GetStructureType();
		bool nameUnchanged = info.GetName() == name;

		// Validate the input fields
		if (!ValidateInput(name, structure, category, nameUnchanged))
			return;

		info.SetName(name);
		info.SetCategory(category);
		info.SetDefinition(definition);
		info.SetStructure(structure!);

		ClearDataPanel();
		UpdateStructureListView();
		SetFeedbackStatus($"{name} has been updated.");
	}

	private void OnClearAllEvent(object sender, EventArgs e)
	{
		if (MessageBoxUtils.PromptYesNo("Are you sure you want to delete all entries?\n This is not reversible!") != DialogResult.Yes)
			return;

		wiki.Clear();
		UpdateStructureListView(true);
		SetFeedbackStatus("List Cleared");
	}

	#endregion

	#region Searching

	// 6.10 Event to perform a binary search for the data structure name
	private void OnSearchEvent(object sender, EventArgs e)
	{
		var query = searchTextBox.Text;

		if (string.IsNullOrEmpty(query))
		{
			SystemSounds.Asterisk.Play();
			SetFeedbackStatus("Please enter a search query");
			return;
		}

		// Perform binary search on the wiki list
		int index = wiki.BinarySearch(new Information(query, "", ""));

		if (index >= 0)
		{
			// Found the record, populate the input controls and highlight the name in the ListView
			structuresListView.SelectedIndices.Clear();
			structuresListView.Items[index].Selected = true;
			structuresListView.Items[index].EnsureVisible();

			SetFeedbackStatus("Record found!");
		}
		else
		{
			MessageBoxUtils.ShowWarning($"Search Query {query} was not found!"); // Record not found
		}

		// Clear the search input TextBox
		searchTextBox.Clear();
	}

	// If enter is pressed in the search box, redirect it to the search event
	private void OnSearchTextBoxKeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == (char)Keys.Enter)
		{
			e.Handled = true;
			OnSearchEvent(sender, e);
		}
	}

	#endregion

	#region Utility

	private void SetFeedbackStatus(string? status, FeedbackLevel level = FeedbackLevel.Notice)
	{
		level.GetSound()?.Play();
		feedbackStatusLabel.ForeColor = level.GetColor();
		feedbackStatusLabel.Text = $@"Status: {status ?? "Unknown Error"}";
	}

	// 6.5 method to check if a name is a duplicate
	private bool ValidName(string name)
	{
		using var trace = new TextWriterTraceListener(File.Open("trace-6.5.log", FileMode.Append));
		trace.WriteLine($"Entering Method {nameof(ValidName)}");
		trace.IndentLevel++;
		
		// Original Method
		bool valid = !wiki.Exists(info => info.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));
		
		trace.Write($"name: {name}");
		trace.Write($"is valid: {valid}");
		trace.WriteLine($"Exiting Method {nameof(ValidName)}");
		return valid;
	}

	#endregion
}