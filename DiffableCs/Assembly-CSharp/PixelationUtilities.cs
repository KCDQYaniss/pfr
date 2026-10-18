//Type is in global namespace

public class PixelationUtilities
{
	public PixelationMode Mode; //Field offset: 0x10
	public Shader PixelationShader; //Field offset: 0x18
	[Range(2, 2048)]
	public float BlockCount; //Field offset: 0x20
	[Range(0, 1)]
	public float Alpha; //Field offset: 0x24
	public Texture PixelationMask; //Field offset: 0x28

	public PixelationUtilities() { }

}

