namespace EFT.Prestige;

public sealed class PrestigeLevel : Conditional
{
	private const string IS_COMPLETION_VIEWED_KEY = "prestige_complete_{0}_isViewed"; //Field offset: 0x0
	private static readonly IReadOnlyDictionary _statusTransition; //Field offset: 0x0
	public readonly PrestigeTemplate Template; //Field offset: 0x58
	private Nullable _isViewed; //Field offset: 0x60
	[CompilerGenerated]
	private readonly ConditionsDict <Conditions>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private readonly Dictionary <Rewards>k__BackingField; //Field offset: 0x70

	public virtual ConditionsDict Conditions
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual string Description
	{
		 get { } //Length: 59
	}

	public virtual bool InstantComplete
	{
		 get { } //Length: 3
	}

	[JsonIgnore]
	public bool IsCompletionViewed
	{
		 get { } //Length: 427
		 set { } //Length: 359
	}

	public virtual ETaskPlayerSide PlayerSide
	{
		 get { } //Length: 6
	}

	public virtual bool ReadyToFail
	{
		 get { } //Length: 3
	}

	public virtual Dictionary Rewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual bool ServerOnly
	{
		 get { } //Length: 3
	}

	public virtual Sprite Sprite
	{
		 get { } //Length: 3
	}

	public virtual IReadOnlyDictionary StatusTransition
	{
		 get { } //Length: 83
	}

	private static PrestigeLevel() { }

	public PrestigeLevel(PrestigeTemplate template, Dictionary conditionCounters, PrestigeStatusData statusData = null) { }

	public virtual void CheckForStatusChange(EQuestStatus status, bool notify, bool fromServer, bool canFail, bool recursive = false) { }

	[CompilerGenerated]
	public virtual ConditionsDict get_Conditions() { }

	public virtual string get_Description() { }

	public virtual bool get_InstantComplete() { }

	public bool get_IsCompletionViewed() { }

	public virtual ETaskPlayerSide get_PlayerSide() { }

	public virtual bool get_ReadyToFail() { }

	[CompilerGenerated]
	public virtual Dictionary get_Rewards() { }

	public virtual bool get_ServerOnly() { }

	public virtual Sprite get_Sprite() { }

	public virtual IReadOnlyDictionary get_StatusTransition() { }

	public virtual Task LoadSprite(IImageLoader session) { }

	public void set_IsCompletionViewed(bool value) { }

	public virtual void SetStatus(EQuestStatus status, bool notify, bool fromServer) { }

}

