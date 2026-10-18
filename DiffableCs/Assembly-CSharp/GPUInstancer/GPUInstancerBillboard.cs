namespace GPUInstancer;

public class GPUInstancerBillboard
{
	public BillboardQuality billboardQuality; //Field offset: 0x10
	public int atlasResolution; //Field offset: 0x14
	public int frameCount; //Field offset: 0x18
	public bool replaceLODCullWithBillboard; //Field offset: 0x1C
	public bool isOverridingOriginalCutoff; //Field offset: 0x1D
	public float cutoffOverride; //Field offset: 0x20
	[Range(0, 1)]
	public float billboardBrightness; //Field offset: 0x24
	[Range(0.01, 1)]
	public float billboardDistance; //Field offset: 0x28
	public float quadSize; //Field offset: 0x2C
	public float yPivotOffset; //Field offset: 0x30
	public Texture2D albedoAtlasTexture; //Field offset: 0x38
	public Texture2D normalAtlasTexture; //Field offset: 0x40
	public bool customBillboardInLODGroup; //Field offset: 0x48
	public bool useCustomBillboard; //Field offset: 0x49
	public Mesh customBillboardMesh; //Field offset: 0x50
	public Material customBillboardMaterial; //Field offset: 0x58
	public bool isBillboardShadowCasting; //Field offset: 0x60
	public bool billboardFaceCamPos; //Field offset: 0x61

	public GPUInstancerBillboard() { }

}

