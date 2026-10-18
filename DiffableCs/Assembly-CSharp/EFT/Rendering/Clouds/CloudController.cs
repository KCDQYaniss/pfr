namespace EFT.Rendering.Clouds;

public class CloudController : MonoBehaviour
{
	private BuiltinSkyParameters _parameters; //Field offset: 0x20
	private CloudLayerRenderer _renderer; //Field offset: 0x28
	private CommandBufferManager _shadowBuffer; //Field offset: 0x30
	private CommandBufferManager _cloudBuffer; //Field offset: 0x38
	private AmbientBuffer _ambientBuffer; //Field offset: 0x40
	[SerializeField]
	private Gradient _ambientColor; //Field offset: 0x48
	[SerializeField]
	private Light _sun; //Field offset: 0x50
	[SerializeField]
	private CloudLayer _settings; //Field offset: 0x58
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0x60

	public private bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public CloudLayer Settings
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public CloudController() { }

	[CompilerGenerated]
	public bool get_IsInitialized() { }

	public CloudLayer get_Settings() { }

	public void OnDisable() { }

	public void OnEnable() { }

	public void OnPreRenderCamera(Camera cam) { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	public void set_Settings(CloudLayer value) { }

	private void TryRenderShadows(CommandBuffer shadowBuffer) { }

	public void UpdateAmbient(SphericalHarmonicsL2 sh) { }

	private void UpdateParameters(BuiltinSkyParameters parameters, Camera cam, CommandBuffer buffer) { }

}

