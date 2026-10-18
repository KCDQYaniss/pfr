namespace CommonAssets.Scripts.Cutscenes;

[Obfuscation(Exclude = True)]
public class CutsceneSkipEventFromServer : SyncEventFromServer
{
	[CompilerGenerated]
	private int <processId>k__BackingField; //Field offset: 0x18

	public private int processId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public CutsceneSkipEventFromServer() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_processId() { }

	public void Invoke(int processId) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_processId(int value) { }

}

