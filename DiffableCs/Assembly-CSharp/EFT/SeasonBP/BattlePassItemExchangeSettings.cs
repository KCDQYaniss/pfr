namespace EFT.SeasonBP;

public sealed class BattlePassItemExchangeSettings
{
	public readonly int RequiredDocuments; //Field offset: 0x10
	public readonly ImageData Image; //Field offset: 0x18
	public readonly Item Item; //Field offset: 0x20

	public BattlePassItemExchangeSettings(BattlePassItemExchangeSettingsData data) { }

}

