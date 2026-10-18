namespace EFT.Communications;

public sealed class ContainUnremovableItemNotification : Notification
{
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x30

	public virtual string Description
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 6
	}

	public ContainUnremovableItemNotification() { }

	[CompilerGenerated]
	public virtual string get_Description() { }

	public virtual ENotificationIconType get_Icon() { }

	public static string GetLocalizedDescription() { }

}

