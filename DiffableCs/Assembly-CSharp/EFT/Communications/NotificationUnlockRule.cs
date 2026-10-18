namespace EFT.Communications;

public sealed class NotificationUnlockRule : ProfileChangeEventNotification
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ApplySingleChange>b__2_0(Trader trader) { }

	}


	public virtual ENotificationRequirements Requirement
	{
		 get { } //Length: 6
	}

	public NotificationUnlockRule() { }

	protected virtual void ApplySingleChange(IEftSession session, string _, Nullable __) { }

	public virtual ENotificationRequirements get_Requirement() { }

}

