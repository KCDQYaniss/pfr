namespace EFT;

public sealed class ArtilleryShellingAirDropSettings
{
	public bool UseAirDrop; //Field offset: 0x10
	public int AirDropTime; //Field offset: 0x14
	public string LootTemplateId; //Field offset: 0x18
	public Vector3 AirDropPosition; //Field offset: 0x20

	public ArtilleryShellingAirDropSettings() { }

}

