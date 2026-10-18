namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class QuestLocationObjectStateEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <SyncId>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x20

	public private bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int PlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int SyncId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public QuestLocationObjectStateEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	[CompilerGenerated]
	public int get_SyncId() { }

	public void Invoke(int playerRaidId, int netId, bool isActive) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_IsActive(bool value) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

	[CompilerGenerated]
	private void set_SyncId(int value) { }

}

