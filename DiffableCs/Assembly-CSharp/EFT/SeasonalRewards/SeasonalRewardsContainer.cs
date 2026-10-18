namespace EFT.SeasonalRewards;

public sealed class SeasonalRewardsContainer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x8
		public static Func <>9__7_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal MongoID <ToDescriptor>b__7_0(KeyValuePair kvp) { }

		internal SeasonalRewardData <ToDescriptor>b__7_1(KeyValuePair kvp) { }

	}

	private readonly Dictionary _rewards; //Field offset: 0x10
	private readonly BindableEvent _onRewardClaimed; //Field offset: 0x18

	public IBindableEvent OnRewardClaimed
	{
		 get { } //Length: 5
	}

	public SeasonalRewardsContainer(Dictionary rewardsData) { }

	public void AddReward(MongoID seasonId, MongoID rewardId) { }

	public IBindableEvent get_OnRewardClaimed() { }

	public bool IsClaimed(MongoID seasonId, MongoID rewardId) { }

	public Dictionary ToDescriptor() { }

}

