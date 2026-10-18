namespace EFT.Passcodes;

public sealed class PasscodeLocationSettings
{
	[JsonProperty("passcodeEntries")]
	public PasscodeEntry[] Entries; //Field offset: 0x10

	public PasscodeLocationSettings() { }

	public bool TryFindEntry(string passcodeId, out PasscodeEntry passcodeEntry) { }

}

