namespace EFT.Communications;

public sealed class NotificationSelectedSeasonalPerks : ProfileChangeNotification
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string profileId; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <ApplySingleChange>b__0(Profile prof) { }

	}


	public virtual string Description
	{
		 get { } //Length: 153
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	public NotificationSelectedSeasonalPerks() { }

	protected virtual void ApplySingleChange(IEftSession session, string profileId, MongoID[] perkIds) { }

	public virtual string get_Description() { }

	public virtual bool get_ShowNotification() { }

}

