namespace EFT.InventoryLogic;

public sealed class SubtitleDTO
{
	[JsonProperty("id")]
	public string SubtitleId; //Field offset: 0x10
	[JsonProperty("subtitles")]
	public SubtitleParams[] Subtitles; //Field offset: 0x18

	public SubtitleDTO() { }

}

