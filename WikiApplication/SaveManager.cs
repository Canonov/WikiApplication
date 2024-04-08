using System.Text;

namespace WikiApplication;

public class SaveManager
{
	public readonly List<Information> wiki;
	private string filePath = Path.Combine(Application.StartupPath, DefaultFileName);
	private const string DefaultFileName = "definitions.dat";
	private const string FileTypeFilter = "data files (*.dat)|*.dat|All files (*.*)|*.*";

	public SaveManager(List<Information> wiki)
	{
		this.wiki = wiki;
	}

	public void LoadFromFile()
	{
		using var stream = File.Open(filePath, FileMode.Open);
		using var reader = new BinaryReader(stream, Encoding.UTF8, false);

		int size = reader.ReadInt32();
		wiki.Clear();

		for (int i = 0; i < size; i++)
		{
			string name = reader.ReadString();
			string category = reader.ReadString();
			string structure = reader.ReadString();
			string definition = reader.ReadString();

			wiki.Add(new Information(name, category, structure, definition));
		}
	}

	public void SaveToFile()
	{
		using var stream = File.Open(filePath, FileMode.Create);
		using var writer = new BinaryWriter(stream, Encoding.UTF8, false);

		writer.Write(wiki.Count);

		foreach (var info in wiki)
		{ 
			writer.Write(info.GetName());
			writer.Write(info.GetCategory());
			writer.Write(info.GetStructure());
			writer.Write(info.GetDefinition());
		}
	}

	#region File Dialogs
	private OpenFileDialog GetOpenFileDialog() => new OpenFileDialog
	{
		Filter = @"data files (*.dat)|*.dat|All files (*.*)|*.*",
		InitialDirectory = Path.GetDirectoryName(filePath) ?? Application.StartupPath,
		FileName = Path.GetFileName(filePath) ?? DefaultFileName,
	};

	private SaveFileDialog GetSaveFileDialog() => new SaveFileDialog
	{
		Filter = @"data files (*.dat)|*.dat|All files (*.*)|*.*",
		InitialDirectory = Path.GetDirectoryName(filePath) ?? Application.StartupPath,
		FileName = Path.GetFileName(filePath) ?? DefaultFileName,
		AddExtension = true,
		DefaultExt = "dat",
		CheckWriteAccess = true,
	};

	#endregion
}