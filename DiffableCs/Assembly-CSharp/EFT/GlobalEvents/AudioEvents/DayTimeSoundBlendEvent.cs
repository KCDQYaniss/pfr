namespace EFT.GlobalEvents.AudioEvents;

public class DayTimeSoundBlendEvent : BaseEvent
{
	[CompilerGenerated]
	private EDayTimeBlendState <DayTimeBlendState>k__BackingField; //Field offset: 0x18

	public private EDayTimeBlendState DayTimeBlendState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public DayTimeSoundBlendEvent() { }

	[CompilerGenerated]
	public EDayTimeBlendState get_DayTimeBlendState() { }

	public void Invoke(EDayTimeBlendState state) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_DayTimeBlendState(EDayTimeBlendState value) { }

}

