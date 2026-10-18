namespace EFT.Communications;

public abstract class ProfileChangeEventNotification : ProfileChangeNotification
{

	public virtual string Description
	{
		 get { } //Length: 193
	}

	public override ENotificationRequirements Requirement
	{
		 get { } //Length: 3
	}

	protected ProfileChangeEventNotification() { }

	[CompilerGenerated]
	private string <get_Description>b__3_0(KeyValuePair change) { }

	public virtual string get_Description() { }

	public override ENotificationRequirements get_Requirement() { }

}

