using System.Media;

namespace WikiApplication;

public partial class MainForm : Form
{
	private readonly List<Information> wiki = new List<Information>(); // 6.2
	private List<string> categories = new List<string>();

	public MainForm()
	{
		InitializeComponent();
	}

	private void OnFormLoad(object sender, EventArgs e)
	{
		InitializeCategories(); // 6.4
		UpdateStructureListView();
		SetFeedbackStatus("Ok!");
	}

	// 6.4 - Populates the combobox and categories list
	private void InitializeCategories()
	{
		const string CategoriesFileName = "categories.txt";
		if (!File.Exists(CategoriesFileName))
		{
			MessageBoxUtils.ShowFatalError(
				$"Unable to find {CategoriesFileName} in {Application.ExecutablePath}, ensure it exists and is a line seperated list of categories!");
			Application.Exit();
		}

		// Read from the file and sanitize it.
		try
		{
			var fileLines = File.ReadAllLines(CategoriesFileName)
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
				$"An Unknown IO Exception occured while reading {CategoriesFileName} in {Application.ExecutablePath}\nMore information below:\n{ex}");
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

		// Select the structure
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
				SystemSounds.Asterisk.Play();
				SetFeedbackStatus($"Unable to find structure {info.GetStructure()}");
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
		bool hasSetOne = false;
		foreach (var radioButton in structureGroupBox.Controls.OfType<RadioButton>())
		{
			radioButton.Checked = !hasSetOne;
			hasSetOne = true;
		}

		categoryComboBox.SelectedIndex = 0; // Set category to first
	}

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
		var info = GetSelectedInformation();
		if (info == null)
		{
			SystemSounds.Asterisk.Play();
			SetFeedbackStatus("No selection found to delete");
			return;
		}

		if (MessageBoxUtils.PromptYesNo($"Are you sure you would like to delete {info.GetName()}?") != DialogResult.Yes)
		{
			return;
		}

		wiki.Remove(info);

		ClearDataPanel();
		UpdateStructureListView(skipSort: true);
		SetFeedbackStatus($"{info.GetName()} has been deleted.");
	}

	// 6.3 Event to call the add method
	private void OnAddEvent(object sender, EventArgs e)
	{
		string name = nameTextBox.Text.Trim();
		string category = categoryComboBox.Text;
		string definition = descriptionTextBox.Text;
		string? structure = GetStructureType();

		// Check if Name, Structure, and Category are invalid
		if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(structure) ||
		    string.IsNullOrWhiteSpace(category))
		{
			SystemSounds.Asterisk.Play();
			SetFeedbackStatus("Invalid input. Please provide a valid Name, Structure, and Category.");
			return;
		}

		if (!IsValidName(name))
		{
			SystemSounds.Asterisk.Play();
			SetFeedbackStatus("Input already exists in list!");
			return;
		}

		// Add the new Information to the wiki list
		wiki.Add(new Information(name, category, structure, definition));

		// Clear the data panel and update the structure list view
		ClearDataPanel();
		UpdateStructureListView();

		SetFeedbackStatus($"{name} has been added.");
	}

	private void SetFeedbackStatus(string status)
	{
		feedbackStatusLabel.Text = $@"Status: {status}";
	}

	// 6.5 method to check if a name is a duplicate
	private bool IsValidName(string name)
	{
		return !wiki.Exists(info => info.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));
	}
}