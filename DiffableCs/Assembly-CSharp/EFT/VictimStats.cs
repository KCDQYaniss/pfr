namespace EFT;

[GenerateBinarySerialization]
public sealed class VictimStats : IUpdatable, IProfileDataContainer
{
	[JsonProperty("AccountId")]
	public string AccountId; //Field offset: 0x10
	[JsonProperty("ProfileId")]
	public string ProfileId; //Field offset: 0x18
	[JsonProperty("Name")]
	public string Name; //Field offset: 0x20
	[JsonProperty("Side")]
	public EPlayerSide Side; //Field offset: 0x28
	[JsonProperty("Time")]
	public TimeSpan Time; //Field offset: 0x30
	[JsonProperty("Level")]
	public int Level; //Field offset: 0x38
	[JsonProperty("PrestigeLevel")]
	public int PrestigeLevel; //Field offset: 0x3C
	[JsonProperty("BodyPart")]
	public EBodyPart BodyPart; //Field offset: 0x40
	[JsonProperty("Weapon")]
	public string Weapon; //Field offset: 0x48
	[JsonProperty("Distance")]
	public float Distance; //Field offset: 0x50
	[JsonProperty("Role")]
	public WildSpawnType Role; //Field offset: 0x54
	[JsonProperty("Location")]
	public string Location; //Field offset: 0x58

	private override string EFT.IProfileDataContainer.Nickname
	{
		private get { } //Length: 5
	}

	private override int EFT.IProfileDataContainer.PrestigeLevel
	{
		private get { } //Length: 4
	}

	private override string EFT.IProfileDataContainer.ProfileId
	{
		private get { } //Length: 5
	}

	private override EPlayerSide EFT.IProfileDataContainer.Side
	{
		private get { } //Length: 4
	}

	public VictimStats() { }

	public VictimStats(string accountId, string profileId, string name, EPlayerSide side, TimeSpan time, int level, EBodyPart part, string weapon, EDamageType damageType, float distance, WildSpawnType role, bool isAI) { }

	public override bool Compare(VictimStats other) { }

	private override string EFT.IProfileDataContainer.get_Nickname() { }

	private override int EFT.IProfileDataContainer.get_PrestigeLevel() { }

	private override string EFT.IProfileDataContainer.get_ProfileId() { }

	private override EPlayerSide EFT.IProfileDataContainer.get_Side() { }

	public override void UpdateFromAnotherItem(VictimStats other) { }

}

