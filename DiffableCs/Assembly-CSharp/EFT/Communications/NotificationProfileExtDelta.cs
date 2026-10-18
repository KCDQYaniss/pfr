namespace EFT.Communications;

public sealed class NotificationProfileExtDelta : ProfileChangeEventNotification
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public string profileId; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal bool <ApplySingleChange>b__0(Profile prof) { }

	}


	public virtual ENotificationRequirements Requirement
	{
		 get { } //Length: 6
	}

	public NotificationProfileExtDelta() { }

	protected virtual void ApplySingleChange(IEftSession session, string profileId, Nullable experienceDelta) { }

	public virtual ENotificationRequirements get_Requirement() { }

}

