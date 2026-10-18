namespace EFT.UI;

[CreateAssetMenu(fileName = "New PocketMapConfig", menuName = "Scriptable objects/PocketMapConfig")]
public class PocketMapConfig : ScriptableObject
{
	internal struct TileInfo
	{
		public Texture Tile; //Field offset: 0x0
		public int X; //Field offset: 0x8
		public int Y; //Field offset: 0xC
		public int Scale; //Field offset: 0x10

	}

	public int ScalePreset; //Field offset: 0x18
	public Texture[] Textures; //Field offset: 0x20
	public TileInfo[] Tiles; //Field offset: 0x28

	public PocketMapConfig() { }

	public void ConvertTexturesToTiles() { }

	public Texture GetTexture(int x, int y, int scale) { }

}

