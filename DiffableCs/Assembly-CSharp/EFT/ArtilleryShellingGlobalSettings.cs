namespace EFT;

public sealed class ArtilleryShellingGlobalSettings
{
	[JsonProperty("ProjectileExplosionParams")]
	public ArtilleryProjectileExplosionParams ProjectileExplosionParams; //Field offset: 0x10
	[JsonProperty("ArtilleryMapsConfigs")]
	public Dictionary ArtilleryMapsConfigs; //Field offset: 0x18
	[JsonProperty("MaxCalledShellingCount")]
	public int MaxCalledShellingCount; //Field offset: 0x20

	public ArtilleryShellingGlobalSettings() { }

}

