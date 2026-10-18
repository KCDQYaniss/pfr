namespace GPUInstancer;

public class GPUInstancerRuntimeData
{
	public GPUInstancerPrototype prototype; //Field offset: 0x10
	public List instanceLODs; //Field offset: 0x18
	public Bounds instanceBounds; //Field offset: 0x20
	public float[] lodSizes; //Field offset: 0x38
	public float lodBiasApplied; //Field offset: 0x40
	[HideInInspector]
	public Matrix4x4[] instanceDataArray; //Field offset: 0x48
	public int instanceCount; //Field offset: 0x50
	public int bufferSize; //Field offset: 0x54
	public ComputeBuffer transformationMatrixVisibilityBuffer; //Field offset: 0x58
	public ComputeBuffer argsBuffer; //Field offset: 0x60
	public ComputeBuffer instanceLODDataBuffer; //Field offset: 0x68
	public uint[] args; //Field offset: 0x70
	public bool hasShadowCasterBuffer; //Field offset: 0x78
	public Material shadowCasterMaterial; //Field offset: 0x80
	public ComputeBuffer shadowArgsBuffer; //Field offset: 0x88
	public uint[] shadowArgs; //Field offset: 0x90
	public bool transformDataModified; //Field offset: 0x98

	public GPUInstancerRuntimeData(GPUInstancerPrototype prototype) { }

	public override void AddLod(float screenRelativeTransitionHeight = -1, bool excludeBounds = false) { }

	public override void AddLodAndRenderer(Mesh mesh, List materials, MaterialPropertyBlock mpb, bool castShadows, float lodSize = -1, MaterialPropertyBlock shadowMPB = null, bool excludeBounds = false, int layer = 0) { }

	public override void AddRenderer(int lod, Mesh mesh, List materials, Matrix4x4 transformOffset, MaterialPropertyBlock mpb, bool castShadows, int layer = 0, MaterialPropertyBlock shadowMPB = null, Renderer rendererRef = null) { }

	public override void CalculateBounds() { }

	public override bool CreateRenderersFromGameObject(GPUInstancerPrototype prototype) { }

	public override bool CreateRenderersFromMeshRenderers(int lod, GPUInstancerPrototype prototype) { }

	public override bool GenerateLODsFromLODGroup(GPUInstancerPrototype prototype) { }

	public override void GetMeshRenderersOfTransform(Transform objectTransform, List meshRenderers) { }

	public override void InitializeData() { }

	public override void ReleaseBuffers() { }

}

