namespace CommonAssets.Scripts.GlobalEventsSystem;

public class RainIntensityChangedEvent : BaseEvent
{
	[CompilerGenerated]
	private ERainIntensity <RainIntensity>k__BackingField; //Field offset: 0x18

	public private ERainIntensity RainIntensity
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public RainIntensityChangedEvent() { }

	[CompilerGenerated]
	public ERainIntensity get_RainIntensity() { }

	public void Invoke(ERainIntensity rainIntensity) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_RainIntensity(ERainIntensity value) { }

}

