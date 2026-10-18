namespace EFT;

public sealed class DialogSettings
{
	[JsonProperty("PaginationLinesCount")]
	public int PaginationLinesCount; //Field offset: 0x10
	[JsonProperty("SkipAnimationCooldownMs")]
	public int SkipAnimationCooldownMs; //Field offset: 0x14

	public DialogSettings() { }

}

