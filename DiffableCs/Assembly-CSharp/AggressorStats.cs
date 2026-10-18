//Type is in global namespace

[GenerateBinarySerialization]
public sealed class AggressorStats : IProfileDataContainer
{
	[JsonProperty("AccountId")]
	public string AccountId; //Field offset: 0x10
	[JsonProperty("ProfileId")]
	public string ProfileId; //Field offset: 0x18
	[JsonProperty("MainProfileNickname")]
	public string MainProfileNickname; //Field offset: 0x20
	[JsonProperty("Name")]
	public string Name; //Field offset: 0x28
	[JsonProperty("Side")]
	public EPlayerSide Side; //Field offset: 0x30
	[JsonProperty("PrestigeLevel")]
	public int PrestigeLevel; //Field offset: 0x34
	[JsonProperty("ColliderType")]
	public EBodyPartColliderType ColliderType; //Field offset: 0x38
	[JsonProperty("WeaponName")]
	public string WeaponName; //Field offset: 0x40
	[JsonProperty("Category")]
	public EMemberCategory Category; //Field offset: 0x48
	[JsonProperty("Role")]
	public WildSpawnType Role; //Field offset: 0x4C

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

	public AggressorStats() { }

	public AggressorStats(string accountId, string profileId, string name, string mainCharacterNickName, EPlayerSide side, EBodyPartColliderType colliderType, string weaponName, EMemberCategory memberCategory, WildSpawnType role, int prestigeLevel) { }

	private override string EFT.IProfileDataContainer.get_Nickname() { }

	private override int EFT.IProfileDataContainer.get_PrestigeLevel() { }

	private override string EFT.IProfileDataContainer.get_ProfileId() { }

	private override EPlayerSide EFT.IProfileDataContainer.get_Side() { }

	public virtual string ToString() { }

}

