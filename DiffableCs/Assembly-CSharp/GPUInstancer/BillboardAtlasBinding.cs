namespace GPUInstancer;

public class BillboardAtlasBinding
{
	public GameObject prefab; //Field offset: 0x10
	public int atlasResolution; //Field offset: 0x18
	public int frameCount; //Field offset: 0x1C
	public Texture2D albedoAtlasTexture; //Field offset: 0x20
	public Texture2D normalAtlasTexture; //Field offset: 0x28
	public float quadSize; //Field offset: 0x30
	public float yPivotOffset; //Field offset: 0x34
	public string modifiedDate; //Field offset: 0x38

	public BillboardAtlasBinding(GameObject prefab, int atlasResolution, int frameCount, Texture2D albedoAtlasTexture, Texture2D normalAtlasTexture, float quadSize, float yPivotOffset) { }

}

