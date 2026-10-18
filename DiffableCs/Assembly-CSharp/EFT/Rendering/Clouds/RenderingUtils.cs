namespace EFT.Rendering.Clouds;

public static class RenderingUtils
{
	internal class ObjectPool`1 : IDisposable
	{
		private readonly Stack _objects; //Field offset: 0x0
		private readonly Action _onGet; //Field offset: 0x0
		private readonly Action _onRelease; //Field offset: 0x0

		public ObjectPool`1(Action onGet = null, Action onRelease = null, int initialCapacity = 10) { }

		public override void Dispose() { }

		public T Get() { }

		public void Release(T obj) { }

	}

	private const float SLensAttenuation = 0.65; //Field offset: 0x0

	private static float LensImperfectionExposureScale
	{
		private get { } //Length: 9
	}

	public static void ClearRenderTarget(CommandBuffer cmd, bool isClearDepth, bool isClearColor, Color clearColor) { }

	private static Matrix4x4 ComputePixelCoordToWorldSpaceViewDirectionMatrix(float verticalFoV, Vector2 lensShift, Vector4 screenSize, Matrix4x4 worldToViewMatrix, bool renderToCubemap, float aspectRatio = -1, bool isOrthographic = false) { }

	public static Matrix4x4 ComputePixelCoordToWorldSpaceViewDirectionMatrix(Matrix4x4 proj, Matrix4x4 view, Camera camera, Vector4 resolution, float aspect = -1) { }

	public static float ConvertEv100ToExposure(float ev100) { }

	public static Material CreateEngineMaterial(Shader shader) { }

	public static void DrawFullScreen(CommandBuffer cmd, Material material, MaterialPropertyBlock block, int pass) { }

	public static Color EvaluateLightColor(Light light) { }

	private static int FixupDepthSlice(int depthSlice, CubemapFace cubemapFace) { }

	private static float get_LensImperfectionExposureScale() { }

	public static float ProjectionMatrixAspect(in Matrix4x4 matrix) { }

	public static void SafeDestroy(Object obj) { }

	public static void SetKeyword(ComputeShader computeShader, string keyword, bool state) { }

	public static void SetKeyword(Material material, string keyword, bool state) { }

	public static void SetKeyword(CommandBuffer cmd, string keyword, bool state) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier rtId, bool isClearDepth, bool isClearColor, Color clearColor, int mipLevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] rtColor, RenderTargetIdentifier rtDepth, int mipLevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier rtId, int mipLevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, int mipLevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, bool isClearDepth, bool isClearColor, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] rtColor, RenderTargetIdentifier rtDepth, bool isClearDepth, bool isClearColor, Color clearColor, int mipLevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

}

