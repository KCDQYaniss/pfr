namespace EFT.SeasonBP;

public sealed class BattlePassReward : ISeasonalReward
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public MongoID templateId; //Field offset: 0x10

		public <>c__DisplayClass35_0() { }

		internal bool <get_Cost>b__0(BattlePassDocumentScheme doc) { }

	}

	private readonly BindableEvent _onClaimed; //Field offset: 0x10
	[CompilerGenerated]
	private readonly MongoID <Id>k__BackingField; //Field offset: 0x18
	public readonly BattlePassPage Page; //Field offset: 0x30
	private readonly BattlePassRewardData _template; //Field offset: 0x38
	private Dictionary _cost; //Field offset: 0x40
	public readonly int Index; //Field offset: 0x48
	[CompilerGenerated]
	private bool <Claimed>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private readonly ImageData <Icon>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly ImageData <Image>k__BackingField; //Field offset: 0x58
	private Nullable _sides; //Field offset: 0x60

	public BattlePass BattlePass
	{
		 get { } //Length: 27
	}

	public private override bool Claimed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public IReadOnlyDictionary Cost
	{
		 get { } //Length: 1245
	}

	public string DescriptionLocalizationKey
	{
		 get { } //Length: 225
	}

	public override ImageData Icon
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override MongoID Id
	{
		[CompilerGenerated]
		 get { } //Length: 21
	}

	public override ImageData Image
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override RewardLocation Location
	{
		 get { } //Length: 33
	}

	public override string NameLocalizationKey
	{
		 get { } //Length: 225
	}

	public IBindableEvent OnClaimed
	{
		 get { } //Length: 5
	}

	public override PrestigeReward PrestigeReward
	{
		 get { } //Length: 27
	}

	public EPlayerSide Sides
	{
		 get { } //Length: 177
	}

	public BattlePassReward(bool claimed, BattlePassRewardData template, BattlePassPage page, int index) { }

	public bool Claim() { }

	public BattlePass get_BattlePass() { }

	[CompilerGenerated]
	public override bool get_Claimed() { }

	public IReadOnlyDictionary get_Cost() { }

	public string get_DescriptionLocalizationKey() { }

	[CompilerGenerated]
	public override ImageData get_Icon() { }

	[CompilerGenerated]
	public override MongoID get_Id() { }

	[CompilerGenerated]
	public override ImageData get_Image() { }

	public override RewardLocation get_Location() { }

	public override string get_NameLocalizationKey() { }

	public IBindableEvent get_OnClaimed() { }

	public override PrestigeReward get_PrestigeReward() { }

	public EPlayerSide get_Sides() { }

	[CompilerGenerated]
	private void set_Claimed(bool value) { }

}

