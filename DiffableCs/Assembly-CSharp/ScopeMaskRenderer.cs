//Type is in global namespace

[ExecuteInEditMode]
public class ScopeMaskRenderer : MonoBehaviour
{
	private static readonly Color _opticColor; //Field offset: 0x0
	private static readonly Color _сollimatorColor; //Field offset: 0x10
	private static readonly Color _activeCollimatorColor; //Field offset: 0x20
	private static readonly float _maxCollimatorSqrMagnitude; //Field offset: 0x30
	private static readonly int _scopeMask; //Field offset: 0x34
	private static readonly int _color; //Field offset: 0x38
	private CommandBufferManager _commandBufferManager; //Field offset: 0x20
	private SSAACameraManager _ssaaCameraManager; //Field offset: 0x28
	private Shader _scopeMaskShader; //Field offset: 0x30
	private Material _opticMaskMeterial; //Field offset: 0x38
	private Material _collimatorMaskMeterial; //Field offset: 0x40
	private Shader _activeCollimatorMaskShader; //Field offset: 0x48
	private Material _activeCollimatorMaskMeterial; //Field offset: 0x50
	private RenderTexture _maskTexture; //Field offset: 0x58
	private CollimatorSight _activeCollimatorSight; //Field offset: 0x60
	private HashSet _collimatorSights; //Field offset: 0x68

	private OpticSight CurrentOpticSight
	{
		private get { } //Length: 93
	}

	private static ScopeMaskRenderer() { }

	public ScopeMaskRenderer() { }

	private void Awake() { }

	private void CameraRender(Camera currentCamera) { }

	private void CheckMaskTexture(Camera currentCamera, SSAA ssaa) { }

	private void CleraAndSetBuffer(CommandBuffer buffer) { }

	private void CreateMaskTexture(Camera currentCamera, int width, int height) { }

	private void DrawActiveCollimator(CommandBuffer buffer) { }

	private void DrawCollimators(CommandBuffer buffer, Camera currentCamera) { }

	private void DrawOptic(CommandBuffer buffer) { }

	private OpticSight get_CurrentOpticSight() { }

	private void Init() { }

	private void OnCollimatorDisabled(CollimatorSight collimatorSight) { }

	private void OnCollimatorEnabled(CollimatorSight collimatorSight) { }

	private void OnCollimatorUpdated(CollimatorSight collimatorSight) { }

	private void OnDestroy() { }

	private void RenderBuffer(CommandBuffer buffer, Camera currentCamera, SSAA ssaa) { }

}

