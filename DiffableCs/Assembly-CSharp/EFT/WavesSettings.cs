namespace EFT;

public struct WavesSettings
{
	[JsonProperty("botAmount")]
	public EBotAmount BotAmount; //Field offset: 0x0
	[JsonProperty("botDifficulty")]
	public EBotDifficulty BotDifficulty; //Field offset: 0x4
	[JsonProperty("isBosses")]
	public bool IsBosses; //Field offset: 0x8
	[JsonProperty("isTaggedAndCursed")]
	public bool IsTaggedAndCursed; //Field offset: 0x9

	public WavesSettings(EBotAmount botAmount, EBotDifficulty botDifficulty, bool isBosses, bool isTaggedAndCursed) { }

}

