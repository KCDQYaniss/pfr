namespace EFT.SeasonalRewards;

public abstract class SeasonalRewardController : ConditionalController
{
	[CompilerGenerated]
	private SeasonalRewardBook <SeasonalRewards>k__BackingField; //Field offset: 0x60
	public readonly IBindableEvent OnRewardClaimed; //Field offset: 0x68

	public private SeasonalRewardBook SeasonalRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected SeasonalRewardController(Profile profile, InventoryController inventoryController) { }

	public virtual OperationResult ApplyReward(SeasonalReward conditional, ItemController itemController, bool simulate) { }

	protected virtual ConditionalBook CreateConditionalList() { }

	[CompilerGenerated]
	public SeasonalRewardBook get_SeasonalRewards() { }

	public bool IsClaimed(SeasonalReward reward) { }

	[CompilerGenerated]
	private void set_SeasonalRewards(SeasonalRewardBook value) { }

}

