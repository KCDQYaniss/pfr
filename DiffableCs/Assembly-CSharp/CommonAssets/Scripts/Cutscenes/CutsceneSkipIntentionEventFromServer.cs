namespace CommonAssets.Scripts.Cutscenes;

[Obfuscation(Exclude = True)]
public sealed class CutsceneSkipIntentionEventFromServer : SyncEventFromServer
{
	[CompilerGenerated]
	private int <ProcessId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <PlayersCount>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int[] <SkippingPlayerIds>k__BackingField; //Field offset: 0x20

	public private int PlayersCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int ProcessId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int[] SkippingPlayerIds
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public CutsceneSkipIntentionEventFromServer() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_PlayersCount() { }

	[CompilerGenerated]
	public int get_ProcessId() { }

	[CompilerGenerated]
	public int[] get_SkippingPlayerIds() { }

	public void Invoke(int processId, int playersCount, int[] skippingPlayerIds) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PlayersCount(int value) { }

	[CompilerGenerated]
	private void set_ProcessId(int value) { }

	[CompilerGenerated]
	private void set_SkippingPlayerIds(int[] value) { }

}

