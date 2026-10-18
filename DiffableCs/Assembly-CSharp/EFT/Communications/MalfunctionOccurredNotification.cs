namespace EFT.Communications;

public sealed class MalfunctionOccurredNotification : Notification
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

	public MalfunctionOccurredNotification(EMalfunctionState state) { }

	[CompilerGenerated]
	public virtual string get_Description() { }

	public virtual ENotificationIconType get_Icon() { }

	private static string GetLocalizedDescription(EMalfunctionState state) { }

}

