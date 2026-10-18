namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class RallyZoneUpdateEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <ZoneId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private byte <PlayersInZone>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private byte <TotalAlive>k__BackingField; //Field offset: 0x1D

	public private byte PlayersInZone
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private byte TotalAlive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int ZoneId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public RallyZoneUpdateEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public byte get_PlayersInZone() { }

	[CompilerGenerated]
	public byte get_TotalAlive() { }

	[CompilerGenerated]
	public int get_ZoneId() { }

	public void Invoke(int zoneId, byte playersInZone, byte totalAlive) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PlayersInZone(byte value) { }

	[CompilerGenerated]
	private void set_TotalAlive(byte value) { }

	[CompilerGenerated]
	private void set_ZoneId(int value) { }

}

