namespace EFT.Interactive;

public class LootPointParameters
{
	public string Id; //Field offset: 0x10
	public bool Enabled; //Field offset: 0x18
	public bool useGravity; //Field offset: 0x19
	public bool randomRotation; //Field offset: 0x1A
	public float ChanceModifier; //Field offset: 0x1C
	public bool IsAlwaysSpawn; //Field offset: 0x20
	public bool isAlwaysTrySpawnLoot; //Field offset: 0x21
	public ELootRarity Rarity; //Field offset: 0x24
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public string[] LootSets; //Field offset: 0x28
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public string[] FilterInclusive; //Field offset: 0x30
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public string[] FilterExclusive; //Field offset: 0x38
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public LootableContainerParameters[] FilterExtended; //Field offset: 0x40
	public ClassVector3 Position; //Field offset: 0x48
	public ClassVector3 Rotation; //Field offset: 0x50
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public WeightedLootPointSpawnPosition[] GroupPositions; //Field offset: 0x58
	public bool IsStatic; //Field offset: 0x60
	public bool IsContainer; //Field offset: 0x61
	public byte SpawnChance; //Field offset: 0x62
	public string LootableContainersGroupId; //Field offset: 0x68

	public LootPointParameters() { }

}

