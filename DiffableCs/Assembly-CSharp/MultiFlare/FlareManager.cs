namespace MultiFlare;

public class FlareManager
{
	private static FlareManager _instance; //Field offset: 0x0
	private LightStorage _lightStorage; //Field offset: 0x10
	private FlareRenderer _flareRenderer; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsRenderingEnabled>k__BackingField; //Field offset: 0x21

	public IFlareRenderer FlareRenderer
	{
		 get { } //Length: 5
	}

	public static FlareManager Instance
	{
		 get { } //Length: 169
	}

	public private bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool IsRenderingEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ILightStorage LightStorage
	{
		 get { } //Length: 5
	}

	private FlareManager() { }

	public FlareLightData AccessLightData(FlareLight flareLight) { }

	public void AddCamera(CameraRenderer camera) { }

	public void AddLight(FlareLight flareLight) { }

	public void CompleteRendering() { }

	public void Dispose() { }

	public void DisposeRenderer() { }

	public IFlareRenderer get_FlareRenderer() { }

	public static FlareManager get_Instance() { }

	[CompilerGenerated]
	public bool get_IsInitialized() { }

	[CompilerGenerated]
	public bool get_IsRenderingEnabled() { }

	public ILightStorage get_LightStorage() { }

	public void Initialize() { }

	public void RemoveCamera(Camera camera) { }

	public void RemoveLight(FlareLight flareLight) { }

	public void RenderInstantBatches() { }

	[Conditional("DEBUG")]
	public void RenderNow() { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	[CompilerGenerated]
	public void set_IsRenderingEnabled(bool value) { }

	public void SetupRenderer(FlareSettings settings) { }

	public void StartRendering() { }

}

