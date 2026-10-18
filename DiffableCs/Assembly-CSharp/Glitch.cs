//Type is in global namespace

[RequireComponent(typeof(Camera))]
public class Glitch : MonoBehaviour
{
	private static readonly int _verticalJump; //Field offset: 0x0
	private static readonly int _scanLineJitter; //Field offset: 0x4
	private static readonly int _shake; //Field offset: 0x8
	private static readonly int _colorDrift; //Field offset: 0xC
	private static readonly int _mistakeIntensity; //Field offset: 0x10
	private static readonly int _switchIntensity; //Field offset: 0x14
	private static readonly int _dispTex; //Field offset: 0x18
	private static readonly int _filterRadius; //Field offset: 0x1C
	private static readonly int _direction; //Field offset: 0x20
	private static readonly int _flipUp; //Field offset: 0x24
	private static readonly int _flipDown; //Field offset: 0x28
	private static readonly int _displace; //Field offset: 0x2C
	private static readonly int _scale; //Field offset: 0x30
	[SerializeField]
	private Shader _shader; //Field offset: 0x20
	[SerializeField]
	private Texture2D _displacementMap; //Field offset: 0x28
	[Header("Digital Mistake")]
	[Range(0, 1)]
	[SerializeField]
	private float _digitalMistakeIntensity; //Field offset: 0x30
	[Range(0, 1)]
	[SerializeField]
	private float _digitalMistakeFrequency; //Field offset: 0x34
	[Header("Vertical Flip")]
	[Range(0, 1)]
	[SerializeField]
	private float _verticalFlipIntensity; //Field offset: 0x38
	[Range(0, 1)]
	[SerializeField]
	private float _verticalFlipFrequency; //Field offset: 0x3C
	[Header("Color Switch")]
	[Range(0, 1)]
	[SerializeField]
	private float _colorSwitchIntensity; //Field offset: 0x40
	[Range(0, 1)]
	[SerializeField]
	private float _colorSwitchFrequency; //Field offset: 0x44
	private float _currentColorSwitchIntensity; //Field offset: 0x48
	[Header("Vertical Jump")]
	[Range(0, 1)]
	[SerializeField]
	private float _verticalJumpCoef; //Field offset: 0x4C
	[Range(0, 1)]
	[SerializeField]
	private float _verticalJumpFrequency; //Field offset: 0x50
	[SerializeField]
	private float _verticalJumpTimeScale; //Field offset: 0x54
	[Header("Scan Line Jitter")]
	[Range(0, 1)]
	[SerializeField]
	private float _scanLineJitterCoef; //Field offset: 0x58
	[Range(0, 1)]
	[SerializeField]
	private float _scanLineJitterFrequency; //Field offset: 0x5C
	[Header("Horizontal Shake")]
	[Range(0, 1)]
	[SerializeField]
	private float _horizontalShake; //Field offset: 0x60
	[Range(0, 1)]
	[SerializeField]
	private float _horizontalShakeFrequency; //Field offset: 0x64
	[Header("Color Drift")]
	[Range(0, 1)]
	[SerializeField]
	private float _colorDriftCoef; //Field offset: 0x68
	[Range(0, 1)]
	[SerializeField]
	private float _colorDriftFrequency; //Field offset: 0x6C
	[SerializeField]
	private float _maxColorDrift; //Field offset: 0x70
	private Material _material; //Field offset: 0x78
	private float _glitchup; //Field offset: 0x80
	private float _glitchdown; //Field offset: 0x84
	private float _flicker; //Field offset: 0x88
	private float _glitchupTime; //Field offset: 0x8C
	private float _glitchdownTime; //Field offset: 0x90
	private float _flickerTime; //Field offset: 0x94

	private static Glitch() { }

	public Glitch() { }

	private float IsHappeningNow(float frequency) { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void SetFirstPassMaterialproperties() { }

	private void SetZeroPassMaterialproperties() { }

}

