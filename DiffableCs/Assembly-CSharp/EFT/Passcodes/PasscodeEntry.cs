namespace EFT.Passcodes;

public sealed class PasscodeEntry
{
	[JsonProperty("passcodeId")]
	public string PasscodeId; //Field offset: 0x10
	[JsonProperty("passcodeListId")]
	public string PasscodeListId; //Field offset: 0x18

	public PasscodeEntry() { }

}

