namespace EFT.Communications;

public sealed class NotificationQuest : NotificationWithText
{
	[CompilerGenerated]
	private bool <ShowImmediately>k__BackingField; //Field offset: 0x38

	public virtual Nullable BackgroundColor
	{
		 get { } //Length: 170
	}

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 6
	}

	public virtual bool ShowImmediately
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public NotificationQuest() { }

	public virtual Nullable get_BackgroundColor() { }

	public virtual ENotificationIconType get_Icon() { }

	[CompilerGenerated]
	public virtual bool get_ShowImmediately() { }

	[CompilerGenerated]
	public virtual void set_ShowImmediately(bool value) { }

}

