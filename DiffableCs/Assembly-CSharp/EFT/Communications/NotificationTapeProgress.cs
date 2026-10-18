namespace EFT.Communications;

public sealed class NotificationTapeProgress : NotificationWithText
{
	[CompilerGenerated]
	private Action OnStop; //Field offset: 0x38
	[CompilerGenerated]
	private float <AudioClipDuration>k__BackingField; //Field offset: 0x40

	public event Action OnStop
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private float AudioClipDuration
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public NotificationTapeProgress() { }

	[CompilerGenerated]
	public void add_OnStop(Action value) { }

	public virtual BaseNotificationView CreateView(INotificationViewFactory viewFactory) { }

	[CompilerGenerated]
	public float get_AudioClipDuration() { }

	public static NotificationTapeProgress New(string tapeName, float duration) { }

	[CompilerGenerated]
	public void remove_OnStop(Action value) { }

	public void RiseStopEvent() { }

	[CompilerGenerated]
	private void set_AudioClipDuration(float value) { }

}

