namespace EFT.GlobalEvents.AudioEvents;

[Obfuscation(Exclude = True)]
public class RadioStationsSyncEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List <BroadcastData>k__BackingField; //Field offset: 0x20

	public private List BroadcastData
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

	public RadioStationsSyncEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public List get_BroadcastData() { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	public void Invoke(int playerRaidId, List broadcastData) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_BroadcastData(List value) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

}

