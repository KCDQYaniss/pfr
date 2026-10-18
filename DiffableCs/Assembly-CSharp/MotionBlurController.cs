//Type is in global namespace

public class MotionBlurController
{
	private static readonly int _mainTex; //Field offset: 0x0
	private static readonly int _accumOrig; //Field offset: 0x4
	private ThermalVision _thermalVision; //Field offset: 0x10
	private Material _material; //Field offset: 0x18
	private RenderTexture accumTexture; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsNeedClear>k__BackingField; //Field offset: 0x28

	public bool IsNeedClear
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static MotionBlurController() { }

	public MotionBlurController(ThermalVision thermalVision) { }

	public void Dispose() { }

	[CompilerGenerated]
	public bool get_IsNeedClear() { }

	private Material GetMaterial() { }

	[CompilerGenerated]
	public void set_IsNeedClear(bool value) { }

	public void UpdateTexture(CommandBuffer commandBuffer, Camera camera, SSAA ssaa, RenderTargetIdentifier cameraTarget) { }

}

