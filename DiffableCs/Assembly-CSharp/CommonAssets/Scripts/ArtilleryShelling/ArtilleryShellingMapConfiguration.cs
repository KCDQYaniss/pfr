namespace CommonAssets.Scripts.ArtilleryShelling;

public struct ArtilleryShellingMapConfiguration
{
	public bool PlanedShellingOn; //Field offset: 0x0
	public float InitShellingTimer; //Field offset: 0x4
	public float InitCalledShellingTime; //Field offset: 0x8
	public float BeforeShellingSignalTime; //Field offset: 0xC
	public int ShellingCount; //Field offset: 0x10
	public int ZonesInShelling; //Field offset: 0x14
	public bool NewZonesForEachShelling; //Field offset: 0x18
	public ArtilleryShellingZone[] ShellingZones; //Field offset: 0x20
	public ArtilleryBrigade[] Brigades; //Field offset: 0x28
	public Vector2 PauseBetweenShellings; //Field offset: 0x30
	[JsonProperty("ArtilleryShellingAirDropSettings")]
	public ArtilleryShellingAirDropSettings ArtilleryShellingAirDropSettings; //Field offset: 0x38

}

