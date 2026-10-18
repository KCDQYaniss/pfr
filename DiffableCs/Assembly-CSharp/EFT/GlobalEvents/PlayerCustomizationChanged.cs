namespace EFT.GlobalEvents;

public sealed class PlayerCustomizationChanged : BaseEvent
{
	[CompilerGenerated]
	private CustomizationSuite <Suite>k__BackingField; //Field offset: 0x18

	public private CustomizationSuite Suite
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public PlayerCustomizationChanged() { }

	[CompilerGenerated]
	public CustomizationSuite get_Suite() { }

	public void Invoke(CustomizationSuite suite) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_Suite(CustomizationSuite value) { }

}

