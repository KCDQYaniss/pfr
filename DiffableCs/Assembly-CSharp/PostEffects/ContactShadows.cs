namespace PostEffects;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public sealed class ContactShadows : MonoBehaviour
{
	private static readonly int _depth; //Field offset: 0x0
	private static readonly int _contrast1; //Field offset: 0x4
	private static readonly int _count; //Field offset: 0x8
	private static readonly int _convergence; //Field offset: 0xC
	private static readonly int _lightVector; //Field offset: 0x10
	private static readonly int _noiseScale; //Field offset: 0x14
	private static readonly int _noiseTex; //Field offset: 0x18
	private static readonly int _reprojection; //Field offset: 0x1C
	[SerializeField]
	private Light _light; //Field offset: 0x20
	[Range(0, 5)]
	[SerializeField]
	private float _rejectionDepth; //Field offset: 0x28
	[Range(0, 32)]
	[SerializeField]
	private int _sampleCount; //Field offset: 0x2C
	[Range(0, 1)]
	[SerializeField]
	private float _temporalFilter; //Field offset: 0x30
	[Range(0, 1)]
	[SerializeField]
	private float _contrast; //Field offset: 0x34
	[SerializeField]
	private bool _downsample; //Field offset: 0x38
	[SerializeField]
	private NoiseTextureSet _noiseTextures; //Field offset: 0x40
	[HideInInspector]
	[SerializeField]
	private Shader _shader; //Field offset: 0x48
	private Material _material; //Field offset: 0x50
	private RenderTexture _prevMaskRT1; //Field offset: 0x58
	private RenderTexture _prevMaskRT2; //Field offset: 0x60
	private CommandBuffer _command1; //Field offset: 0x68
	private CommandBuffer _command2; //Field offset: 0x70
	private Matrix4x4 _previousVP; //Field offset: 0x78
	private Camera _camera; //Field offset: 0xB8
	private SSAA _ssaa; //Field offset: 0xC0
	private int _shadowMaskId; //Field offset: 0xC8
	private int _prevMaskId; //Field offset: 0xCC
	private int _tempMaskId; //Field offset: 0xD0
	private int _unfilteredMaskID; //Field offset: 0xD4

	private static ContactShadows() { }

	public ContactShadows() { }

	private void Awake() { }

	private void BuildCommandBuffer() { }

	private static Matrix4x4 CalculateVPMatrix() { }

	private Vector2 GetScreenSize() { }

	private void Init() { }

	private void OnDestroy() { }

	private void OnPreCull() { }

	private void OnPreRender() { }

	private void OnValidate() { }

	private void SetMaterialValues() { }

	private void Update() { }

	private void UpdateTempObjects() { }

}

