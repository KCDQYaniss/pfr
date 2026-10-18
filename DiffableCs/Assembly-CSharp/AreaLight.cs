//Type is in global namespace

[ExecuteInEditMode]
public sealed class AreaLight : BaseLight
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
		public uint _PackedKeywords; //Field offset: 0x10
		public float _pad0; //Field offset: 0x14
		public float _ShadowPlaneFeather; //Field offset: 0x18
		public float _InvertedShadowPlaneFeather; //Field offset: 0x1C
		[FixedBuffer(typeof(float), 24)]
		public <_ShadowPlanes>e__FixedBuffer _ShadowPlanes; //Field offset: 0x20
		[FixedBuffer(typeof(float), 24)]
		public <_InvertedShadowPlanes>e__FixedBuffer _InvertedShadowPlanes; //Field offset: 0x80
		public Matrix4x4 _ShadowProjectionMatrix; //Field offset: 0xE0
		public Matrix4x4 _ClipCube; //Field offset: 0x120
		public float _Hardness; //Field offset: 0x160
		public float _AtanFov; //Field offset: 0x164
		public float _SpecularScale; //Field offset: 0x168
		public float _pad1; //Field offset: 0x16C
		public Vector4 _LightDir; //Field offset: 0x170
		public Matrix4x4 _LightVerts; //Field offset: 0x180

	}

	private static readonly Storage _storage; //Field offset: 0x0
	private static readonly int _emissionColor; //Field offset: 0x8
	private static readonly float[,] _offsets; //Field offset: 0x10
	private static readonly Vector3[] _vertices; //Field offset: 0x18
	private static ColorSpace _currentColorSpace; //Field offset: 0x20
	[MinValue(0.001)]
	public float size; //Field offset: 0x28
	[MinValue(1)]
	public float length; //Field offset: 0x2C
	[MinValue(0)]
	public float depth; //Field offset: 0x30
	public Vector3 m_ClipBoxSize; //Field offset: 0x34
	[Range(0, 179)]
	public float m_Angle; //Field offset: 0x40
	[Range(0, 0.99)]
	public float m_Hardness; //Field offset: 0x44
	[Range(0, 2)]
	public float m_SpecularScale; //Field offset: 0x48
	public Color m_Color; //Field offset: 0x4C
	[Space]
	public bool m_Ambient; //Field offset: 0x5C
	public bool m_Negative; //Field offset: 0x5D
	public bool m_Specular; //Field offset: 0x5E
	[HideInInspectorButNotInDebug]
	public MeshRenderer ShadowCube; //Field offset: 0x60
	[HideInInspectorButNotInDebug]
	public MeshRenderer InvertedShadowCube; //Field offset: 0x68
	[HideInInspectorButNotInDebug]
	[Range(0, 10)]
	public float ShadowFeather; //Field offset: 0x70
	[HideInInspectorButNotInDebug]
	[Range(0, 10)]
	public float InvertedShadowFeather; //Field offset: 0x74
	[HideInInspectorButNotInDebug]
	public bool m_Spot; //Field offset: 0x78
	private Vector3 m_Size; //Field offset: 0x7C
	private bool _initialized; //Field offset: 0x88
	private Data _cachedData; //Field offset: 0x8C
	private Matrix4x4 _cachedPosition; //Field offset: 0x24C
	private bool _isCached; //Field offset: 0x28C
	[CompilerGenerated]
	private bool <Subscribed>k__BackingField; //Field offset: 0x28D
	[CompilerGenerated]
	private Bounds <Bounds>k__BackingField; //Field offset: 0x290
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; //Field offset: 0x2A8
	[HideInInspectorButNotInDebug]
	public bool m_RenderSource; //Field offset: 0x2A9
	[HideInInspectorButNotInDebug]
	public Color m_SourceColor; //Field offset: 0x2AC
	[HideInInspectorButNotInDebug]
	public Material SourceMaterial; //Field offset: 0x2C0
	[HideInInspector]
	public Mesh m_Quad; //Field offset: 0x2C8
	private LazyComponent _sourceRenderer; //Field offset: 0x2D0
	private Mesh _sourceMesh; //Field offset: 0x2D8
	private MaterialPropertyBlock _props; //Field offset: 0x2E0
	private Vector3 _cachedSize; //Field offset: 0x2E8
	private float _cachedAngle; //Field offset: 0x2F4

	public private Bounds Bounds
	{
		[CompilerGenerated]
		 get { } //Length: 27
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public static ReadOnly GetStorageReadOnly
	{
		 get { } //Length: 114
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

	public private bool Subscribed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private static AreaLight() { }

	public AreaLight() { }

	private void Awake() { }

	private void CalculateSize() { }

	private void CheckLocalScale() { }

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

	[CompilerGenerated]
	public bool get_Subscribed() { }

	private static Bounds GetAABB(Matrix4x4 m) { }

	public Vector4 GetColor() { }

	private static Color GetColorInLinear(Color color, float intensity) { }

	public void GetDefaultData(out Data data, out Matrix4x4 object2World, bool force) { }

	public Bounds GetFrustumBounds() { }

	public float GetNearToCenter() { }

	private static Matrix4x4 GetOffsetMatrix(float zOffset) { }

	private Matrix4x4 GetProjectionMatrix(bool linearZ = false) { }

	private bool InitIfNeeded() { }

	private bool InitRenderSource() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnDrawGizmosSelected() { }

	private void OnEnable() { }

	private void OnIntensityUpdate() { }

	private static Matrix4x4 PerspectiveLinearZ(float fov, float aspect, float near, float far) { }

	public void Reinit() { }

	[CompilerGenerated]
	private void set_Bounds(Bounds value) { }

	[CompilerGenerated]
	private void set_IsEnabled(bool value) { }

	public virtual void set_m_Intensity(float value) { }

	[CompilerGenerated]
	private void set_Subscribed(bool value) { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

