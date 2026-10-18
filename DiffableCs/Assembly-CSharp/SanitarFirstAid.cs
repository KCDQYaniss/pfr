//Type is in global namespace

public class SanitarFirstAid : BotFirstAid
{
	private const string GRIZLY_KIT_ID = "590c657e86f77412b013051d"; //Field offset: 0x0
	private const string KIT_ID = "5e99711486f7744bfc4af328"; //Field offset: 0x0

	protected virtual float min_percent
	{
		 get { } //Length: 9
	}

	public SanitarFirstAid(BotOwner owner, Action callback) { }

	private void FindMedsById(string id) { }

	protected virtual void FirstAidApplied() { }

	protected virtual float get_min_percent() { }

	public static void LogToAllPArts(string info, ActiveHealthController hc) { }

	protected virtual void RefreshMeds() { }

	public virtual void SetRandomPartToHeal() { }

}

