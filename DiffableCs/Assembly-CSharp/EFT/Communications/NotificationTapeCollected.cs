namespace EFT.Communications;

public sealed class NotificationTapeCollected : NotificationWithText, ICustomDurationNotification
{
	[CompilerGenerated]
	private bool <HasRecorder>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private float <AnimatorSpeed>k__BackingField; //Field offset: 0x3C

	public private override float AnimatorSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private bool HasRecorder
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public NotificationTapeCollected() { }

	public virtual BaseNotificationView CreateView(INotificationViewFactory viewFactory) { }

	[CompilerGenerated]
	public override float get_AnimatorSpeed() { }

	[CompilerGenerated]
	public bool get_HasRecorder() { }

	public static NotificationTapeCollected New(string tapeName, bool hasRecorder, float durationMul = 1) { }

	[CompilerGenerated]
	private void set_AnimatorSpeed(float value) { }

	[CompilerGenerated]
	private void set_HasRecorder(bool value) { }

}

