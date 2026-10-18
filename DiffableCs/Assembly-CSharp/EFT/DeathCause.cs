namespace EFT;

[GenerateBinarySerialization]
public sealed class DeathCause
{
	[JsonProperty("DamageType")]
	public EDamageType DamageType; //Field offset: 0x10
	[JsonProperty("Side")]
	public EPlayerSide Side; //Field offset: 0x14
	[JsonProperty("Role")]
	public WildSpawnType Role; //Field offset: 0x18
	[JsonProperty("WeaponId")]
	public string WeaponId; //Field offset: 0x20

	public DeathCause() { }

}

