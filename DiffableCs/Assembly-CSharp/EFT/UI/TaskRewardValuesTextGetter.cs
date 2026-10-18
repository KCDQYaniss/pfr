namespace EFT.UI;

public static class TaskRewardValuesTextGetter
{
	private const string STATS_TYPE_LOCALIZATION_KEY = "Rewards/Type/Stats"; //Field offset: 0x0
	private const string TRADE_OFFER_TYPE_KEY = "Rewards/Type/TradeOffer"; //Field offset: 0x0
	public const string TARCOIN_ITEM_TEMPLATE_ID = "69dd0de23dfe95d9e70b5ebb"; //Field offset: 0x0

	public static Item CreateTarcoinPreviewItem() { }

	private static string GetLocalizedRewardDescription(QuestReward reward) { }

	private static void GetRewardValues(QuestReward reward, out string typeText, out string nameText, out string valueText, out string descriptionText) { }

	public static void GetRewardValuesText(QuestReward reward, out string typeText, out string nameText, out string valueText, out string descriptionText) { }

}

