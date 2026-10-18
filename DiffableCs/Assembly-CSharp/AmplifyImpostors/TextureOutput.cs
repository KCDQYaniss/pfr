namespace AmplifyImpostors;

public class TextureOutput
{
	[SerializeField]
	public int Index; //Field offset: 0x10
	[SerializeField]
	public OverrideMask OverrideMask; //Field offset: 0x14
	public bool Active; //Field offset: 0x18
	public string Name; //Field offset: 0x20
	public TextureScale Scale; //Field offset: 0x28
	public bool SRGB; //Field offset: 0x2C
	public TextureChannels Channels; //Field offset: 0x30
	public TextureCompression Compression; //Field offset: 0x34
	public ImageFormat ImageFormat; //Field offset: 0x38

	public TextureOutput() { }

	public TextureOutput(bool a, string n, TextureScale s, bool sr, TextureChannels c, TextureCompression nc, ImageFormat i) { }

	public TextureOutput Clone() { }

}

