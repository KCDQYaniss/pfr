namespace EFT;

public sealed class BuildsResponse
{
	[JsonProperty("weaponBuilds")]
	public List WeaponBuilds; //Field offset: 0x10
	[JsonProperty("equipmentBuilds")]
	public List EquipmentBuilds; //Field offset: 0x18
	[JsonProperty("magazineBuilds")]
	public List MagBuilds; //Field offset: 0x20

	public BuildsResponse() { }

}

