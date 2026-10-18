namespace EFT.SeasonalRewards;

public sealed class SeasonalRewardBook : ConditionalBook
{
	public readonly IReadOnlyList Templates; //Field offset: 0x88
	private readonly SeasonalRewardsContainer _claims; //Field offset: 0x90

	public SeasonalRewardBook(string profileId, EPlayerSide profileSide, SeasonalRewardsContainer claims, Dictionary conditionCounters) { }

	private bool ContainsTemplate(MongoID templateId) { }

	public virtual void Dispose() { }

	private bool IsClaimed(SeasonalRewardTemplate template) { }

	public virtual void LoadAll() { }

	public virtual void RemoveConditionalsWithoutTemplate() { }

	private void TryCreateSeasonalReward(SeasonalRewardTemplate template) { }

}

