namespace MultiFlare;

public class FlareRenderer : IFlareRenderer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Camera <GetCameras>b__8_0(CameraRenderer renderer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Camera camera; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <RemoveCamera>b__0(CameraRenderer cameraRenderer) { }

	}

	private const string OverDrawModeKeyword = "OVERDRAW_MODE"; //Field offset: 0x0
	private readonly HashSet _cameraRenderers; //Field offset: 0x10
	private readonly BatchCollection _batches; //Field offset: 0x18
	private readonly LightStorage _lightStorage; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsRendering>k__BackingField; //Field offset: 0x28

	public override bool IsDebugModeEnabled
	{
		 get { } //Length: 115
		 set { } //Length: 192
	}

	public private bool IsRendering
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public FlareRenderer(LightStorage lightStorage) { }

	public void AddCamera(CameraRenderer camera) { }

	public void AddFlare(int lightIndex, FlareLight flareLight) { }

	private void ApplyRenderCommands(IReadOnlyList batches) { }

	public void CompleteRendering() { }

	public void Dispose() { }

	public override bool get_IsDebugModeEnabled() { }

	[CompilerGenerated]
	public bool get_IsRendering() { }

	public override IEnumerable GetBatches() { }

	public override IEnumerable GetCameras() { }

	public void RegisterBatch(FlareType flareType, FlareBatch batch) { }

	public void RemoveCamera(Camera camera) { }

	public void RemoveFlare(int lightIndex, int replacedIndex) { }

	public void RenderInstantBatches() { }

	public override void set_IsDebugModeEnabled(bool value) { }

	[CompilerGenerated]
	private void set_IsRendering(bool value) { }

	public void StartRendering() { }

}

