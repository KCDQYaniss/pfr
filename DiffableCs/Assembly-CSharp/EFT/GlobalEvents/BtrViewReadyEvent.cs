namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class BtrViewReadyEvent : SyncEventFromClient
{
	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x20

	public int PlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public BtrViewReadyEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	public void Invoke(int playerRaidId) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	public void set_PlayerRaidId(int value) { }

}

