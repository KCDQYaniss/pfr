namespace CommonAssets.Scripts.Cutscenes;

[Obfuscation(Exclude = True)]
public sealed class CutsceneSkipIntentionEventFromClient : SyncEventFromClient
{
	[CompilerGenerated]
	private int <ProcessId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <CutsceneId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <WantsToSkip>k__BackingField; //Field offset: 0x30

	public private string CutsceneId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int ProcessId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool WantsToSkip
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public CutsceneSkipIntentionEventFromClient() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public string get_CutsceneId() { }

	[CompilerGenerated]
	public int get_ProcessId() { }

	[CompilerGenerated]
	public bool get_WantsToSkip() { }

	public void Invoke(int processId, string cutsceneId, bool wantsToSkip) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_CutsceneId(string value) { }

	[CompilerGenerated]
	private void set_ProcessId(int value) { }

	[CompilerGenerated]
	private void set_WantsToSkip(bool value) { }

}

