namespace BSG.CameraEffects;

[AddComponentMenu("Image Effects/TextureMask")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class TextureMask : MonoBehaviour
{
	private const string STRETCH_KEY = "_STRETCH"; //Field offset: 0x0
	private static readonly int _color; //Field offset: 0x0
	private static readonly int _mask; //Field offset: 0x4
	private static readonly int _invMaskSize; //Field offset: 0x8
	private static readonly int _invAspect; //Field offset: 0xC
	private static readonly int _cameraAspect; //Field offset: 0x10
	public Shader Shader; //Field offset: 0x20
	public Color Color; //Field offset: 0x28
	public Texture Mask; //Field offset: 0x38
	public bool Stretch; //Field offset: 0x40
	public float Size; //Field offset: 0x44
	private readonly HashSet _textureMaskHolders; //Field offset: 0x48
	private Material _material; //Field offset: 0x50
	private Camera _camera; //Field offset: 0x58
	private SSAA _ssaa; //Field offset: 0x60
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x68

	private static TextureMask() { }

	public TextureMask() { }

	public void ApplySettings() { }

	private void Awake() { }

	private Material GetMaterial() { }

	private void OnEnable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void OnValidate() { }

	public void TryToEnable(ITextureMaskHolder textureMaskHolder, bool on) { }

}

