namespace EFT;

public sealed class CharacterSelectionStoryChaptersInfo
{
	[JsonProperty("completed")]
	public int Completed; //Field offset: 0x10
	[JsonProperty("total")]
	public int Total; //Field offset: 0x14

	public CharacterSelectionStoryChaptersInfo() { }

}

