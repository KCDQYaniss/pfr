namespace EFT.Dialogs;

public sealed class BackendCombinedAnimationData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal SubtitleParams <ToCombinedAnimationData>b__8_0(BackendSubtitleParams subtitle) { }

	}

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

	public static BackendCombinedAnimationData Default
	{
		 get { } //Length: 775
	}

	[JsonConstructor]
	public BackendCombinedAnimationData(List animKeysWithParams, List secondaryAnimKeysWithParams, List lipSyncKeysWithParams, List subtitleKeysWithParams, MediaData mediaData) { }

	public static BackendCombinedAnimationData get_Default() { }

	public CombinedAnimationData ToCombinedAnimationData() { }

}

