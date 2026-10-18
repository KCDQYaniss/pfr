//Type is in global namespace

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(Camera))]
public class SSAOMask : MonoBehaviour
{
	private static Mesh _quadMesh; //Field offset: 0x0
	private static readonly Matrix4x4 MatrixIdentity; //Field offset: 0x8
	private static readonly int _ssaoMask; //Field offset: 0x48
	[SerializeField]
	private Shader _maskShader; //Field offset: 0x20
	private Camera _camera; //Field offset: 0x28
	private SSAA _ssaa; //Field offset: 0x30
	private CameraEvent _cameraEvent; //Field offset: 0x38
	private CommandBuffer _commandBuffer; //Field offset: 0x40
	private RenderTexture _maskTexture; //Field offset: 0x48
	private Material _material; //Field offset: 0x50
	private int _prevPixelHeight; //Field offset: 0x58
	private int _prevPixelWidth; //Field offset: 0x5C

	private static SSAOMask() { }

	public SSAOMask() { }

	public static Mesh GetQuadMesh(float z = 0.1) { }

	private void OnDestroy() { }

	private void OnPreCull() { }

	private void SetupBuffer() { }

	private void Start() { }

}

