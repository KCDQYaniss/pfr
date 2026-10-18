//Type is in global namespace

[ExecuteInEditMode]
public class FogLight : LightOverride
{
	internal enum TextureSize
	{
		x256 = 256,
		x512 = 512,
		x1024 = 1024,
	}

	public bool m_ForceOnForFog; //Field offset: 0x48
	[Header("Shadows")]
	[Tooltip("Only one shadowed fog AreaLight at a time.")]
	public bool m_Shadows; //Field offset: 0x49
	[Tooltip("Always at most half the res of the AreaLight's shadowmap.")]
	public TextureSize m_ShadowmapRes; //Field offset: 0x4C
	[Range(0, 3)]
	public int m_BlurIterations; //Field offset: 0x50
	[MinValue(0)]
	public float m_BlurSize; //Field offset: 0x54
	[MinValue(0)]
	[Tooltip("Affects shadow softness.")]
	public float m_ESMExponent; //Field offset: 0x58
	public bool m_Bounded; //Field offset: 0x5C
	private bool m_AddedToLightManager; //Field offset: 0x5D
	private AreaLight _areaLight; //Field offset: 0x60
	private CommandBuffer m_BufGrabShadowmap; //Field offset: 0x68
	private CommandBuffer m_BufGrabShadowParams; //Field offset: 0x70
	private RenderTexture m_Shadowmap; //Field offset: 0x78
	private ComputeBuffer m_ShadowParamsCB; //Field offset: 0x80
	public Shader m_BlurShadowmapShader; //Field offset: 0x88
	private Material m_BlurShadowmapMaterial; //Field offset: 0x90
	public Shader m_CopyShadowParamsShader; //Field offset: 0x98
	private Material m_CopyShadowParamsMaterial; //Field offset: 0xA0
	private int[] temp; //Field offset: 0xA8

	private bool directionalShadow
	{
		private get { } //Length: 43
	}

	public FogLight() { }

	private void AddToLightManager() { }

	private void CleanupDirectionalShadowmap() { }

	private bool get_directionalShadow() { }

	public virtual bool GetForceOn() { }

	private void InitDirectionalShadowmap() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void ReleaseTemporary(ref RenderTexture rt) { }

	public bool SetUpDirectionalShadowmapForSampling(bool shadows, ComputeShader cs, int kernel) { }

	private void Update() { }

	public void UpdateDirectionalShadowmap() { }

}

