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
		var fileLines = File.ReadAllLines(CategoriesFileName)
			.Select(line => line.Trim())
			.Where(line => !string.IsNullOrWhiteSpace(line))
			.Distinct()
			.Order();

		categories = fileLines.ToList();

		categoryComboBox.DataSource = categories;
	}

	private void ClearDataPanel()
	{
		nameTextBox.Clear();
		descriptionTextBox.Clear();

		// Clear selected structure
		foreach (var radioButton in structureGroupBox.Controls.OfType<RadioButton>())
			radioButton.Checked = false;

		categoryComboBox.SelectedIndex = 1;
	}
}