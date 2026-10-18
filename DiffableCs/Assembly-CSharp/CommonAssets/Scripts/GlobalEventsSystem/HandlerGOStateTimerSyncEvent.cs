namespace CommonAssets.Scripts.GlobalEventsSystem;

[Obfuscation(Exclude = True)]
public class HandlerGOStateTimerSyncEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private bool <TargetState>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <TimerID>k__BackingField; //Field offset: 0x1C

	public private bool TargetState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int TimerID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public HandlerGOStateTimerSyncEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public bool get_TargetState() { }

	[CompilerGenerated]
	public int get_TimerID() { }

	public void Invoke(bool targetState, int id) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_TargetState(bool value) { }

	[CompilerGenerated]
	private void set_TimerID(int value) { }

}

