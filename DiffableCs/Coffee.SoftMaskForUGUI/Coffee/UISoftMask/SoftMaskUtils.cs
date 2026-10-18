namespace Coffee.UISoftMask;

internal static class SoftMaskUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal CommandBuffer <.cctor>b__18_0() { }

		internal bool <.cctor>b__18_1(CommandBuffer x) { }

		internal void <.cctor>b__18_2(CommandBuffer x) { }

		internal MaterialPropertyBlock <.cctor>b__18_3() { }

		internal bool <.cctor>b__18_4(MaterialPropertyBlock x) { }

		internal void <.cctor>b__18_5(MaterialPropertyBlock x) { }

		internal void <InitializeOnLoadMethod>b__13_0() { }

	}

	public static readonly InternalObjectPool commandBufferPool; //Field offset: 0x0
	public static readonly InternalObjectPool materialPropertyBlockPool; //Field offset: 0x8
	private static Material s_SoftMaskingMaterialAdd; //Field offset: 0x10
	private static Material s_SoftMaskingMaterialSub; //Field offset: 0x18
	private static readonly int s_MainTex; //Field offset: 0x20
	private static readonly int s_ColorMask; //Field offset: 0x24
	private static readonly int s_BlendOp; //Field offset: 0x28
	private static readonly int s_ThresholdMin; //Field offset: 0x2C
	private static readonly int s_ThresholdMax; //Field offset: 0x30
	private static readonly int s_RenderScale; //Field offset: 0x34
	private static readonly int s_DynamicResolutionScale; //Field offset: 0x38
	private static float s_CurrentRenderScale; //Field offset: 0x3C
	private static Vector2 s_CurrentDynamicResolutionScale; //Field offset: 0x40

	private static SoftMaskUtils() { }

	public static void AddSoftMaskableOnChildren(MonoBehaviour self, bool includeSelf) { }

	public static void ApplyMaterialPropertyBlock(MaterialPropertyBlock mpb, int depth, Texture texture, MinMax01 threshold, float alpha) { }

	public static Material GetSoftMaskingMaterial(MaskingMethod method) { }

	private static Material GetSoftMaskingMaterial(ref Material mat, BlendOp op) { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void InitializeOnLoadMethod() { }

}

