namespace EFT.GlobalEvents;

public sealed class BrowserVisibilityChangedEvent : BaseEvent
{
	[CompilerGenerated]
	private bool <IsVisible>k__BackingField; //Field offset: 0x18

	public private bool IsVisible
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BrowserVisibilityChangedEvent() { }

	[CompilerGenerated]
	public bool get_IsVisible() { }

	public void Invoke(bool isVisible) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_IsVisible(bool value) { }

}

