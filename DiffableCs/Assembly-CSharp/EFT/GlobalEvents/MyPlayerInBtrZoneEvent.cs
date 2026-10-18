namespace EFT.GlobalEvents;

public class MyPlayerInBtrZoneEvent : BaseEvent
{
	[CompilerGenerated]
	private bool <InsideZone>k__BackingField; //Field offset: 0x18

	public private bool InsideZone
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public MyPlayerInBtrZoneEvent() { }

	[CompilerGenerated]
	public bool get_InsideZone() { }

	public void Invoke(bool insideZone) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_InsideZone(bool value) { }

}

