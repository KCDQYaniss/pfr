namespace GPUInstancer;

public abstract class GPUInstancerPrototype : ScriptableObject
{
	public GameObject prefabObject; //Field offset: 0x18
	public bool isShadowCasting; //Field offset: 0x20
	public bool useCustomShadowDistance; //Field offset: 0x21
	public float shadowDistance; //Field offset: 0x24
	public float[] shadowLODMap; //Field offset: 0x28
	public bool useOriginalShaderForShadow; //Field offset: 0x30
	public bool cullShadows; //Field offset: 0x31
	public float minDistance; //Field offset: 0x34
	public float maxDistance; //Field offset: 0x38
	public float minDistanceOptic; //Field offset: 0x3C
	public float maxDistanceOptic; //Field offset: 0x40
	public bool isFrustumCulling; //Field offset: 0x44
	public bool isOcclusionCulling; //Field offset: 0x45
	public float minCullingDistance; //Field offset: 0x48
	public float occlusionOffset; //Field offset: 0x4C
	public int occlusionAccuracy; //Field offset: 0x50
	public Vector3 boundsOffset; //Field offset: 0x54
	public bool isLODCrossFade; //Field offset: 0x60
	public bool isLODCrossFadeAnimate; //Field offset: 0x61
	[Range(0.01, 1)]
	public float lodFadeTransitionWidth; //Field offset: 0x64
	public float lodBiasAdjustment; //Field offset: 0x68
	public GPUInstancerBillboard billboard; //Field offset: 0x70
	public bool isBillboardDisabled; //Field offset: 0x78
	public bool useGeneratedBillboard; //Field offset: 0x79
	public bool checkedForBillboardExtensions; //Field offset: 0x7A
	public bool autoUpdateTransformData; //Field offset: 0x7B
	public GPUInstancerTreeType treeType; //Field offset: 0x7C
	public string warningText; //Field offset: 0x80

	protected GPUInstancerPrototype() { }

	public virtual string ToString() { }

}

