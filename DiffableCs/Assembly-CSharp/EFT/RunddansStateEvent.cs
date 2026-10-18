namespace EFT;

[Obfuscation(Exclude = True)]
public sealed class RunddansStateEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Dictionary <Objects>k__BackingField; //Field offset: 0x20

	public private Dictionary Objects
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int PlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public RunddansStateEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public Dictionary get_Objects() { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	public void Invoke(int playerId, Dictionary objects) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_Objects(Dictionary value) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

}

