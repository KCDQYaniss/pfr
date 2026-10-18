namespace EFT.Passcodes;

public sealed class PasscodeList
{
	[JsonProperty("listId")]
	public string ListId; //Field offset: 0x10
	[JsonProperty("passcodes")]
	public string Passcodes; //Field offset: 0x18
	[JsonProperty("passcodeFormats")]
	public string PasscodeFormats; //Field offset: 0x20

	public PasscodeList() { }

	public bool TryGetParsedPasscodes(out string[] passcodes) { }

	public bool TryGetParsedPasscodesFormats(out string[] passcodeFormats) { }

}

