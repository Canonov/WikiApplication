namespace WikiApplication;

/// <summary>
/// Represents a piece of information for a data structure in the wiki application. - 6.1
/// Implements the IComparable interface to allow for comparison between different Information objects for sorting.
/// </summary>
public class Information : IComparable<Information>
{
	private string name;
	private string category;
	private string structure;
	private string definition;

	public Information(string name, string category, string structure, string? definition = null)
	{
		this.name = name;
		this.category = category;
		this.structure = structure;
		this.definition = definition ?? string.Empty;
	}

	public string GetName()
	{
		return name;
	}

	public void SetName(string value)
	{
		name = value;
	}

	public string? GetCategory()
	{
		return category;
	}

	public void SetCategory(string value)
	{
		category = value;
	}

	public string GetStructure()
	{
		return structure;
	}

	public void SetStructure(string value)
	{
		structure = value;
	}

	public string GetDefinition()
	{
		return definition;
	}

	public void SetDefinition(string value)
	{
		definition = value;
	}

	public int CompareTo(Information? other)
	{
		if (other is null) // Null typically is after
			return 1;
		if (ReferenceEquals(this, other)) // They're the same
			return 0;

		return string.Compare(name, other.name, StringComparison.Ordinal);
	}
}