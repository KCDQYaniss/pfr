namespace EFT.Rendering.Clouds;

internal class CloudLayerRenderer : CloudRenderer
{
	private class PrecomputationCache
	{
		private class RefCountedData
		{
			public int refCount; //Field offset: 0x10
			public readonly PrecomputationData data; //Field offset: 0x18

			public RefCountedData() { }

		}

		private readonly ObjectPool m_DataPool; //Field offset: 0x10
		private readonly Dictionary m_CachedData; //Field offset: 0x18

		public PrecomputationCache() { }

		public PrecomputationData Get(CloudLayer cloudLayer, int currentHash) { }

		public void Release(int hash) { }

	}

	private sealed class PrecomputationData
	{
		private struct TextureCache
		{
			private int width; //Field offset: 0x0
			private int height; //Field offset: 0x4
			private RenderTexture rt; //Field offset: 0x8

			public void Cache(int textureWidth, int textureHeight, RenderTexture texture) { }

			public bool TryGet(int textureWidth, int textureHeight, ref RenderTexture texture) { }

		}

		private static TextureCache cloudTextureCache; //Field offset: 0x0
		private static TextureCache cloudShadowsCache; //Field offset: 0x10
		private bool initialized; //Field offset: 0x10
		private int cloudTextureWidth; //Field offset: 0x14
		private int cloudTextureHeight; //Field offset: 0x18
		private int cloudShadowsResolution; //Field offset: 0x1C
		public RenderTexture cloudTextureRT; //Field offset: 0x20
		public RenderTexture cloudShadowsRT; //Field offset: 0x28

		public PrecomputationData() { }

		public void Allocate(CloudLayer cloudLayer) { }

		public void BakeCloudShadows(CloudLayer cloudLayer, Light sunLight, CommandBuffer cmd) { }

		public bool InitIfNeeded(CloudLayer cloudLayer, Light sunLight, CommandBuffer cmd) { }

		public void Release() { }

	}

	private struct UpdateGuard
	{
		public static readonly UpdateGuard Default; //Field offset: 0x0
		private int _lastFrame; //Field offset: 0x0

		private static UpdateGuard() { }

		public bool NeedUpdate(int currentFrame) { }

		public void Reset() { }

	}

	private static readonly int CloudTextureID; //Field offset: 0x0
	private static readonly int CloudShadowsID; //Field offset: 0x4
	private static readonly int CloudMapAid; //Field offset: 0x8
	private static readonly int AmbientProbeBufferID; //Field offset: 0xC
	private static ComputeShader _bakeCloudTextureCs; //Field offset: 0x10
	private static ComputeShader _bakeCloudShadowsCs; //Field offset: 0x18
	private static int _bakeCloudTextureKernel; //Field offset: 0x20
	private static int _bakeCloudShadowsKernel; //Field offset: 0x24
	private static readonly PrecomputationCache s_PrecomputationCache; //Field offset: 0x28
	private Material _cloudLayerMaterial; //Field offset: 0x18
	private readonly MaterialPropertyBlock _propertyBlock; //Field offset: 0x20
	private float _lastTime; //Field offset: 0x28
	private int _lastPrecomputationParamHash; //Field offset: 0x2C
	private UpdateGuard _cacheGuard; //Field offset: 0x30
	private UpdateGuard _shadowsGuard; //Field offset: 0x34
	private UpdateGuard _textureGuard; //Field offset: 0x38
	public readonly RenderTargetIdentifier[] MRTToRenderCloudOcclusion; //Field offset: 0x40
	private PrecomputationData m_PrecomputedData; //Field offset: 0x48

	public RenderTargetIdentifier CloudTexture
	{
		 get { } //Length: 97
	}

	private static CloudLayerRenderer() { }

	public CloudLayerRenderer() { }

	public virtual void Build() { }

	public virtual void Cleanup() { }

	internal virtual bool DoUpdate(BuiltinSkyParameters builtinParams) { }

	public RenderTargetIdentifier get_CloudTexture() { }

	public virtual bool GetSunLightCookieParameters(CloudSettings settings, BuiltinSkyParameters parameters, out CookieParameters cookieParams) { }

	public virtual void RenderClouds(BuiltinSkyParameters builtinParams, bool renderForCubemap) { }

	public virtual void RenderSunLightCookie(BuiltinSunCookieParameters builtinParams) { }

	internal void Reset() { }

	private bool UpdateCache(CloudLayer cloudLayer, Light sunLight) { }

	public bool UpdateTexture(BuiltinSunCookieParameters parameters) { }

	public bool UpdateTexture(BuiltinSkyParameters parameters) { }

	public bool UpdateTexture(CloudLayer settings, Light sunLight, CommandBuffer cmd, int frameIndex) { }

}

