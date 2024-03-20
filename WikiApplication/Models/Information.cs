namespace WikiApplication.Models;

public class Information : IComparable<Information>
{
	private string name;
	private string? category;
	private string? structure;
	private string? definition;

	public Information(string name, string? category = null, string? structure = null, string? definition = null)
	{
		this.name = name;
		this.category = category;
		this.structure = structure;
		this.definition = definition;
	}
	
	public string GetName() => name;
	public void SetName(string value) => name = value;

	public string? GetCategory() => category;
	public void SetCategory(string? value) => category = value;

	public string? GetStructure() => structure;
	public void SetStructure(string? value) => structure = value;

	public string? GetDefinition() => definition;
	public void SetDefinition(string? value) => definition = value;

	public int CompareTo(Information? other)
	{
		if (other is null)
			return 1;
		if (ReferenceEquals(this, other))
			return 0;
		
		return string.Compare(name, other.name, StringComparison.Ordinal);
	}

}