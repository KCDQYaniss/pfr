namespace EFT.Expansions;

public static class ExpansionsNotificationsParser
{

	public static NotificationExpansions Create(ExpansionsShopNotificationData data) { }

	public static NotificationExpansions FromBrowser(JObject message) { }

	public static NotificationExpansions FromLobbyBalance(UnparsedData data) { }

	public static NotificationExpansions FromLobbyBalanceIncreased(UnparsedData data) { }

	public static NotificationExpansions FromLobbyBonusesAdded(UnparsedData data) { }

	public static NotificationExpansions FromLobbyDocumentBalance(UnparsedData data) { }

	public static NotificationExpansions FromLobbyGameEditionUpgrade(UnparsedData data) { }

	public static NotificationExpansionsLabelsUpdated FromLobbyLabelsUpdated(UnparsedData data) { }

	public static NotificationExpansions FromLobbyMenuLabelsChanged(UnparsedData data) { }

	public static NotificationExpansions FromLobbyOfferPurchased(UnparsedData data) { }

	public static NotificationExpansions FromLobbyOfferReceived(UnparsedData data) { }

	public static NotificationExpansions FromLobbyOffersCompositionChanged(UnparsedData data) { }

	public static NotificationExpansions FromLobbySaleContentChanged(UnparsedData data) { }

	private static string GetLocalizedShopItemName(string itemId) { }

	private static EExpansionsNotificationType GetNotificationTypeFromSeverity(EExpansionsShopNotificationSeverity severity) { }

}

