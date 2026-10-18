namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class TransitGroupTimerEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <PointId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Dictionary <Timers>k__BackingField; //Field offset: 0x20

	public private int PointId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Dictionary Timers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public TransitGroupTimerEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_PointId() { }

	[CompilerGenerated]
	public Dictionary get_Timers() { }

	public void Invoke(int pointId, Dictionary playerTimers) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PointId(int value) { }

	[CompilerGenerated]
	private void set_Timers(Dictionary value) { }

}

