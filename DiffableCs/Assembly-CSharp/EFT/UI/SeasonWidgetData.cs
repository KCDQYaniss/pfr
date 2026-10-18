namespace EFT.UI;

[IsReadOnly]
public struct SeasonWidgetData
{
	public readonly int BattlePassCompleted; //Field offset: 0x0
	public readonly int BattlePassTotal; //Field offset: 0x4
	public readonly int AvailableSeasonalRewards; //Field offset: 0x8

	private SeasonWidgetData(int battlePassCompleted, int battlePassTotal, int availableSeasonalRewards) { }

	public static SeasonWidgetData From(Profile profile, SeasonalRewardController seasonalRewardController) { }

	public static SeasonWidgetData From(OtherPlayerProfile profile) { }

}

