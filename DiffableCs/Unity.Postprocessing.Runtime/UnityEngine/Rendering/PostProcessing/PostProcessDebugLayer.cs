namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessDebugLayer
{
	internal class OverlaySettings
	{
		public bool linearDepth; //Field offset: 0x10
		[Range(0, 16)]
		public float motionColorIntensity; //Field offset: 0x14
		[Range(4, 128)]
		public int motionGridSize; //Field offset: 0x18
		public ColorBlindnessType colorBlindnessType; //Field offset: 0x1C
		[Range(0, 1)]
		public float colorBlindnessStrength; //Field offset: 0x20

		public OverlaySettings() { }

	}

	public LightMeterMonitor lightMeter; //Field offset: 0x10
	public HistogramMonitor histogram; //Field offset: 0x18
	public WaveformMonitor waveform; //Field offset: 0x20
	public VectorscopeMonitor vectorscope; //Field offset: 0x28
	private Dictionary m_Monitors; //Field offset: 0x30
	private int frameWidth; //Field offset: 0x38
	private int frameHeight; //Field offset: 0x3C
	[CompilerGenerated]
	private RenderTexture <debugOverlayTarget>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <debugOverlayActive>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private DebugOverlay <debugOverlay>k__BackingField; //Field offset: 0x4C
	public OverlaySettings overlaySettings; //Field offset: 0x50

	public private DebugOverlay debugOverlay
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool debugOverlayActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private RenderTexture debugOverlayTarget
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public PostProcessDebugLayer() { }

	private void DestroyDebugOverlayTarget() { }

	internal void EndFrame() { }

	[CompilerGenerated]
	public DebugOverlay get_debugOverlay() { }

	[CompilerGenerated]
	public bool get_debugOverlayActive() { }

	[CompilerGenerated]
	public RenderTexture get_debugOverlayTarget() { }

	internal DepthTextureMode GetCameraFlags() { }

	internal void OnDisable() { }

	internal void OnEnable() { }

	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	internal void RenderMonitors(PostProcessRenderContext context) { }

	internal void RenderSpecialOverlays(PostProcessRenderContext context) { }

	public void RequestDebugOverlay(DebugOverlay mode) { }

	public void RequestMonitorPass(MonitorType monitor) { }

	[CompilerGenerated]
	private void set_debugOverlay(DebugOverlay value) { }

	[CompilerGenerated]
	private void set_debugOverlayActive(bool value) { }

	[CompilerGenerated]
	private void set_debugOverlayTarget(RenderTexture value) { }

	internal void SetFrameSize(int width, int height) { }

}

