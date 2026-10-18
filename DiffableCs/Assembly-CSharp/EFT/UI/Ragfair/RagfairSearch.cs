namespace EFT.UI.Ragfair;

public sealed class RagfairSearch
{
	public const string ANY_CURRENCY = "Currency/Any"; //Field offset: 0x0
	public readonly object Value; //Field offset: 0x10
	public readonly EFilterType Type; //Field offset: 0x18
	public readonly bool Add; //Field offset: 0x1C

	public string StringValue
	{
		 get { } //Length: 42
	}

	public RagfairSearch(EFilterType type, object value, bool add = true) { }

	public string DisplayName() { }

	public string get_StringValue() { }

}

