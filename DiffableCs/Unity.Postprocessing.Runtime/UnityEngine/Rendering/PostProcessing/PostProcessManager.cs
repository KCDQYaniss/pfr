namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ReloadBaseTypes>b__12_0(Type t) { }

	}

	private static PostProcessManager s_Instance; //Field offset: 0x0
	private const int k_MaxLayerCount = 32; //Field offset: 0x0
	private readonly Dictionary m_SortedVolumes; //Field offset: 0x10
	private readonly List m_Volumes; //Field offset: 0x18
	private readonly Dictionary m_SortNeeded; //Field offset: 0x20
	private readonly List m_BaseSettings; //Field offset: 0x28
	private readonly List m_TempColliders; //Field offset: 0x30
	public readonly Dictionary settingsTypes; //Field offset: 0x38

	public static PostProcessManager instance
	{
		 get { } //Length: 215
	}

	private PostProcessManager() { }

	private void CleanBaseTypes() { }

	public static PostProcessManager get_instance() { }

	public void GetActiveVolumes(PostProcessLayer layer, List results, bool skipDisabled = true, bool skipZeroWeight = true) { }

	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer) { }

	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask) { }

	private List GrabVolumes(LayerMask mask) { }

	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera) { }

	public PostProcessVolume QuickVolume(int layer, float priority, PostProcessEffectSettings[] settings) { }

	private void Register(PostProcessVolume volume, int layer) { }

	internal void Register(PostProcessVolume volume) { }

	private void ReloadBaseTypes() { }

	private void ReplaceData(PostProcessLayer postProcessLayer) { }

	internal void SetLayerDirty(int layer) { }

	private static void SortByPriority(List volumes) { }

	private void Unregister(PostProcessVolume volume, int layer) { }

	internal void Unregister(PostProcessVolume volume) { }

	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera) { }

	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer) { }

}

