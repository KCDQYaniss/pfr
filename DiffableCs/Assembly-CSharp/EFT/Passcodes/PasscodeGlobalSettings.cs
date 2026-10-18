namespace EFT.Passcodes;

public sealed class PasscodeGlobalSettings
{
	[JsonProperty("lists")]
	public PasscodeList[] Lists; //Field offset: 0x10

	public PasscodeGlobalSettings() { }

	public bool TryFindList(string listId, out PasscodeList passcodeList) { }

}

