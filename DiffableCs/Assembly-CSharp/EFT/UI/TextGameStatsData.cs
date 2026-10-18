namespace EFT.UI;

public class TextGameStatsData
{
	public List statGroups; //Field offset: 0x10

	public TextGameStatsData() { }

	public void AddGroup(StatGroup group) { }

	public static TextGameStatsData GetInitialData(TextGameStatsData sourceData, BaseTraderDialogController dialogController) { }

}

