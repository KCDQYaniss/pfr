namespace EFT.Communications;

public abstract class ProfileChangeNotification`1 : Notification, IProfileChangeNotification
{
	[JsonProperty("Changes")]
	public Dictionary Changes; //Field offset: 0x0

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	protected ProfileChangeNotification`1() { }

	public override void Apply(IEftSession session) { }

	protected abstract void ApplySingleChange(IEftSession session, string entity, TValue value) { }

	public virtual bool get_ShowNotification() { }

}

