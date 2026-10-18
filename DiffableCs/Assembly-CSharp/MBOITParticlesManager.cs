//Type is in global namespace

public class MBOITParticlesManager
{
	private struct CopyTexturesJob
	{
		public Texture2D noiseTexture; //Field offset: 0x0
		public Texture2D mainTexture; //Field offset: 0x8
		public int drawParamsIndex; //Field offset: 0x10

	}

	private struct DrawParams
	{
		public Vector4 _MainTex_ST; //Field offset: 0x0
		public Vector4 _TintColor; //Field offset: 0x10
		public Vector4 _IndoorTintColor; //Field offset: 0x20
		public float _AnimationSpeed; //Field offset: 0x30
		public float _Distortion; //Field offset: 0x34
		public float _InvFade; //Field offset: 0x38
		public uint _MainTexArrayOffset; //Field offset: 0x3C
		public uint _NoiseTexArrayOffset; //Field offset: 0x40
		public float _Indoor; //Field offset: 0x44

		public void SetIndoorPropertiesForce(Vector4 indoorTintColor, float indoor) { }

	}

	private struct DynamicSystem
	{
		public ParticleSystem ParticleSystem; //Field offset: 0x0
		public int MaxParticles; //Field offset: 0x8

	}

	private struct GlobalOffsets
	{
		public uint DrawParamsOffset; //Field offset: 0x0
		public uint ShaderIndex; //Field offset: 0x4

	}

	private struct IndirectDispatchArgs
	{
		public int groupsX; //Field offset: 0x0
		public int groupsY; //Field offset: 0x4
		public int groupsZ; //Field offset: 0x8

	}

	private struct IndirectDrawArgs
	{
		public int vertexCountPerInstance; //Field offset: 0x0
		public int instanceCount; //Field offset: 0x4
		public int startVertex; //Field offset: 0x8
		public int startInstance; //Field offset: 0xC

	}

	private struct MiscData
	{
		public ParticleSystemRenderer renderer; //Field offset: 0x0
		public Material material; //Field offset: 0x8
		public int renderArgsOffset; //Field offset: 0x10
		public int drawParamsOffset; //Field offset: 0x14

	}

	private struct PerShaderData
	{
		public int DrawArgsOffset; //Field offset: 0x0
		public Material Material; //Field offset: 0x8
		public HashSet ParticleSystems; //Field offset: 0x10
		public ResizableVertexBuffer ParticlesBuffers; //Field offset: 0x18

	}

	private class ResizableVertexBuffer
	{
		private struct ArrayChunk
		{
			public int offset; //Field offset: 0x0
			public int count; //Field offset: 0x4

		}

		private ComputeBuffer _particlesVerticesGlobal; //Field offset: 0x10
		private ComputeBuffer _particlesOffsetsGlobal; //Field offset: 0x18
		private List _availableChunks; //Field offset: 0x20
		private Dictionary _memoryInUse; //Field offset: 0x28
		private int _incrementSize; //Field offset: 0x30
		private string _offsetsName; //Field offset: 0x38
		private string _verticesNames; //Field offset: 0x40

		public ComputeBuffer ParticlesOffsets
		{
			 get { } //Length: 5
		}

		public ComputeBuffer ParticlesVertices
		{
			 get { } //Length: 5
		}

		public ResizableVertexBuffer(int initialSize, int incrementSize, int vertexStride, int offsetStride, string offsetsName, string verticesName) { }

		public void AddParticleSystem(ParticleSystem ps, out int outOffset, out int outCount, out bool outNeedToRebingBuffers) { }

		public void Cleanup() { }

		public ComputeBuffer get_ParticlesOffsets() { }

		public ComputeBuffer get_ParticlesVertices() { }

		public bool HasData() { }

		public void RemoveParticleSystem(ParticleSystem ps) { }

	}

	private class TextureArrayHolder
	{
		private RenderTexture _storage; //Field offset: 0x10
		private List _emptyLayer; //Field offset: 0x18
		private ComputeShader _copyShader; //Field offset: 0x20
		private Action _textureIsRecreatedAction; //Field offset: 0x28
		private List _garbageTextures; //Field offset: 0x30
		private Dictionary _existingTextures; //Field offset: 0x38

		public RenderTexture Storage
		{
			 get { } //Length: 5
		}

		public TextureArrayHolder(int resolution, int initialLayers, ComputeShader copyShader, Action textureIsRecreated) { }

		public int AddTexture(CommandBuffer cmdBuf, Texture2D texture) { }

