namespace EFT.SeasonalRewards;

public sealed class SeasonalRewardNotificationManager : IConditionalNotificationManager
{
	private const string REWARD_RECEIVED_NOTIFICATION = "UI/Seasonal/RewardReceivedNotification{0}"; //Field offset: 0x0
	[CompilerGenerated]
	private readonly IImageLoader <ImageLoader>k__BackingField; //Field offset: 0x10

	public override IImageLoader ImageLoader
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public SeasonalRewardNotificationManager(IImageLoader imageLoader) { }

	[CompilerGenerated]
	public override IImageLoader get_ImageLoader() { }

	public override void NotifyConditionalStatusChanged(SeasonalReward reward) { }

	public override void NotifyConditionChanged(SeasonalReward reward) { }

	public override void NotifyReward(SeasonalReward reward, EQuestStatus status) { }

}

