//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class ThermalVision : MonoBehaviour, ITextureMaskHolder
{
	private static readonly int _finalRTId; //Field offset: 0x0
	private static readonly int _rampTex; //Field offset: 0x4
	private static readonly int _mainTexColorCoef; //Field offset: 0x8
	private static readonly int _minimumTemperatureValue; //Field offset: 0xC
	private static readonly int _noise; //Field offset: 0x10
	private static readonly int _noiseIntensity; //Field offset: 0x14
	private static readonly int _depthFade; //Field offset: 0x18
	private static readonly int _rampShift; //Field offset: 0x1C
	private static readonly int _thermalVisionOn; //Field offset: 0x20
	private static readonly int _radiusBlur; //Field offset: 0x24
	private static readonly int _bias; //Field offset: 0x28
	public bool On; //Field offset: 0x20
	public bool IsNoisy; //Field offset: 0x21
	public bool IsFpsStuck; //Field offset: 0x22
	public bool IsMotionBlurred; //Field offset: 0x23
	public bool IsGlitch; //Field offset: 0x24
	public bool IsPixelated; //Field offset: 0x25
	public ThermalVisionUtilities ThermalVisionUtilities; //Field offset: 0x28
	public StuckFPSUtilities StuckFpsUtilities; //Field offset: 0x30
	public MotionBlurUtilities MotionBlurUtilities; //Field offset: 0x38
	public GlitchUtilities GlitchUtilities; //Field offset: 0x40
	public PixelationUtilities PixelationUtilities; //Field offset: 0x48
	public TextureMask TextureMask; //Field offset: 0x50
	public MonoBehaviour[] SwitchComponentsOn; //Field offset: 0x58
	public MonoBehaviour[] SwitchComponentsOff; //Field offset: 0x60
	public float ChromaticAberrationThermalShift; //Field offset: 0x68
	public AnimationCurve BlackFlashGoingToOn; //Field offset: 0x70
	public AnimationCurve BlackFlashGoingToOff; //Field offset: 0x78
	public AudioClip SwitchOn; //Field offset: 0x80
	public AudioClip SwitchOff; //Field offset: 0x88
	[Header("Unsharp Mask")]
	public float UnsharpRadiusBlur; //Field offset: 0x90
	public float UnsharpBias; //Field offset: 0x94
	private StateSwitcher _switcher; //Field offset: 0x98
	private Nullable _targetState; //Field offset: 0xA0
	private bool _firstTime; //Field offset: 0xA2
	private CommandBuffer _thermalVisionCB; //Field offset: 0xA8
	private CommandBuffer _copyGBufferCB; //Field offset: 0xB0
	private Material _material; //Field offset: 0xB8
	private Camera _camera; //Field offset: 0xC0
	private StuckFPSController _stuckFpsController; //Field offset: 0xC8
	private MotionBlurController _motionBlurController; //Field offset: 0xD0
	private GlitchController _glitchController; //Field offset: 0xD8
	private PixelationController _pixelationController; //Field offset: 0xE0
	private VolumetricLightRenderer _volumetricLightRenderer; //Field offset: 0xE8
	private SSAA _ssaa; //Field offset: 0xF0
	private MBOIT_Scattering _scattering; //Field offset: 0xF8
	private ChromaticAberration _chromaticAberrationToControl; //Field offset: 0x100
	private float _chromaticAberrationDefaultShift; //Field offset: 0x108
	private float _shadowDistance; //Field offset: 0x10C

	public bool InProcessSwitching
	{
		 get { } //Length: 30
	}

	private static ThermalVision() { }

	public ThermalVision() { }

	[CompilerGenerated]
	private void <Init>b__52_0() { }

	[CompilerGenerated]
	private void <Init>b__52_1() { }

	private void Awake() { }

	public void FastForwardSwitch() { }

	public bool get_InProcessSwitching() { }

	private static float GetMaxValueTime(AnimationCurve curve) { }

	private Texture GetRampTexture() { }

	private void Init() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnPostRender() { }

	private void OnPreCull() { }

	public void SetMask(EMask mask) { }

	public void SetMaterialProperties() { }

	public void StartSwitch(bool on) { }

	private void Switch(bool on) { }

	public void Toggle() { }

	private void Update() { }

}

