namespace BSG.CameraEffects;

[RequireComponent(typeof(Camera))]
public class NightVision : MonoBehaviour, ITextureMaskHolder
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public float v; //Field offset: 0x10
		public Func <>9__0; //Field offset: 0x18

		public <>c__DisplayClass67_0() { }

		internal bool <GetMaxValueTime>b__0(Keyframe key) { }

	}

	private static readonly int _color; //Field offset: 0x0
	private static readonly int _intensity; //Field offset: 0x4
	private static readonly int _noise; //Field offset: 0x8
	private static readonly int _noiseScale; //Field offset: 0xC
	private static readonly int _noiseIntensity; //Field offset: 0x10
	private static readonly int _nightVisionOn; //Field offset: 0x14
	private static readonly int _finalRTId; //Field offset: 0x18
	private static readonly string _nightVisionNoiseKwrd; //Field offset: 0x20
	public Shader Shader; //Field offset: 0x20
	public float Intensity; //Field offset: 0x28
	public Texture Noise; //Field offset: 0x30
	public Texture Mask; //Field offset: 0x38
	public float MaskSize; //Field offset: 0x40
	public float NoiseIntensity; //Field offset: 0x44
	public float NoiseScale; //Field offset: 0x48
	[ColorUsage(False)]
	public Color Color; //Field offset: 0x4C
	public TextureMask TextureMask; //Field offset: 0x60
	public MonoBehaviour[] SwitchComponentsOn; //Field offset: 0x68
	public MonoBehaviour[] SwitchComponentsOff; //Field offset: 0x70
	public AnimationCurve BlackFlashGoingToOn; //Field offset: 0x78
	public AnimationCurve BlackFlashGoingToOff; //Field offset: 0x80
	public AudioClip SwitchOn; //Field offset: 0x88
	public AudioClip SwitchOff; //Field offset: 0x90
	public Texture ThermalMaskTexture; //Field offset: 0x98
	public Texture AnvisMaskTexture; //Field offset: 0xA0
	public Texture BinocularMaskTexture; //Field offset: 0xA8
	public Texture GasMaskTexture; //Field offset: 0xB0
	public Texture OldMonocularMaskTexture; //Field offset: 0xB8
	public float ambientFactor; //Field offset: 0xC0
	[SerializeField]
	private bool _on; //Field offset: 0xC4
	private Material _material; //Field offset: 0xC8
	private Material _materialUnlit; //Field offset: 0xD0
	private int _lastScreenWidth; //Field offset: 0xD8
	private int _lastScreenHeight; //Field offset: 0xDC
	private StateSwitcher _switcher; //Field offset: 0xE0
	[CanBeNull]
	private SSAA _ssaa; //Field offset: 0xE8
	private SSAAPropagator _ssaaPropagator; //Field offset: 0xF0
	private NightVisionZBlur _nightVisionZBlur; //Field offset: 0xF8
	private Nullable _targetState; //Field offset: 0x100
	private bool _firstTime; //Field offset: 0x102
	private CommandBuffer _nightVisionCB; //Field offset: 0x108
	private Camera _camera; //Field offset: 0x110
	private bool _isFpsCamera; //Field offset: 0x118
	private Vector4 _scaleVector; //Field offset: 0x11C
	private Color _ambient; //Field offset: 0x12C

	private Color CurrentColor
	{
		private get { } //Length: 138
	}

	public bool InProcessSwitching
	{
		 get { } //Length: 30
	}

	private Material Material
	{
		private get { } //Length: 372
	}

	public bool On
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	private static NightVision() { }

	public NightVision() { }

	[CompilerGenerated]
	private void <Init>b__55_0() { }

	[CompilerGenerated]
	private void <Init>b__55_1() { }

	public void ApplySettings() { }

	private void Awake() { }

	public void Construct(NightVisionZBlur nightVisionZBlur) { }

	public void FastForwardSwitch() { }

	private Color get_CurrentColor() { }

	public bool get_InProcessSwitching() { }

	private Material get_Material() { }

	public bool get_On() { }

	private static float GetMaxValueTime(AnimationCurve curve) { }

	private void Init() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnPostRender() { }

	private void OnPreCull() { }

	private void OnSwitchComplete() { }

	public void set_On(bool value) { }

	public void SetMask(EMask mask) { }

	public void StartSwitch(bool on) { }

	private void Switch(bool on) { }

	private void Update() { }

}

