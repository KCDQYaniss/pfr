namespace EFT.SeasonBP;

public sealed class BattlePassDocumentLimitSettings
{
	public readonly int ResetHours; //Field offset: 0x10
	public readonly IReadOnlyDictionary Limits; //Field offset: 0x18

	public BattlePassDocumentLimitSettings(BattlePassDocumentLimitSettingsData data) { }

	public int GetLimit(EGameMode mode) { }

}

