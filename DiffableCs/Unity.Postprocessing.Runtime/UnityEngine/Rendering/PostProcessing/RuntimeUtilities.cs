namespace UnityEngine.Rendering.PostProcessing;

[Extension]
public static class RuntimeUtilities
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__95_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <GetAllAssemblyTypes>b__95_0(Assembly t) { }

	}

	[CompilerGenerated]
	private sealed class <GetAllSceneObjects>d__84`1 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private Queue <queue>5__2; //Field offset: 0x0
		private GameObject[] <>7__wrap2; //Field offset: 0x0
		private int <>7__wrap3; //Field offset: 0x0
		private IEnumerator <>7__wrap4; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetAllSceneObjects>d__84`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum USE_PROJ
	{
		OFFSETED = 0,
		TR_1 = 1,
		TR_2 = 2,
	}

	private static Texture2D m_WhiteTexture; //Field offset: 0x0
	private static Texture3D m_WhiteTexture3D; //Field offset: 0x8
	private static Texture2D m_BlackTexture; //Field offset: 0x10
	private static Texture3D m_BlackTexture3D; //Field offset: 0x18
	private static Texture2D m_TransparentTexture; //Field offset: 0x20
	private static Texture3D m_TransparentTexture3D; //Field offset: 0x28
	private static Dictionary m_LutStrips; //Field offset: 0x30
	private static PostProcessResources s_Resources; //Field offset: 0x38
	private static Mesh s_FullscreenTriangle; //Field offset: 0x40
	private static Material s_CopyStdMaterial; //Field offset: 0x48
	private static Material s_CopyStdFromDoubleWideMaterial; //Field offset: 0x50
	private static Material s_CopyMaterial; //Field offset: 0x58
	private static Material s_CopyFromTexArrayMaterial; //Field offset: 0x60
	private static PropertySheet s_CopySheet; //Field offset: 0x68
	private static PropertySheet s_CopyFromTexArraySheet; //Field offset: 0x70
	private static RenderTextureFormat _defaultHDRRenderTextureFormat; //Field offset: 0x78
	public static USE_PROJ UseProj; //Field offset: 0x7C
	private static IEnumerable m_AssemblyTypes; //Field offset: 0x80

	public static Texture2D blackTexture
	{
		 get { } //Length: 698
	}

	public static Texture3D blackTexture3D
	{
		 get { } //Length: 716
	}

	public static Material copyFromTexArrayMaterial
	{
		 get { } //Length: 650
	}

	public static PropertySheet copyFromTexArraySheet
	{
		 get { } //Length: 333
	}

	public static Material copyMaterial
	{
		 get { } //Length: 650
	}

	public static PropertySheet copySheet
	{
		 get { } //Length: 333
	}

	public static Material copyStdFromDoubleWideMaterial
	{
		 get { } //Length: 650
	}

	public static Material copyStdMaterial
	{
		 get { } //Length: 650
	}

	public static RenderTextureFormat defaultHDRRenderTextureFormat
	{
		 get { } //Length: 83
		 set { } //Length: 88
	}

	public static Mesh fullscreenTriangle
	{
		 get { } //Length: 1476
	}

	public static bool isAndroidOpenGL
	{
		 get { } //Length: 202
	}

	public static bool isLinearColorSpace
	{
		 get { } //Length: 75
	}

	public static bool isSinglePassStereoEnabled
	{
		 get { } //Length: 106
	}

	public static bool isVREnabled
	{
		 get { } //Length: 69
	}

	public static bool scriptableRenderPipelineActive
	{
		 get { } //Length: 206
	}

	public static bool supportsDeferredShading
	{
		 get { } //Length: 148
	}

	public static bool supportsDepthNormals
	{
		 get { } //Length: 151
	}

	public static Texture2D transparentTexture
	{
		 get { } //Length: 693
	}

	public static Texture3D transparentTexture3D
	{
		 get { } //Length: 711
	}

	public static Texture2D whiteTexture
	{
		 get { } //Length: 681
	}

	public static Texture3D whiteTexture3D
	{
		 get { } //Length: 716
	}

	private static RuntimeUtilities() { }

	[Extension]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Nullable viewport = null) { }

	[Extension]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Nullable viewport = null) { }

	[Extension]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, Nullable viewport = null) { }

	[Extension]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Nullable viewport = null) { }

	[Extension]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, Texture source, RenderTargetIdentifier destination, Material mat, int drawPass = 0, MaterialPropertyBlock prop = null, bool clear = false, Nullable viewport = null) { }

	[Extension]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false, Nullable viewport = null) { }

	[Extension]
	public static void BlitFullscreenTriangleFromDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye) { }

	[Extension]
	public static void BlitFullscreenTriangleFromTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1) { }

	[Extension]
	public static void BlitFullscreenTriangleToDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye) { }

	[Extension]
	public static void BlitFullscreenTriangleToTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1) { }

	[Extension]
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0) { }

	[Extension]
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	public static void CreateIfNull(ref T obj) { }

	public static void Destroy(Object obj) { }

	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects) { }

	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = false) { }

	public static float Exp2(float x) { }

	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter) { }

	public static Texture2D get_blackTexture() { }

	public static Texture3D get_blackTexture3D() { }

	public static Material get_copyFromTexArrayMaterial() { }

	public static PropertySheet get_copyFromTexArraySheet() { }

	public static Material get_copyMaterial() { }

	public static PropertySheet get_copySheet() { }

	public static Material get_copyStdFromDoubleWideMaterial() { }

	public static Material get_copyStdMaterial() { }

	public static RenderTextureFormat get_defaultHDRRenderTextureFormat() { }

	public static Mesh get_fullscreenTriangle() { }

	public static bool get_isAndroidOpenGL() { }

	public static bool get_isLinearColorSpace() { }

	public static bool get_isSinglePassStereoEnabled() { }

	public static bool get_isVREnabled() { }

	public static bool get_scriptableRenderPipelineActive() { }

	public static bool get_supportsDeferredShading() { }

	public static bool get_supportsDepthNormals() { }

	public static Texture2D get_transparentTexture() { }

	public static Texture3D get_transparentTexture3D() { }

	public static Texture2D get_whiteTexture() { }

	public static Texture3D get_whiteTexture3D() { }

	public static IEnumerable GetAllAssemblyTypes() { }

	[IteratorStateMachine(typeof(<GetAllSceneObjects>d__84`1))]
	public static IEnumerable GetAllSceneObjects() { }

	[Extension]
	public static T GetAttribute(Type type) { }

	public static string GetFieldPath(Expression expr) { }

	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset) { }

	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset) { }

	public static Vector2 GetJitterPerspectiveOffsetsPixel(Camera camera, Vector2 offset) { }

	public static Vector2 GetJitterPerspectiveOffsetsUV(Camera camera, Vector2 offset) { }

	public static Texture2D GetLutStrip(int size) { }

	public static Attribute[] GetMemberAttributes(Expression expr) { }

	public static bool isFloatingPointFormat(RenderTextureFormat format) { }

	public static bool IsPostProcessingActive(PostProcessLayer layer) { }

	public static bool IsResolvedDepthAvailable(Camera camera) { }

	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer) { }

	public static void SafeDestroy(Object obj) { }

	public static void set_defaultHDRRenderTextureFormat(RenderTextureFormat value) { }

	[Extension]
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Extension]
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	internal static void UpdateResources(PostProcessResources resources) { }

}

