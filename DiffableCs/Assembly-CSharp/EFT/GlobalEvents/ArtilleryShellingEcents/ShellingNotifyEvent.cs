namespace EFT.GlobalEvents.ArtilleryShellingEcents;

[Obfuscation(Exclude = True)]
public class ShellingNotifyEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private string <ZoneId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int[] <PlayersIDs>k__BackingField; //Field offset: 0x20

	public private int[] PlayersIDs
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private string ZoneId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ShellingNotifyEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int[] get_PlayersIDs() { }

	[CompilerGenerated]
	public string get_ZoneId() { }

	public void Invoke(int[] playerIds, string zoneId) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PlayersIDs(int[] value) { }

	[CompilerGenerated]
	private void set_ZoneId(string value) { }

}

