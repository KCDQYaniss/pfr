namespace CommonAssets.Scripts.Cutscenes;

[Obfuscation(Exclude = True)]
public class ChangeFinalExitStateEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <playerId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private EFinalExitStatus <exitStatus>k__BackingField; //Field offset: 0x1C

	public private EFinalExitStatus exitStatus
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int playerId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ChangeFinalExitStateEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public EFinalExitStatus get_exitStatus() { }

	[CompilerGenerated]
	public int get_playerId() { }

	public void Invoke(int idPlayer, EFinalExitStatus status) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_exitStatus(EFinalExitStatus value) { }

	[CompilerGenerated]
	private void set_playerId(int value) { }

}

