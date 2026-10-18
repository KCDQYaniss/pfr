namespace EFT.Hideout;

public sealed class HideoutCustomizationIcons : SerializedScriptableObject
{
	public Dictionary Areas; //Field offset: 0x58
	public Dictionary Floors; //Field offset: 0x60
	public Dictionary Walls; //Field offset: 0x68
	public Dictionary Ceilings; //Field offset: 0x70
	public Dictionary ShootingRangeMarks; //Field offset: 0x78
	public Dictionary ShootingRangeMarkTextures; //Field offset: 0x80
	private Dictionary _allSprites; //Field offset: 0x88

	public HideoutCustomizationIcons() { }

	public Sprite GetSprite(string id) { }

}

