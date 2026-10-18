namespace CommonAssets.Scripts.Cutscenes;

[Obfuscation(Exclude = True)]
public class FinalExitZoneInitEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <seats>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <evacuateTime>k__BackingField; //Field offset: 0x1C

	public private int evacuateTime
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int seats
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public FinalExitZoneInitEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_evacuateTime() { }

	[CompilerGenerated]
	public int get_seats() { }

	public void Invoke(int seatsValue, int evacuateValue) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_evacuateTime(int value) { }

	[CompilerGenerated]
	private void set_seats(int value) { }

}

