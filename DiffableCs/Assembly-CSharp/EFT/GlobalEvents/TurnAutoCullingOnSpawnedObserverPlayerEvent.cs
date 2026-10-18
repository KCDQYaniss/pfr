namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class TurnAutoCullingOnSpawnedObserverPlayerEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <PlayerRaidID>k__BackingField; //Field offset: 0x18

	public private int PlayerRaidID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public TurnAutoCullingOnSpawnedObserverPlayerEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_PlayerRaidID() { }

	public void Invoke(int playerId) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PlayerRaidID(int value) { }

}