		public int ContainsTexture(Texture2D texture) { }

		public int CopyTexture(CommandBuffer cmdBuf, Texture2D texture, int copyTo) { }

		public RenderTexture get_Storage() { }

		public void ProcessDelayedJobs() { }

		public void RemoveTexture(int index) { }

		public void ReserveTextureSpace(int count, CommandBuffer cmdBuf) { }

	}

	private struct VertexStruct
	{
		public Vector4 color; //Field offset: 0x0
		public Vector4 pos; //Field offset: 0x10
		public Vector4 uv0; //Field offset: 0x20
		public Vector4 uv1; //Field offset: 0x30
		public Vector2 distortAndFog; //Field offset: 0x40
		public Vector4 projPos; //Field offset: 0x48

	}

	private const string IndirectDataCleanupMarker = "Clear Particles Indirect Data"; //Field offset: 0x0
	private static ComputeBufferType _bufferType; //Field offset: 0x0
	private const string ParticlesBeforeRenderMarker = "MBOIT Particles Before Render"; //Field offset: 0x0
	private ResizableVertexBuffer _globalVertexBuffer; //Field offset: 0x10
	private ComputeBuffer _indirectDataBufferGlobal; //Field offset: 0x18
	private ComputeBuffer _indirectDataBufferLocal; //Field offset: 0x20
	private ComputeBuffer _drawParamsBuffer; //Field offset: 0x28
	private ComputeBuffer _indirectDispatchArgs; //Field offset: 0x30
	private List _indirectData; //Field offset: 0x38
	private List _availableIndirectData; //Field offset: 0x40
	private List _drawParamsData; //Field offset: 0x48
	private List _availableDrawParamsData; //Field offset: 0x50
	private List _dynamicSystems; //Field offset: 0x58
	private int _incrementSize; //Field offset: 0x60
	private ComputeShader _particlesIndirectArgsCleaner; //Field offset: 0x68
	private ComputeShader _renderDataCopyShader; //Field offset: 0x70
	private TextureArrayHolder _noiseTexture2DArray; //Field offset: 0x78
	private TextureArrayHolder _mainTexTexture2DArray; //Field offset: 0x80
	private Dictionary _perShaderData; //Field offset: 0x88
	private List _drawInfo; //Field offset: 0x90
	private List _copyTexturesJobs; //Field offset: 0x98
	private Dictionary _rendereres; //Field offset: 0xA0
	private int _buffersInitialSize; //Field offset: 0xA8

	public ComputeBuffer IndirectDataBuffer
	{
		 get { } //Length: 5
	}

	public ComputeBuffer ParticlesOffsets
	{
		 get { } //Length: 27
	}

	public ComputeBuffer ParticlesVertices
	{
		 get { } //Length: 27
	}

	private static MBOITParticlesManager() { }

	public MBOITParticlesManager(int initialSize, int incrementSize, ComputeShader particlesIndirectArgsCleaner, ComputeShader texturesCopyShader, ComputeShader renderDataCopyShader) { }

	private int AddDrawParams(Material material) { }

	public void AddParticleSystem(ParticleSystem ps, bool isDynamic = false) { }

	private int AddRenderArgs(int offset, int count) { }

	private void ApplyIndoorProperties(Material material, int index) { }

	public void BeforeRendering(CommandBuffer cmdBuf) { }

	public void Cleanup() { }

	public void ClearIndirectDrawData(CommandBuffer cmdBuf) { }

	public ComputeBuffer get_IndirectDataBuffer() { }

	public ComputeBuffer get_ParticlesOffsets() { }

	public ComputeBuffer get_ParticlesVertices() { }

	private void MainTextureArrayIsReCreated() { }

	private DrawParams MakeDrawParamsFromMaterial(Material material) { }

	private void NoiseTextureArrayIsReCreated() { }

	public void ProcessJobs() { }

	public void ReAssignDrawArgsBufferToMPBs() { }

	public void ReAssignDrawParamsBuffersToMPBs() { }

	private void ReAssignGlobalVertexBufferToMPBs() { }

	private void ReAssignLocalVertexBufferToMPBs() { }

	public void RemoveParticleSystem(ParticleSystem ps) { }

	public void RenderParticles(CommandBuffer cmdBuf, Camera camera) { }

	private int ShaderIndexFromDrawArgsOffset(int argsOffset) { }

	public void UpdateParticleSystemMaterial(ParticleSystem ps, Material material) { }

}

