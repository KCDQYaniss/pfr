namespace EFT.SeasonalRewards;

public sealed class SeasonalReward : Conditional, ISeasonalReward
{
	private static readonly IReadOnlyDictionary STATUS_TRANSITION; //Field offset: 0x0
	public readonly SeasonalRewardTemplate Template; //Field offset: 0x58
	[CompilerGenerated]
	private readonly ConditionsDict <Conditions>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private readonly Dictionary <Rewards>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private readonly RewardLocation <Location>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private readonly ImageData <Icon>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private readonly ImageData <Image>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private readonly PrestigeReward <PrestigeReward>k__BackingField; //Field offset: 0x90

	public override bool Claimed
	{
		 get { } //Length: 55
	}

	public virtual ConditionsDict Conditions
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual string Description
	{
		 get { } //Length: 59
	}

	private override MongoID EFT.SeasonalRewards.ISeasonalReward.Id
	{
		private get { } //Length: 43
	}

	public override ImageData Icon
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override ImageData Image
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual bool InstantComplete
	{
		 get { } //Length: 3
	}

	public override RewardLocation Location
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public string Name
	{
		 get { } //Length: 132
	}

	public override string NameLocalizationKey
	{
		 get { } //Length: 29
	}

	public virtual ETaskPlayerSide PlayerSide
	{
		 get { } //Length: 6
	}

	public override PrestigeReward PrestigeReward
	{
		[CompilerGenerated]
		 get { } //Length: 8
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

	private static SeasonalReward() { }

	public SeasonalReward(SeasonalRewardTemplate template, Dictionary conditionCounters, bool claimed) { }

	public virtual void CheckForStatusChange(EQuestStatus status, bool notify, bool fromServer, bool canFail, bool recursive = false) { }

	private override MongoID EFT.SeasonalRewards.ISeasonalReward.get_Id() { }

	public override bool get_Claimed() { }

	[CompilerGenerated]
	public virtual ConditionsDict get_Conditions() { }

	public virtual string get_Description() { }

	[CompilerGenerated]
	public override ImageData get_Icon() { }

	[CompilerGenerated]
	public override ImageData get_Image() { }

	public virtual bool get_InstantComplete() { }

	[CompilerGenerated]
	public override RewardLocation get_Location() { }

	public string get_Name() { }

	public override string get_NameLocalizationKey() { }

	public virtual ETaskPlayerSide get_PlayerSide() { }

	[CompilerGenerated]
	public override PrestigeReward get_PrestigeReward() { }

	public virtual bool get_ReadyToFail() { }

	[CompilerGenerated]
	public virtual Dictionary get_Rewards() { }

	public virtual bool get_ServerOnly() { }

	public virtual Sprite get_Sprite() { }

	public virtual IReadOnlyDictionary get_StatusTransition() { }

	public virtual Task LoadSprite(IImageLoader session) { }

	public virtual void SetStatus(EQuestStatus status, bool notify, bool fromServer) { }

}

