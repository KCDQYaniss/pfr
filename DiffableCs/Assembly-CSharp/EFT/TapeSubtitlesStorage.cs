namespace EFT;

public class TapeSubtitlesStorage
{
	[CompilerGenerated]
	private static readonly TapeSubtitlesStorage <Instance>k__BackingField; //Field offset: 0x0
	private Dictionary _subtitlesData; //Field offset: 0x10

	public static TapeSubtitlesStorage Instance
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	private static TapeSubtitlesStorage() { }

	public TapeSubtitlesStorage() { }

	public void AddSubtitleData(MongoID subtitleKey, SubtitleParams[] data) { }

	[CompilerGenerated]
	public static TapeSubtitlesStorage get_Instance() { }

	public SubtitleParams[] GetTemplate(MongoID subtitleKey) { }

	public void SetData(Dictionary data) { }

	public bool TryGetTemplate(MongoID subtitleKey, out SubtitleParams[] data) { }

}

