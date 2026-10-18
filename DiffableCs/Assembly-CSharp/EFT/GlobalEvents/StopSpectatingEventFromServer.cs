namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class StopSpectatingEventFromServer : SyncEventFromClient
{
	[CompilerGenerated]
	private int <PlayerRaidID>k__BackingField; //Field offset: 0x20

	public int PlayerRaidID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public StopSpectatingEventFromServer() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_PlayerRaidID() { }

	public void Invoke(int playerRaidId) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	public void set_PlayerRaidID(int value) { }

}

