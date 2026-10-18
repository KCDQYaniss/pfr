//Type is in global namespace

public class StaticDeferredDecalDrawInstance
{
	private static ComputeBuffer _localToWorldMatrixBuffer; //Field offset: 0x0
	private static ComputeBuffer _worldToLocalMatrixBuffer; //Field offset: 0x8
	private static ComputeBuffer _uvStartEndBuffer; //Field offset: 0x10
	private static ComputeBuffer _normalEdgeClipAndFadeoffBuffer; //Field offset: 0x18
	private static ComputeBuffer _tintBuffer; //Field offset: 0x20
	private static ComputeBuffer _textureArrayIndexBuffer; //Field offset: 0x28
	private static ComputeBuffer _scaleOffsetBuffer; //Field offset: 0x30
	private static ComputeBuffer _colorBuffer; //Field offset: 0x38
	private static ComputeBuffer _normalPowerBuffer; //Field offset: 0x40
	private static ComputeBuffer _specularColorBuffer; //Field offset: 0x48
	private static ComputeBuffer _specSmoothnessBuffer; //Field offset: 0x50
	private static ComputeBuffer _alphaMultiplierBuffer; //Field offset: 0x58
	private static ComputeBuffer _temperatureBuffer; //Field offset: 0x60
	private static readonly int _toWorldMatrixBuffer; //Field offset: 0x68
	private static readonly int _toLocalMatrixBuffer; //Field offset: 0x6C
	private static readonly int _startEndBuffer; //Field offset: 0x70
	private static readonly int _edgeClipAndFadeoffBuffer; //Field offset: 0x74
	private static readonly int _tintBufferID; //Field offset: 0x78
	private static readonly int _textureArrayIndexBufferID; //Field offset: 0x7C
	private static readonly int _scaleOffsetBufferID; //Field offset: 0x80
	private static readonly int _colorBufferID; //Field offset: 0x84
	private static readonly int _normalPowerBufferID; //Field offset: 0x88
	private static readonly int _specularColorBufferID; //Field offset: 0x8C
	private static readonly int _specSmoothnessBufferID; //Field offset: 0x90
	private static readonly int _alphaMultiplierBufferID; //Field offset: 0x94
	private static readonly int _temperatureBufferID; //Field offset: 0x98
	private static readonly int _colorPropertyID; //Field offset: 0x9C
	private static readonly int _normalPowerPropertyID; //Field offset: 0xA0
	private static readonly int _specularColorPropertyID; //Field offset: 0xA4
	private static readonly int _specSmoothnessPropertyID; //Field offset: 0xA8
	private static readonly int _alphaMultiplierPropertyID; //Field offset: 0xAC
	private static readonly int _temperaturePropertyID; //Field offset: 0xB0
	private static readonly int _mainTextureID; //Field offset: 0xB4
	private static readonly int _bumpMapTextureID; //Field offset: 0xB8
	private static readonly int _mainTextureArrayID; //Field offset: 0xBC
	private static readonly int _bumpTextureArrayID; //Field offset: 0xC0
	[CompilerGenerated]
	private CommandBuffer <CommandBuffer>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Bounds <Bounds>k__BackingField; //Field offset: 0x18
	private Material _material; //Field offset: 0x30
	private bool _isMaterialInstance; //Field offset: 0x38
	private readonly SortedList _materials; //Field offset: 0x40
	private uint[] _args; //Field offset: 0x48
	private ComputeBuffer _argsBuffer; //Field offset: 0x50
	private int _startIndex; //Field offset: 0x58
	private int bumpWidth; //Field offset: 0x5C
	private int bumpHeight; //Field offset: 0x60
	private TextureFormat bumpFormat; //Field offset: 0x64
	private int _decalsCount; //Field offset: 0x68
	private Texture2DArray _mainTextureArray; //Field offset: 0x70
	private Texture2DArray _bumpTextureArray; //Field offset: 0x78

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

	public int Count
	{
		 get { } //Length: 4
	}

	public ComputeBuffer LocalToWorldMatrixBuffer
	{
		 get { } //Length: 83
	}

	public Material Material
	{
		 get { } //Length: 76
	}

	public ComputeBuffer NormalEdgeClipAndFadeoffBuffer
	{
		 get { } //Length: 84
	}

	public int StartIndex
	{
		 get { } //Length: 4
	}

	public ComputeBuffer TintBuffer
	{
		 get { } //Length: 84
	}

	public ComputeBuffer UVStartEndBuffer
	{
		 get { } //Length: 84
	}

	public ComputeBuffer WorldToLocalMatrixBuffer
	{
		 get { } //Length: 84
	}

	private static StaticDeferredDecalDrawInstance() { }

	public StaticDeferredDecalDrawInstance() { }

	private void CopyMipsManual(Texture2D texture, Texture2DArray textureArray, int slice, int startMip, int endMip) { }

	private void CreateTextureArray(ref Texture2DArray textureArray, int width, int height, TextureFormat format, int textureID) { }

	private void DestroyDataComputeBuffers() { }

	public void DestroyResources() { }

	private void DestroyTextureArray(ref Texture2DArray textureArray) { }

	public ComputeBuffer get_ArgsBuffer() { }

	[CompilerGenerated]
	public Bounds get_Bounds() { }

	[CompilerGenerated]
	public CommandBuffer get_CommandBuffer() { }

	public int get_Count() { }

	public ComputeBuffer get_LocalToWorldMatrixBuffer() { }

	public Material get_Material() { }

	public ComputeBuffer get_NormalEdgeClipAndFadeoffBuffer() { }

	public int get_StartIndex() { }

	public ComputeBuffer get_TintBuffer() { }

	public ComputeBuffer get_UVStartEndBuffer() { }

	public ComputeBuffer get_WorldToLocalMatrixBuffer() { }

	private void InitArgsBuffer(int decalsCount, Mesh mesh) { }

	private static void InitComputeBuffer(ref ComputeBuffer computeBuffer, int decalsCount) { }

	public static void InitGlobalBuffers(int decalsCount) { }

	public void InitInstance(Material material, bool isMaterialInstance, int decalsCount, Mesh mesh) { }

	private void ReleaseComputeBuffer(ref ComputeBuffer computeBuffer) { }

	[CompilerGenerated]
	private void set_Bounds(Bounds value) { }

	[CompilerGenerated]
	private void set_CommandBuffer(CommandBuffer value) { }

	public void SetStartIndex(int startIndex) { }

	private void UpdateArgsBuffer(int decalsCount, Mesh mesh) { }

	public void UpdateBuffers(List decals, Mesh mesh, Bounds bounds) { }

	private void UpdateLocalToWorldBuffer(List decals) { }

	private void UpdateNormalEdgeClipAndFadeoffBuffer(List decals) { }

	private bool UpdateTextureArrayIndices(List decals) { }

	private void UpdateTintBuffer(List decals) { }

	private void UpdateUVStartEndBuffer(List decals) { }

	private void UpdateWorldToLocalBuffer(List decals) { }

}

