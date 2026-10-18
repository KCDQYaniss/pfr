namespace EFT;

[GenerateBinarySerialization]
public sealed class BattlePassProgressData
{
	[JsonProperty("battlePassId")]
	public MongoID BattlePassId; //Field offset: 0x10
	[JsonProperty("obtainedRewardIds")]
	public List ObtainedRewards; //Field offset: 0x28

	public BattlePassProgressData() { }

	public BattlePassProgressData(MongoID battlePassId) { }

}

