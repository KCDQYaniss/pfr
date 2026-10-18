namespace EFT.InventoryLogic;

public class TapeItemTemplate : CompletableTemplate
{
	[CompilerGenerated]
	private string <TapeId>k__BackingField; //Field offset: 0x168
	[CompilerGenerated]
	private string <TranscriptText>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	private string <Subtitles>k__BackingField; //Field offset: 0x178

	[JsonProperty("Subtitles")]
	public string Subtitles
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[JsonProperty("TapeID")]
	public string TapeId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[JsonProperty("Transcript")]
	public string TranscriptText
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public TapeItemTemplate() { }

	[CompilerGenerated]
	public string get_Subtitles() { }

	[CompilerGenerated]
	public string get_TapeId() { }

	[CompilerGenerated]
	public string get_TranscriptText() { }

	[CompilerGenerated]
	public void set_Subtitles(string value) { }

	[CompilerGenerated]
	public void set_TapeId(string value) { }

	[CompilerGenerated]
	public void set_TranscriptText(string value) { }

}

