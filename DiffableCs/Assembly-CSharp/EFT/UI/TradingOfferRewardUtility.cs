namespace EFT.UI;

public static class TradingOfferRewardUtility
{

	public static int GetRequiredLoyaltyLevel(QuestReward reward) { }

	public static bool HasRequiredLoyaltyLevel(QuestReward reward, Profile profile) { }

	public static bool IsTradingOfferReward(QuestReward reward) { }

	public static bool TryGetTraderInfo(QuestReward reward, Profile profile, out TraderInfo traderInfo) { }

	public static bool TryGetTraderSettings(QuestReward reward, out TraderSettings traderSettings) { }

}

