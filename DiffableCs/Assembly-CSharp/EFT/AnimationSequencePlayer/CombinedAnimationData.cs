namespace EFT.AnimationSequencePlayer;

public sealed class CombinedAnimationData
{
	[JsonProperty("animations")]
	public List animKeysWithParams; //Field offset: 0x10
	[JsonProperty("secondaryAnimations")]
	public List secondaryAnimKeysWithParams; //Field offset: 0x18
	[JsonProperty("lipSyncs")]
	public List lipSyncKeysWithParams; //Field offset: 0x20
	[JsonProperty("subtitles")]
	public List subtitleKeysWithParams; //Field offset: 0x28
	[JsonProperty("media")]
	public MediaData mediaData; //Field offset: 0x30

	public static CombinedAnimationData Default
	{
		 get { } //Length: 394
	}

	[JsonConstructor]
	public CombinedAnimationData(List animKeysWithParams, List secondaryAnimKeysWithParams, List lipSyncKeysWithParams, List subtitleKeysWithParams, MediaData mediaData) { }

	public static CombinedAnimationData get_Default() { }

}

