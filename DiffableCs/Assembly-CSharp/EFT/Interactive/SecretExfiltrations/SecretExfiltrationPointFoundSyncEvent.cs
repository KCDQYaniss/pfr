namespace EFT.Interactive.SecretExfiltrations;

[Obfuscation(Exclude = True)]
public class SecretExfiltrationPointFoundSyncEvent : SyncEventFromClient
{
	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x20
	public string ExitName; //Field offset: 0x28
	public bool ShareExitToGroup; //Field offset: 0x30

	public private int PlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public SecretExfiltrationPointFoundSyncEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	public void Invoke(int playerId, string exitName, bool shareExit) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

}

