namespace Systems.Effects;

[RequireComponent(typeof(Camera))]
public class ScreenColorBlender : MonoBehaviour
{
	private static readonly int _value; //Field offset: 0x0
	private static readonly int _blendTex; //Field offset: 0x4
	[SerializeField]
	private Shader _shader; //Field offset: 0x20
	[SerializeField]
	private Color _color1; //Field offset: 0x28
	[SerializeField]
	private Color _color2; //Field offset: 0x38
	[SerializeField]
	private AnimationCurve _curve; //Field offset: 0x48
	[Range(0, 12)]
	[SerializeField]
	private int _downsamplingValue; //Field offset: 0x50
	[SerializeField]
	private bool _useExistingTexture; //Field offset: 0x54
	[SerializeField]
	private Texture2D _blendTexture; //Field offset: 0x58
	[Range(0, 1)]
	[SerializeField]
	private float _blendValue; //Field offset: 0x60
	private Material _material; //Field offset: 0x68
	private Texture _texture; //Field offset: 0x70

	private static ScreenColorBlender() { }

	public ScreenColorBlender() { }

	private void GenerateTextureAndReassignMaterial() { }

	private void OnDestroy() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destanation) { }

	private void Start() { }

}

