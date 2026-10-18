namespace EFT.PostEffects;

[DisallowMultipleComponent]
[RequireComponent(typeof(Camera))]
public class OpticCullingMask : MonoBehaviour
{
	private static Mesh _quadMesh; //Field offset: 0x0
	private static readonly Matrix4x4 MatrixIdentity; //Field offset: 0x8
	[SerializeField]
	private Shader _cullingMaskShader; //Field offset: 0x20
	[Range(0, 2)]
	[SerializeField]
	public float _maskScale; //Field offset: 0x28
	private Camera _camera; //Field offset: 0x30
	private Material _material; //Field offset: 0x38
	private CameraEvent _cameraEvent; //Field offset: 0x40
	private CommandBuffer _commandBuffer; //Field offset: 0x48
	private int _maskScaleId; //Field offset: 0x50

	private static OpticCullingMask() { }

	public OpticCullingMask() { }

	private void Awake() { }

	private void OnDestroy() { }

	public void UpdateParameters() { }

}

