//Type is in global namespace

public class StaticDeferredDecalQuadTreeDrawInstance
{
	private static readonly int _toWorldMatrixBuffer; //Field offset: 0x0
	private static readonly int _toLocalMatrixBuffer; //Field offset: 0x4
	private static readonly int _startEndBuffer; //Field offset: 0x8
	private static readonly int _edgeClipAndFadeoffBuffer; //Field offset: 0xC
	private static readonly int _tintBufferID; //Field offset: 0x10
	[CompilerGenerated]
	private CommandBuffer <CommandBuffer>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Bounds <Bounds>k__BackingField; //Field offset: 0x18
	private Material _material; //Field offset: 0x30
	private uint[] _args; //Field offset: 0x38
	private ComputeBuffer _argsBuffer; //Field offset: 0x40
	private ComputeBuffer _localToWorldMatrixBuffer; //Field offset: 0x48
	private ComputeBuffer _worldToLocalMatrixBuffer; //Field offset: 0x50
	private ComputeBuffer _uvStartEndBuffer; //Field offset: 0x58
	private ComputeBuffer _normalEdgeClipAndFadeoffBuffer; //Field offset: 0x60
	private ComputeBuffer _tintBuffer; //Field offset: 0x68
	private bool _enabled; //Field offset: 0x70
	private HashSet _cameras; //Field offset: 0x78

	public ComputeBuffer ArgsBuffer
	{
		 get { } //Length: 5
	}

	public private Bounds Bounds
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public private CommandBuffer CommandBuffer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Material Material
	{
		 get { } //Length: 76
	}

	private static StaticDeferredDecalQuadTreeDrawInstance() { }

	public StaticDeferredDecalQuadTreeDrawInstance() { }

	public void AddCommandBufferToCamera(Camera camera) { }

	public void DestroyBuffers() { }

	private void DestroyDataComputeBuffers() { }

	public void EnableCommandBuffer(bool enable) { }

	public ComputeBuffer get_ArgsBuffer() { }

	[CompilerGenerated]
	public Bounds get_Bounds() { }

	[CompilerGenerated]
	public CommandBuffer get_CommandBuffer() { }

	public Material get_Material() { }

	private void InitArgsBuffer(int decalsCount, Mesh mesh) { }

	public void InitBuffers(Material material, int decalsCount, Mesh mesh) { }

	private void InitComputeBuffer(ref ComputeBuffer computeBuffer, int stride, int decalsCount) { }

	public bool IsCommandBufferEnabled() { }

	private void ReleaseComputeBuffer(ref ComputeBuffer computeBuffer) { }

	[CompilerGenerated]
	private void set_Bounds(Bounds value) { }

	[CompilerGenerated]
	private void set_CommandBuffer(CommandBuffer value) { }

	private void UpdateArgsBuffer(int decalsCount, Mesh mesh) { }

	public void UpdateBuffers(List decals, Mesh mesh, Bounds bounds) { }

	private void UpdateLocalToWorldBuffer(List decals) { }

	private void UpdateNormalEdgeClipAndFadeoffBuffer(List decals) { }

	private void UpdateTintBuffer(List decals) { }

	private void UpdateUVStartEndBuffer(List decals) { }

	private void UpdateWorldToLocalBuffer(List decals) { }

}

