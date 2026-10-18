namespace EFT.Communications;

public sealed class SingletonWarningNotification : SingletonNotification
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

	public SingletonWarningNotification(string description, ENotificationDurationType duration = 0) { }

	[CompilerGenerated]
	public virtual string get_Description() { }

	public virtual ENotificationIconType get_Icon() { }

}

