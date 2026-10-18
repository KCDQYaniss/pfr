namespace EFT;

[GenerateBinarySerialization]
public sealed class DamageStatsDescriptor
{
	[JsonProperty("Amount")]
	public float Amount; //Field offset: 0x10
	[JsonProperty("Type")]
	public EDamageType Type; //Field offset: 0x14
	[JsonProperty("SourceId")]
	public string SourceId; //Field offset: 0x18
	[JsonProperty("OverDamageFrom")]
	public Nullable OverDamageFrom; //Field offset: 0x20
	[JsonProperty("Blunt")]
	public bool Blunt; //Field offset: 0x28
	[JsonProperty("ImpactsCount")]
	public float ImpactsCount; //Field offset: 0x2C

	public DamageStatsDescriptor() { }

	public DamageStatsDescriptor(DamageStats damageStats) { }

}

