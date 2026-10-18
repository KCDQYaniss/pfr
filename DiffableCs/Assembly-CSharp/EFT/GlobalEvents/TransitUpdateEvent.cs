namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class TransitUpdateEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <EventOnly>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private Dictionary <Points>k__BackingField; //Field offset: 0x20

	public private bool EventOnly
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

	public private Dictionary Points
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public TransitUpdateEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public bool get_EventOnly() { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	[CompilerGenerated]
	public Dictionary get_Points() { }

	public void Invoke(int playerId, Dictionary pointsById, bool eventOnly) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_EventOnly(bool value) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

	[CompilerGenerated]
	private void set_Points(Dictionary value) { }

}

