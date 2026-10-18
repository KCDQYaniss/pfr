//Type is in global namespace

[ExecuteInEditMode]
public sealed class TubeLight : BaseLight
{
	internal struct Data
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <_InvertedShadowPlanes>e__FixedBuffer
		{
			public float FixedElementField; //Field offset: 0x0

		}

		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <_ShadowPlanes>e__FixedBuffer
		{
			public float FixedElementField; //Field offset: 0x0

		}

		public Vector4 _LightPos; //Field offset: 0x0
		public Vector4 _LightAxis; //Field offset: 0x10
		public float _LightLength; //Field offset: 0x20
		public float _LightRadius; //Field offset: 0x24
		public uint _PackedKeywords; //Field offset: 0x28
		public float _ShadowPlaneFeather; //Field offset: 0x2C
		public float _InvertedShadowPlaneFeather; //Field offset: 0x30
		public float _SpecularScale; //Field offset: 0x34
		public float _pad0; //Field offset: 0x38
		public float _pad1; //Field offset: 0x3C
		[FixedBuffer(typeof(float), 24)]
		public <_ShadowPlanes>e__FixedBuffer _ShadowPlanes; //Field offset: 0x40
		[FixedBuffer(typeof(float), 24)]
		public <_InvertedShadowPlanes>e__FixedBuffer _InvertedShadowPlanes; //Field offset: 0xA0

	}

	private static readonly int _emissionColor; //Field offset: 0x0
	private const float K_MIN_RADIUS = 0.001; //Field offset: 0x0
	private static readonly Storage _storage; //Field offset: 0x8
	private static ColorSpace _currentColorSpace; //Field offset: 0x10
	public Color m_Color; //Field offset: 0x28
	[Range(0, 2)]
	public float m_SpecularScale; //Field offset: 0x38
	[Range(0, 500)]
	public float m_Range; //Field offset: 0x3C
	[Range(0.001, 30)]
	public float m_Radius; //Field offset: 0x40
	[Range(0, 100)]
	public float m_Length; //Field offset: 0x44
	public MeshRenderer ShadowCube; //Field offset: 0x48
	public MeshRenderer InvertedShadowCube; //Field offset: 0x50
	[Range(0, 10)]
	public float ShadowFeather; //Field offset: 0x58
	[Range(0, 10)]
	public float InvertedShadowFeather; //Field offset: 0x5C
	[HideInInspector]
	public Mesh m_Capsule; //Field offset: 0x60
	[Space]
	public bool m_Ambient; //Field offset: 0x68
	public bool m_Negative; //Field offset: 0x69
	public bool m_Specular; //Field offset: 0x6A
	private bool _initialized; //Field offset: 0x6B
	private Data _cachedData; //Field offset: 0x6C
	private Matrix4x4 _cachedPosition; //Field offset: 0x16C
	private bool _isCached; //Field offset: 0x1AC
	[CompilerGenerated]
	private bool <Subscribed>k__BackingField; //Field offset: 0x1AD
	[CompilerGenerated]
	private Bounds <Bounds>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; //Field offset: 0x1C8
	[Space]
	public bool m_RenderSource; //Field offset: 0x1C9
	public Color m_SourceColor; //Field offset: 0x1CC
	public Material SourceMaterial; //Field offset: 0x1E0
	private LazyComponent _sourceRenderer; //Field offset: 0x1E8
	private Mesh _sourceMesh; //Field offset: 0x1F0
	private float _lastLength; //Field offset: 0x1F8
	private float _lastRange; //Field offset: 0x1FC
	private float _lastRadius; //Field offset: 0x200
	private MaterialPropertyBlock _props; //Field offset: 0x208

	public private Bounds Bounds
	{
		[CompilerGenerated]
		 get { } //Length: 27
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public static ReadOnly GetStorageReadOnly
	{
		 get { } //Length: 115
	}

	public bool IsCached
	{
		 get { } //Length: 8
	}

	public private bool IsEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public static bool IsNeedForUpdateData
	{
		 get { } //Length: 3
	}

	public virtual float m_Intensity
	{
		 get { } //Length: 6
		 set { } //Length: 51
	}

	private bool RenderSource
	{
		private get { } //Length: 28
	}

	public bool Subscribed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	private static TubeLight() { }

	public TubeLight() { }

	private void Awake() { }

	private void CleanupRenderSource() { }

	private void DisableInternal() { }

	private void EnableInternal() { }

	private static void FillShadowCubePlanes(MeshRenderer cube, float* planes) { }

	[CompilerGenerated]
	public Bounds get_Bounds() { }

	public static ReadOnly get_GetStorageReadOnly() { }

	public bool get_IsCached() { }

	[CompilerGenerated]
	public bool get_IsEnabled() { }

	public static bool get_IsNeedForUpdateData() { }

	public virtual float get_m_Intensity() { }

	private bool get_RenderSource() { }

	[CompilerGenerated]
	public bool get_Subscribed() { }

	private static Bounds GetAABB(Matrix4x4 m) { }

	public Color GetColor() { }

	public void GetDefaultData(out Data data, out Matrix4x4 object2World, bool force) { }

	private bool InitIfNeeded() { }

	private bool InitRenderSource() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnDrawGizmosSelected() { }

	private void OnEnable() { }

	private void OnIntensityUpdate() { }

	public void Reinit() { }

	[CompilerGenerated]
	private void set_Bounds(Bounds value) { }

	[CompilerGenerated]
	private void set_IsEnabled(bool value) { }

	public virtual void set_m_Intensity(float value) { }

	[CompilerGenerated]
	public void set_Subscribed(bool value) { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

