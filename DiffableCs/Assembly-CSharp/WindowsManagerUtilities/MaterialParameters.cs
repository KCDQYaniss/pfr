namespace WindowsManagerUtilities;

internal struct MaterialParameters
{
	public Vector4 BakedParameters; //Field offset: 0x0
	public Vector4 MainColor; //Field offset: 0x10
	public Vector4 MainTexTilingOffset; //Field offset: 0x20
	public Vector4 SpecTexTilingOffset; //Field offset: 0x30

	public MaterialParameters(Material material, string mainTexName) { }

	public void Init(Material material, string mainTexName) { }

}

