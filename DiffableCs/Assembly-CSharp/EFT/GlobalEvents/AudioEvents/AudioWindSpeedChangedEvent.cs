namespace EFT.GlobalEvents.AudioEvents;

public class AudioWindSpeedChangedEvent : BaseEvent
{
	[CompilerGenerated]
	private EWindSpeed <WindSpeed>k__BackingField; //Field offset: 0x18

	public private EWindSpeed WindSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public AudioWindSpeedChangedEvent() { }

	[CompilerGenerated]
	public EWindSpeed get_WindSpeed() { }

	public void Invoke(EWindSpeed windSpeed) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_WindSpeed(EWindSpeed value) { }

}

