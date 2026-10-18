namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class HalloweenSyncStateEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private EEventState <EventState>k__BackingField; //Field offset: 0x18

	public private EEventState EventState
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public HalloweenSyncStateEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public EEventState get_EventState() { }

	public void Invoke(EEventState eventState) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_EventState(EEventState value) { }

}

