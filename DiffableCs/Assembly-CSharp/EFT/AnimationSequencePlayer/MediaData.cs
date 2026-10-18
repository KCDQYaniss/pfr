namespace EFT.AnimationSequencePlayer;

public sealed class MediaData
{
	[JsonProperty("image")]
	public string imagePath; //Field offset: 0x10
	[JsonProperty("sound")]
	public string soundPath; //Field offset: 0x18
	[JsonProperty("music")]
	public string musicPath; //Field offset: 0x20

	public MediaData() { }

}

