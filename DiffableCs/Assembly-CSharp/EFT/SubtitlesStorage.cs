namespace EFT;

public sealed class SubtitlesStorage
{
	[CompilerGenerated]
	private static readonly SubtitlesStorage <Instance>k__BackingField; //Field offset: 0x0
	private readonly Dictionary _subtitlesData; //Field offset: 0x10

	public static SubtitlesStorage Instance
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	private static SubtitlesStorage() { }

	public SubtitlesStorage() { }

	public void AddSubtitleData(Dictionary data) { }

	public void AddSubtitleData(MongoID subtitleKey, SubtitleParams[] data) { }

	[CompilerGenerated]
	public static SubtitlesStorage get_Instance() { }

	public SubtitleParams[] GetSubtitleData(MongoID subtitleKey) { }

	public bool TryGetSubtitleData(MongoID subtitleKey, out SubtitleParams[] data) { }

}

