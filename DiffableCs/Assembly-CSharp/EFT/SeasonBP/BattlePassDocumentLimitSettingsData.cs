namespace EFT.SeasonBP;

public sealed class BattlePassDocumentLimitSettingsData
{
	internal sealed class BattlePassModeLimitData
	{
		[JsonProperty("gameMode")]
		public readonly EGameMode Mode; //Field offset: 0x10
		[JsonProperty("totalLimit")]
		public readonly int Limit; //Field offset: 0x14

		public BattlePassModeLimitData() { }

	}

	[JsonProperty("resetHours")]
	public readonly int ResetHours; //Field offset: 0x10
	[JsonProperty("limitsByGameMode")]
	public readonly IReadOnlyCollection Limits; //Field offset: 0x18

	public BattlePassDocumentLimitSettingsData() { }

}

