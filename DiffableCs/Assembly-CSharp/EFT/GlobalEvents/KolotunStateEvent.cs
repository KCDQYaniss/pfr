namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class KolotunStateEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <EventStage>k__BackingField; //Field offset: 0x1C

	public private int EventStage
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public KolotunStateEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_EventStage() { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	public void Invoke(bool isActive, int eventStage) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_EventStage(int value) { }

	[CompilerGenerated]
	private void set_IsActive(bool value) { }

}

