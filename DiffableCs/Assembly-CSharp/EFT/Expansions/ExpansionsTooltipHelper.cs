namespace EFT.Expansions;

public static class ExpansionsTooltipHelper
{
	private static readonly Vector2 _tooltipOffset; //Field offset: 0x0

	private static ExpansionsTooltipHelper() { }

	public static void CloseTooltip() { }

	private static MultiLineInfo GetApparelText() { }

	public static int GetAvailableRowsToPurchase(ExtensionsSettings extensionsSettings, BonusController bonusController) { }

	private static MultiLineInfo GetAvailableStashRowsText(int availableRows) { }

	private static int GetPurchasedRows(BonusController bonusController) { }

	private static MultiLineInfo GetUnavailableText() { }

	public static void ShowApparelTooltip() { }

	public static void ShowAvailableStashRowsTooltip(int availableRows) { }

	private static void ShowTooltip(EExpansionsTooltipState state, MultiLineInfo multiLineInfo, Vector2 offset) { }

	public static void ShowUnavailableTooltip(Nullable offset = null) { }

}

