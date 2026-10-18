namespace Systems.Effects;

[ExecuteInEditMode]
public class AreaLightRenderer : MonoBehaviour
{
	private const CameraEvent K_CAMERA_EVENT = 13; //Field offset: 0x0
	private static readonly int _transformInvDiffuseId; //Field offset: 0x0
	private static readonly int _transformInvSpecularId; //Field offset: 0x4
	private static readonly int _ampDiffAmpSpecFresnelId; //Field offset: 0x8
	private static Texture2D _transformInvTextureSpecular; //Field offset: 0x10
	private static Texture2D _transformInvTextureDiffuse; //Field offset: 0x18
	private static Texture2D _ampDiffAmpSpecFresnel; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private Mesh _mesh; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private Shader _shader; //Field offset: 0x28
	[SerializeField]
	private bool _enabledInstancing; //Field offset: 0x30
	private IBaseLightDrawer _drawer; //Field offset: 0x38
	private CommandBufferManager _bufferManager; //Field offset: 0x40
	private Material _material; //Field offset: 0x48
	private int _debugCount; //Field offset: 0x50
	private int _version; //Field offset: 0x54
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0x58

	public bool EnabledInstancing
	{
		 get { } //Length: 5
		 set { } //Length: 391
	}

	public private bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static AreaLightRenderer() { }

	public AreaLightRenderer() { }

	private void Awake() { }

	private void CheckSettingsAndReinitIfNeeded() { }

	public bool get_EnabledInstancing() { }

	[CompilerGenerated]
	public bool get_IsInitialized() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	public void Reinit() { }

	private void Render(Camera currentCamera) { }

	public void set_EnabledInstancing(bool value) { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	private static void SetCameraTag(Camera camera, CommandBuffer buffer) { }

	private void Start() { }

	private void Update() { }

}

