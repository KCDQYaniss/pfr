namespace Systems.Effects;

[ExecuteInEditMode]
public class GPUCullingManager : MonoBehaviourSingleton
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal int <.cctor>b__43_0(DispatchHandler x, DispatchHandler y) { }

	}

	internal class DispatchHandler : IDisposable, IBindable
	{
		private static readonly IndirectDrawIndexedArgs[] _tempArray; //Field offset: 0x0
		private GPUCullingManager _host; //Field offset: 0x10
		private GraphicsBuffer _visibleAppend; //Field offset: 0x18
		private GraphicsBuffer _indirectDraws; //Field offset: 0x20
		private GraphicsBuffer _positions; //Field offset: 0x28
		private ConstantBuffer _cb; //Field offset: 0x30
		[CompilerGenerated]
		private readonly EHiZGpuCullingType <Type>k__BackingField; //Field offset: 0x38

		public GraphicsBuffer AppendBuffer
		{
			 get { } //Length: 5
		}

		public HiZOcclusionCullingPerDispatchCB Data
		{
			 get { } //Length: 113
			 set { } //Length: 323
		}

		public GraphicsBuffer Draws
		{
			 get { } //Length: 5
		}

		public GraphicsBuffer Positions
		{
			 get { } //Length: 5
			 set { } //Length: 639
		}

		public EHiZGpuCullingType Type
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public bool Valid
		{
			 get { } //Length: 21
		}

		private static DispatchHandler() { }

		public DispatchHandler(in PerDispatchParams param) { }

		public void BindCBTo(CommandBuffer buffer, ComputeShader cs) { }

		public void BindCBTo(CommandBuffer buffer) { }

		private void Dispose(bool disposing) { }

		public override void Dispose() { }

		protected virtual void Finalize() { }

		public GraphicsBuffer get_AppendBuffer() { }

		public HiZOcclusionCullingPerDispatchCB get_Data() { }

		public GraphicsBuffer get_Draws() { }

		public GraphicsBuffer get_Positions() { }

		[CompilerGenerated]
		public EHiZGpuCullingType get_Type() { }

		public bool get_Valid() { }

		public void set_Data(HiZOcclusionCullingPerDispatchCB value) { }

		public void set_Positions(GraphicsBuffer value) { }

		private override void Systems.Effects.GPUCullingManager.IBindable.Bind(GPUCullingManager host) { }

		public void UnbindCBFrom(ComputeShader cs) { }

	}

	internal enum EHiZGpuCullingType
	{
		AABB = 0,
		Sphere = 1,
	}

	internal struct HiZOcclusionCullingPerDispatchCB
	{
		public int _InstanceCount; //Field offset: 0x0
		public Vector3 _Extents; //Field offset: 0x4
		public uint _EnableFrustumCulling; //Field offset: 0x10
		public float _MinPixelSize; //Field offset: 0x14
		public Vector2 _Pad0; //Field offset: 0x18

		public HiZOcclusionCullingPerDispatchCB(int count, Vector3 extents, bool enableFrustumCulling, float minPixelSize) { }

		public static HiZOcclusionCullingPerDispatchCB Default(int count) { }

		public static bool IsEquals(ref HiZOcclusionCullingPerDispatchCB left, ref HiZOcclusionCullingPerDispatchCB right) { }

	}

	internal struct HiZOcclusionCullingPerFrameCB
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <_FrustumPlanes>e__FixedBuffer
		{
			public float FixedElementField; //Field offset: 0x0

		}

		public Vector2Int _TextureSize; //Field offset: 0x0
		public uint _MaxMip; //Field offset: 0x8
		public float _OcclusionBias; //Field offset: 0xC
		public Matrix4x4 _WorldToView; //Field offset: 0x10
		public Matrix4x4 _Projection; //Field offset: 0x50
		public Matrix4x4 _ViewProj; //Field offset: 0x90
		[FixedBuffer(typeof(float), 24)]
		public <_FrustumPlanes>e__FixedBuffer _FrustumPlanes; //Field offset: 0xD0

		public HiZOcclusionCullingPerFrameCB(in PerFrameParams param) { }

		private static bool CompareMatrix(ref Matrix4x4 a, ref Matrix4x4 b) { }

		public static bool IsDirty(ref HiZOcclusionCullingPerFrameCB cached, in PerFrameParams param) { }

	}

	private interface IBindable
	{

		public void Bind(GPUCullingManager host) { }

	}

	private sealed class PerCameraData
	{
		public ConstantBuffer FrameData; //Field offset: 0x10
		public SortedSet Handlers; //Field offset: 0x18
		public GPUInstancerHiZOcclusionGenerator Generator; //Field offset: 0x20

		public PerCameraData() { }

	}

	internal struct PerDispatchParams
	{
		public GraphicsBuffer Positions; //Field offset: 0x0
		public HiZOcclusionCullingPerDispatchCB Data; //Field offset: 0x8
		public IndirectDrawIndexedArgs Args; //Field offset: 0x28
		public EHiZGpuCullingType Type; //Field offset: 0x3C

	}

	internal struct PerFrameParams
	{
		public Camera Camera; //Field offset: 0x0
		public Vector2 TextureSize; //Field offset: 0x8
		public int MaxMip; //Field offset: 0x10
		public float OcclusionBias; //Field offset: 0x14

	}

	private const CameraEvent K_CAMERA_EVENT = 4; //Field offset: 0x0
	private const int DEFAULT_CAMERA_CAPACITY = 4; //Field offset: 0x0
	private const int DEFAULT_DISPATCH_CAPACITY = 8; //Field offset: 0x0
	private const string _CubeName = "_CUBE"; //Field offset: 0x0
	private const string _SphereName = "_SPHERE"; //Field offset: 0x0
	private static readonly int _HiZTextureID; //Field offset: 0x0
	private static readonly int _ObjectToWorldID; //Field offset: 0x4
	private static readonly int _VisibleInstanceIndicesID; //Field offset: 0x8
	private static readonly int _CullingTypeID; //Field offset: 0xC
	private static readonly List _temp; //Field offset: 0x10
	private static readonly Comparer _comparer; //Field offset: 0x18
	private readonly CommandBufferManager _bufferManager; //Field offset: 0x20
	private readonly Dictionary _perCameraData; //Field offset: 0x28
	private readonly Dictionary _handlersPerCamera; //Field offset: 0x30
	[HideInInspectorButNotInDebug]
	[SerializeField]
	private Material _cullingDebugMaterial; //Field offset: 0x38
	[HideInInspectorButNotInDebug]
	[SerializeField]
	private ComputeShader _cullingCS; //Field offset: 0x40
	[SerializeField]
	private int _occlusionBias; //Field offset: 0x48
	private LocalKeyword _cubeKw; //Field offset: 0x50
	private LocalKeyword _sphereKw; //Field offset: 0x68
	private bool _isDirty; //Field offset: 0x80

	private static GPUCullingManager() { }

	public GPUCullingManager() { }

	public void Add(Camera cam, DispatchHandler handler) { }

	public virtual void Awake() { }

	private ConstantBuffer CreateFrameCB(Camera cam, GPUInstancerHiZOcclusionGenerator generator) { }

	public DispatchHandler CreateHandler(Camera cam, PerDispatchParams param) { }

	private PerFrameParams CreatePerFrameParams(Camera cam, GPUInstancerHiZOcclusionGenerator generator) { }

	public bool DrawDebug(Camera cam, CommandBuffer buffer, DispatchHandler handler) { }

	public bool DrawDebugCpu(Mesh mesh, Camera cam, CommandBuffer buffer, DispatchHandler handler) { }

	private GPUInstancerHiZOcclusionGenerator GetOrAddGenerator(Camera cam) { }

	private void LateUpdate() { }

	public virtual void OnDestroy() { }

	public bool Remove(Camera cam) { }

	public bool Remove(DispatchHandler handler, Camera targetCam = null) { }

	private void SetKeywordTo(EHiZGpuCullingType type, CommandBuffer buffer) { }

	private void UpdateFrameDataIfNeeded(Camera cam, PerCameraData data) { }

}

