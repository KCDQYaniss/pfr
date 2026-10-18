namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class ChangeSpectatingTeammateEventFromServer : SyncEventFromServer
{
	[CompilerGenerated]
	private int <PlayerRaidID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <CurrentSpectatingTeammateRaidID>k__BackingField; //Field offset: 0x1C
	public Dictionary SpectatingTeammateCurrentHealth; //Field offset: 0x20

	public private int CurrentSpectatingTeammateRaidID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int PlayerRaidID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ChangeSpectatingTeammateEventFromServer() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_CurrentSpectatingTeammateRaidID() { }

	[CompilerGenerated]
	public int get_PlayerRaidID() { }

	public void Invoke(int playerRaidId, int teammateRaidID, Dictionary spectatingTeammateCurrentHealth) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_CurrentSpectatingTeammateRaidID(int value) { }

	[CompilerGenerated]
	public void set_PlayerRaidID(int value) { }

}

