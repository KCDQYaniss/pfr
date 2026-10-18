namespace EFT;

public sealed class CharacterSelectionBattlePassRewardsInfo
{
	[JsonProperty("battlePassId")]
	public string BattlePassId; //Field offset: 0x10
	[JsonProperty("completed")]
	public int Completed; //Field offset: 0x18
	[JsonProperty("total")]
	public int Total; //Field offset: 0x1C

	public CharacterSelectionBattlePassRewardsInfo() { }

}

