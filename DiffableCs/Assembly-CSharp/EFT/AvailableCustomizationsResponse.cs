namespace EFT;

[JsonArray]
public sealed class AvailableCustomizationsResponse : List
{

	public AvailableCustomizationsResponse() { }

	[JsonConstructor]
	public AvailableCustomizationsResponse(IEnumerable collection) { }

}

