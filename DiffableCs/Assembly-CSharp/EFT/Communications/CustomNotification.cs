namespace EFT.Communications;

public sealed class CustomNotification : Notification
{
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly ENotificationIconType <Icon>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly Nullable <TextColor>k__BackingField; //Field offset: 0x3C

	public virtual string Description
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public virtual ENotificationIconType Icon
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual Nullable TextColor
	{
		[CompilerGenerated]
		 get { } //Length: 17
	}

	public CustomNotification(string description, ENotificationDurationType duration = 0, ENotificationIconType icon = 0, Nullable textColor = null, bool rawText = true) { }

	[CompilerGenerated]
	public virtual string get_Description() { }

	[CompilerGenerated]
	public virtual ENotificationIconType get_Icon() { }

	[CompilerGenerated]
	public virtual Nullable get_TextColor() { }

}

