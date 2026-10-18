namespace EFT.Utilities;

[JsonConverter(typeof(GlobalsDictionaryConverter))]
[JsonObject]
public sealed class GlobalsDictionary`1 : Dictionary
{
	[JsonExtensionData]
	private Dictionary _props; //Field offset: 0x0

	[JsonConstructor]
	private GlobalsDictionary`1() { }

	public static GlobalsDictionary op_Implicit(Dictionary dict) { }

	public static Dictionary op_Implicit(GlobalsDictionary dict) { }

	[OnDeserialized]
	private void UpdateValues(StreamingContext context) { }

}

