namespace EFT;

[Obfuscation(Exclude = True)]
public sealed class RunddansMessagesEvent : SyncEventFromServer
{
	internal enum EType
	{
		NoRequiredItem = 0,
		NonInteractive = 1,
	}

	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private EType <Type>k__BackingField; //Field offset: 0x1C

	public private int PlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private EType Type
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public RunddansMessagesEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	[CompilerGenerated]
	public EType get_Type() { }

	public void Invoke(int playerId, EType type) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

	[CompilerGenerated]
	private void set_Type(EType value) { }

}

