namespace EFT.SeasonBP;

public sealed class BattlePassPage : IBattlePassPage, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public BattlePassReward reward; //Field offset: 0x10
		public BattlePassPage <>4__this; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

		internal void <.ctor>b__0() { }

	}

	private readonly BindableEvent _onRewardClaimed; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; //Field offset: 0x18
	private readonly BattlePassPageData _template; //Field offset: 0x20
	public readonly BattlePass BattlePass; //Field offset: 0x28
	[CompilerGenerated]
	private readonly int <RewardCount>k__BackingField; //Field offset: 0x30
	private readonly HashSet _rewards; //Field offset: 0x38
	private readonly CompositeDisposable _unsubscriber; //Field offset: 0x40

	public override bool CanBuy
	{
		 get { } //Length: 175
	}

	public override int Index
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public override IBindableEvent OnRewardClaimed
	{
		 get { } //Length: 5
	}

	public override int RequirementCount
	{
		 get { } //Length: 39
	}

	public int RequirementProgress
	{
		 get { } //Length: 147
	}

	public int RewardCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public override IReadOnlyCollection Rewards
	{
		 get { } //Length: 5
	}

	public override int RewardsClaimed
	{
		 get { } //Length: 363
	}

	public BattlePassPage(int index, BattlePassPageData template, BattlePass battlePass, IReadOnlyCollection claimedRewards, int rewardStartIndex) { }

	public override void Dispose() { }

	public override bool get_CanBuy() { }

	[CompilerGenerated]
	public override int get_Index() { }

	public override IBindableEvent get_OnRewardClaimed() { }

	public override int get_RequirementCount() { }

	public int get_RequirementProgress() { }

	[CompilerGenerated]
	public int get_RewardCount() { }

	public override IReadOnlyCollection get_Rewards() { }

	public override int get_RewardsClaimed() { }

}

